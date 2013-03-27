using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using SG;

namespace PubCite
{
    public partial class CitationsTab : UserControl
    {
        ListViewItem item;
        List<Paper> MainPapers;
        List<Paper> Papers;

        GSScraper GSScraper;
        CSXParser CSParser;
        MicrosoftScholarParser MSParser;

        Boolean[] prevSortedColum = { false, false, false, false };

        int type;
        int citationIndex;
        string gs_url;
        int lastCount;
        bool? nextData;
        bool STOP;

        Paper paper; 

        public CitationsTab(Paper paper, int type)
        {
            InitializeComponent();
            authorResultsListView.ColumnClick += new ColumnClickEventHandler(authorResultsListView_ColumnClick);
            authorResultsListView.FullRowSelect = true;
            authorResultsListView.MouseClick += new MouseEventHandler(authorResultsListView_MouseClick);
            authorResultsListView.MouseDoubleClick += new MouseEventHandler(authorResultsListView_MouseDoubleClick);
            authorResultsListView.DrawItem += ListView_DrawItem;
            authorResultsListView.DrawColumnHeader += ListView_DrawColumnHeader;
            abstractBox.GotFocus += abstractBox_GotFocus;

            CSParser = new CSXParser();
            GSScraper = new GSScraper();
            MSParser = new MicrosoftScholarParser();

            this.paper = paper;
            this.type = type;
            lastCount = 0;
            STOP = false;

            showStatistics();

            getCitations();
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

        private void getCitations()
        {
            lastCount = 0;
            resultsGroupBox.Enabled = false;
            progressPanel.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 25;

            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_citationSearchWork);
            //backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);

            backgroundWorker.RunWorkerAsync();

            while (backgroundWorker.IsBusy)
            {
                Application.DoEvents();
                // disable those options which will trigger another thread 
            }

            resultsGroupBox.Enabled = true;
            Papers = MainPapers;
            showCitations();
            progressPanel.Visible = false;
            progressBar.MarqueeAnimationSpeed = 0;
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Value = progressBar.Minimum;
        }

        public void showStatistics()
        {

            publicationsDetailsGroupBox.Text = paper.Title;
            authorsName.Text = paper.Authors;
            yearLabel.Text = paper.Year.ToString();
            venue.Text = paper.Publication;
            numCitations.Text = paper.NumberOfCitations.ToString();
            publisher.Text = paper.Publisher;
            abstractBox.Text = paper.Summary;
            
        }
        public void showCitations()
        {
            if (MainPapers != null && MainPapers.Count > 0)
            {
                if (lastCount == 0)
                    authorResultsListView.Items.Clear();

                citationsShown.Text = Papers.Count.ToString();
                for (int i = lastCount; i < Papers.Count; i++)
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
            else
            {
                MessageBox.Show("Sorry. No citations data available!");
            }
        }

        private void viewAll_Click(object sender, EventArgs e)
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                MessageBox.Show("Warning: Please check your Internet connection!");
            else
            {
                if (MainPapers != null)
                {
                    stop.Visible = true;

                    progressPanel.Visible = true;
                    progressBar.Style = ProgressBarStyle.Marquee;
                    progressBar.MarqueeAnimationSpeed = 25;
                    nextData = true;
                    while (nextData == true && !STOP)
                    {
                        lastCount = MainPapers.Count;
                        Console.WriteLine("Paper Next");
                        BackgroundWorker backgroundWorker1 = new BackgroundWorker();
                        backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker_citationNextDataWork);
                        backgroundWorker1.RunWorkerAsync();
                        while (backgroundWorker1.IsBusy)
                        {
                            Application.DoEvents();
                            // disable those options which will trigger another thread 
                        }
                        Papers = MainPapers;
                        showCitations();
                    }
                    lastCount = 0;
                    STOP = false;
                    stop.Visible = false;
                    progressPanel.Visible = false;
                    progressBar.MarqueeAnimationSpeed = 0;
                    progressBar.Style = ProgressBarStyle.Blocks;
                    progressBar.Value = progressBar.Minimum;
                }
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            STOP = true;
            stop.Visible = false;
            progressPanel.Visible = false;
            progressBar.MarqueeAnimationSpeed = 0;
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Value = progressBar.Minimum;
        }

