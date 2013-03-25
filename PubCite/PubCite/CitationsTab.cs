using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PubCite
{
    public partial class CitationsTab : UserControl
    {
        ListViewItem item;
        List<SG.Paper> MainPapers;
        List<SG.Paper> Citations;
        
        GSScraper GSScraper;
        CSXParser CSParser;
        MicrosoftScholarParser MSParser;
        
        Boolean[] prevSortedColum = { false, false, false, false };
        BackgroundWorker backgroundWorker;

        int type;
        int citationIndex;
        string gs_url;

        public CitationsTab()
        {
            InitializeComponent();
            authorResultsListView.ColumnClick += new ColumnClickEventHandler(authorResultsListView_ColumnClick);
            authorResultsListView.FullRowSelect = true;
            authorResultsListView.MouseClick += new MouseEventHandler(authorResultsListView_MouseClick);
            authorResultsListView.MouseDoubleClick += new MouseEventHandler(authorResultsListView_MouseDoubleClick);
            authorResultsListView.DrawItem += ListView_DrawItem;
            authorResultsListView.DrawColumnHeader += ListView_DrawColumnHeader;
            abstractBox.GotFocus += abstractBox_GotFocus;
        }

        void abstractBox_GotFocus(object sender, EventArgs e)
        {
            System.Windows.Forms.SendKeys.Send("{tab}");
        }

        void ListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        void ListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DimGray, e.Bounds);
            e.DrawText();
        }


        public void populateCitations(SG.Paper paper, List<SG.Paper> Papers, int t) {

            
            if (Papers != null)
            {
                
                MainPapers = Papers;
                type = t;

                /* Add statistics */
                publicationsDetailsGroupBox.Text = paper.Title;
                authorsName.Text = paper.Authors;
                yearLabel.Text = paper.Year.ToString();
                venue.Text = paper.Publication;
                numCitations.Text = paper.NumberOfCitations.ToString();
                publisher.Text = paper.Publisher;
                abstractBox.Text = paper.Summary;

                authorResultsListView.Items.Clear();
                for (int i = 0; i < Papers.Count; i++)
                {

                    /*populating */
                    item = new ListViewItem(Papers[i].Title);
                    item.SubItems.Add(Papers[i].Authors);
                    item.SubItems.Add(Papers[i].Year.ToString());
                    item.SubItems.Add(Papers[i].NumberOfCitations.ToString());
                    authorResultsListView.Items.Add(item);
                    //Console.WriteLine(Papers[i].Title + Papers[i].Year + Papers[i].NumberOfCitations);
                }
            }                                      
        }

        public void RepopulateCitations(List<SG.Paper> Papers) {

            MainPapers = Papers;
            authorResultsListView.Items.Clear();
            for (int i = 0; i < Papers.Count; i++)
            {

                /*populating */
                item = new ListViewItem(Papers[i].Title);
                item.SubItems.Add(Papers[i].Authors);
                item.SubItems.Add(Papers[i].Year.ToString());
                item.SubItems.Add(Papers[i].NumberOfCitations.ToString());
                authorResultsListView.Items.Add(item);
                //Console.WriteLine(Papers[i].Title + Papers[i].Year + Papers[i].NumberOfCitations);
            }
            
        
        
        }

        private void authorResultsListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (authorResultsListView.FocusedItem.Bounds.Contains(e.Location) == true)
                    optionMenuStrip.Show(Cursor.Position);

            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Form1.dub_tab.TabPages.Remove(Form1.dub_tab.SelectedTab);
            Form1.dub_tab.SelectedIndex = Form1.dub_tab.TabCount - 2;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.MarqueeAnimationSpeed = 0;
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Value = progressBar.Minimum;
        }

        private void backgroundWorker_citationSearchWork(object sender, DoWorkEventArgs e)
        {
            if (type == 0)
                Citations = CSParser.getCitations(MainPapers[citationIndex].CitedByURL);
            else if (type == 1)
                Citations = GSScraper.getCitations(MainPapers[citationIndex].CitedByURL, ref gs_url);
            else if (type == 2)
                Citations = MSParser.getCitations(MainPapers[citationIndex].CitedByURL);
        }

        private void authorResultsListView_MouseDoubleClick(object sender, EventArgs e)
        {
            viewCitationsToolStripMenuItem_Click(sender, e);
        }

        private void viewCitationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++) prevSortedColum[i] = false;
            citationIndex = authorResultsListView.FocusedItem.Index;

            if (MainPapers[citationIndex].NumberOfCitations != 0)
            {
                if (type == 0)
                    CSParser = new CSXParser();
                else if (type == 1)
                    GSScraper = new GSScraper();
                else if (type == 2)
                    MSParser = new MicrosoftScholarParser();
                resultsGroupBox.Enabled = false;
                progressPanel.Visible = true;
                progressBar.Style = ProgressBarStyle.Marquee;
                progressBar.MarqueeAnimationSpeed = 25;

                backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_citationSearchWork);
                backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);

                backgroundWorker.RunWorkerAsync();

                while (backgroundWorker.IsBusy)
                {
                    Application.DoEvents();
                    // disable those options which will trigger another thread 
                }

                resultsGroupBox.Enabled = true;
                progressPanel.Visible = false;
                populateCitations(MainPapers[citationIndex], Citations, type);
            }
        }

        private void viewUrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage bpage = new TabPage("Browser");
            Browser browser;
            if (authorResultsListView.Visible == true)
                browser = new Browser(MainPapers[authorResultsListView.FocusedItem.Index].TitleURL);
            else
                browser = new Browser(MainPapers[journalsResultsListView.FocusedItem.Index].TitleURL);
            bpage.Controls.Add(browser);
            bpage.ImageIndex = 1;
            Form1.dub_tab.TabPages.Insert(Form1.dub_tab.TabPages.Count - 1, bpage);
            Form1.dub_tab.SelectedTab = bpage;
        }

        private void authorResultsListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {


            if (e.Column == 0)
            {
               
                if (prevSortedColum[0] == false)
                {
                    sortPapersByTitle(true);
                    prevSortedColum[0] = true;
                }
                else
                {
                    sortPapersByTitle(false);
                    prevSortedColum[0] = false;
                }
            }
            else if (e.Column == 1)
            {
                if (prevSortedColum[1] == false)
                {
                    sortPapersByAuthor(true);
                    prevSortedColum[1] = true;
                }
                else
                {
                    sortPapersByAuthor(false);
                    prevSortedColum[1] = false;

                }

            }
            else if (e.Column == 2)
            {
                if (prevSortedColum[2] == false)
                {
                    sortPapersByYear(true);
                    prevSortedColum[2] = true;
                }
                else
                {
                    sortPapersByYear(false);
                    prevSortedColum[2] = false;

                }
            }
            else if (e.Column == 3)
            {
                if (prevSortedColum[3] == false)
                {
                    sortPapersByCitations(true);
                    prevSortedColum[3] = true;
                }
                else
                {
                    sortPapersByCitations(false);
                    prevSortedColum[3] = false;
                }
            }
            RepopulateCitations( MainPapers);

            
        }


        public void sortPapersByAuthor(bool order) {
            if(order)
                 MainPapers.Sort((x, y) => x.Authors.CompareTo(y.Authors));
            else
                MainPapers.Sort((y,x) => x.Authors.CompareTo(y.Authors));

        
        }

        public void sortPapersByCitations(bool order)
        {
            
            if (order)
            {
                MainPapers.Sort((x, y) => x.NumberOfCitations.CompareTo(y.NumberOfCitations));
                
            }
            else
            {
                MainPapers.Sort((y, x) => x.NumberOfCitations.CompareTo(y.NumberOfCitations));
            }
        }
        public void sortPapersByYear(bool order)
        {
            if (order)
            {
                MainPapers.Sort((x, y) => x.Year.CompareTo(y.Year));
            }
            else
            {
                MainPapers.Sort((y, x) => x.Year.CompareTo(y.Year));
            }
        }
        public void sortPapersByGSRank(bool order)
        {
            if (order)
            {
                MainPapers.Sort((x, y) => x.GSRank.CompareTo(y.GSRank));
            }
            else
            {
                MainPapers.Sort((y, x) => x.GSRank.CompareTo(x.GSRank));
            }
        }
        public void sortPapersByTitle(bool order)
        {
            if (order)
            {
                
                MainPapers.Sort((x, y) => x.Title.CompareTo(y.Title));
                
                
            }
            else
            {
                MainPapers.Sort((y, x) => x.Title.CompareTo(x.Title));
            }
        }
        public void sortPapersByPublication(bool order)
        {
            if (order)
            {
                MainPapers.Sort((x, y) => x.Publication.CompareTo(y.Publication));
            }
            else
            {
                MainPapers.Sort((y, x) => x.Publication.CompareTo(x.Publication));
            }
        }
        public void sortPapersByPublisher(bool order)
        {
            if (order)
            {
                MainPapers.Sort((x, y) => x.Publisher.CompareTo(y.Publisher));
            }
            else
            {
                MainPapers.Sort((y, x) => x.Publisher.CompareTo(x.Publisher));
            }
        }
        
    }
}
