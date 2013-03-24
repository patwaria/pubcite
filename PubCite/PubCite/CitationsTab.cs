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

        public CitationsTab()
        {
            InitializeComponent();
            authorResultsListView.ColumnClick += new ColumnClickEventHandler(authorResultsListView_ColumnClick);
            authorResultsListView.FullRowSelect = true;
            authorResultsListView.MouseClick += new MouseEventHandler(authorResultsListView_MouseClick);
            authorResultsListView.MouseDoubleClick += new MouseEventHandler(authorResultsListView_MouseDoubleClick);
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
                Citations = GSScraper.getCitations(MainPapers[citationIndex].CitedByURL);
            else if (type == 2)
                Citations = MSParser.getCitations(MainPapers[citationIndex].CitedByURL);
        }

        private void authorResultsListView_MouseDoubleClick(object sender, EventArgs e)
        {
            viewCitationsToolStripMenuItem_Click(sender, e);
        }

        private void viewCitationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

            Console.WriteLine("Hi");
        }
        
    }
}