        private void authorResultsListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (authorResultsListView.FocusedItem.Bounds.Contains(e.Location) == true)
                    optionMenuStrip.Show(Cursor.Position);

            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.MarqueeAnimationSpeed = 0;
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Value = progressBar.Minimum;
        }

        private void backgroundWorker_citationNextDataWork(object sender, DoWorkEventArgs e)
        {
            if (type == 0)
                nextData = CSParser.getCitationsNext(paper.CitedByURL, ref MainPapers);
            else if (type == 1)
                nextData = GSScraper.getCitationsNextPage(gs_url, ref gs_url, ref MainPapers);
            else if (type == 2)
                nextData = MSParser.getCitationsNext(paper.CitedByURL, ref MainPapers);
        }

        private void backgroundWorker_citationSearchWork(object sender, DoWorkEventArgs e)
        {
            if (type == 0)
                MainPapers = CSParser.getCitations(paper.CitedByURL);
            else if (type == 1)
            {
                MainPapers = GSScraper.getCitations(paper.CitedByURL, ref gs_url);
                if (MainPapers == null)
                    MessageBox.Show("Oops! You have reached administrative limit for Google Scholar." +
                        "\nIf you are behind a proxy server, please try changing your settings.");
            }
            else if (type == 2)
                MainPapers = MSParser.getCitations(paper.CitedByURL);
        }

        private void authorResultsListView_MouseDoubleClick(object sender, EventArgs e)
        {
            viewCitationsToolStripMenuItem_Click(sender, e);
        }

        private void viewCitationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                MessageBox.Show("Warning: Please check your Internet connection!");
            else
            {
                for (int i = 0; i < 4; i++) prevSortedColum[i] = false;
                citationIndex = authorResultsListView.FocusedItem.Index;

                if (Papers[citationIndex].NumberOfCitations != 0)
                {
                    paper = Papers[citationIndex];

                    showStatistics();

                    getCitations();
                }
            }
        }

        private void viewUrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                MessageBox.Show("Warning: Please check your Internet connection!");
            else
            {
                string url;
                if (authorResultsListView.Visible == true)
                    url = Papers[authorResultsListView.FocusedItem.Index].TitleURL;
                else
                    url = Papers[journalsResultsListView.FocusedItem.Index].TitleURL;

                if (url != null && !(url.ToLower().Equals("not found")) && url.Length > 0)
                {
                    TabPage bpage = new TabPage("Browser");
                    Browser browser;
                    browser = new Browser(url);
                    bpage.Controls.Add(browser);
                    bpage.ImageIndex = 1;
                    Form1.dub_tab.TabPages.Insert(Form1.dub_tab.TabPages.Count - 1, bpage);
                    Form1.dub_tab.SelectedTab = bpage;
                }
                else
                {
                    MessageBox.Show("Sorry!Url unavailable");
                }
            }
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
            showCitations();
        }


        public void sortPapersByAuthor(bool order)
        {
            if (order)
                MainPapers.Sort((x, y) => x.Authors.CompareTo(y.Authors));
            else
                MainPapers.Sort((y, x) => x.Authors.CompareTo(y.Authors));
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

        public List<Paper> getPaperByKeywords(List<Paper> papers, string keywords)
        {
            if (keywords.Length == 0)
                return papers;
            char[] delims = { ' ', ',', ':', ';', '\"' };
            string[] keywordsList = keywords.Split(delims);

            List<Paper> newList = new List<Paper>();
            foreach (Paper p in papers)
            {
                bool add = true;
                string content = (p.Title + p.Publication + p.Summary + p.Authors).ToLower();
                for (int i = 0; i < keywordsList.Length; i++)
                {
                    if (keywordsList[i].Length > 0 && !content.Contains(keywordsList[i].ToLower()))
                    {
                        add = false;
                        break;
                    }
                }
                if (add == true)
                    newList.Add(p);
            }
            return newList;
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            Papers = getPaperByKeywords(MainPapers, filterTextBox.Text);
            showCitations();
        }
    }
}
