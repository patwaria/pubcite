using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using Transitions;
namespace PubCite
{
    public partial class search : UserControl
    {
        List<SG.Author> FavAuthorList;
        List<SG.Journal> FavJournalList;
        List<SG.Paper> Papers;
        List<SG.Paper> Citations;
        List<String> RecentSearchKeys = new List<string>();

        List<string> auth_url;
        List<string> authors;
        CSXParser CSParser;
        GSScraper GSScraper;
        MicrosoftScholarParser MSParser;
        ListViewItem item;
        SG.AuthSuggestion authSug = null;
        SG.Author authStats = null;
        SG.Journal journalStats;
        
        Boolean[] a = { false, false, false };
        int prevSelectedIndex;
        int suggestedIndex;
        int citationIndex;
        Boolean[] prevSortedColum = { false, false, false, false };
        Boolean suggestions;
        BackgroundWorker backgroundWorker;


        public search()
        {
            InitializeComponent();

            ArrangeTree();

            authorResultsListView.FullRowSelect = true;
            authorResultsListView.MouseClick += new MouseEventHandler(authorResultsListView_MouseClick);
            authorResultsListView.ColumnClick += new ColumnClickEventHandler(authorResultsListView_ColumnClick);
            authorResultsListView.MouseDoubleClick += new MouseEventHandler(authorResultsListView_MouseDoubleClick);

            journalResultsListView.FullRowSelect = true;
            journalResultsListView.MouseClick += new MouseEventHandler(journalResultsListView_MouseClick);
            journalResultsListView.ColumnClick += new ColumnClickEventHandler(journalResultsListView_ColumnClick);
            journalResultsListView.MouseDoubleClick += new MouseEventHandler(journalResultsListView_MouseDoubleClick);

            authorsSuggestions.MouseDoubleClick += new MouseEventHandler(authorsSuggestions_MouseClick);
            authorsSuggestions.FullRowSelect = true;

            favouritesTreeView.MouseDoubleClick += new MouseEventHandler(favouritesTreeView_MouseDoubleClick);
            searchField.GotFocus += new EventHandler(searchField_GotFocus);
            searchField.LostFocus += new EventHandler(searchField_LostFocus);
            searchField.KeyUp+=new KeyEventHandler(searchField_KeyUp);
            progressBar.SendToBack();
            progressBar.Visible = false;

            authorCheckBox.Click += new EventHandler(authorCheckBox_Click);
            journalCheckBox.Click += new EventHandler(journalCheckBox_Click);

            cachedListView.FullRowSelect = true;
            cachedListView.Click +=new EventHandler(cachedListView_Click);
            cachedListView.HeaderStyle = ColumnHeaderStyle.None;
            cachedListView.SendToBack();

        }
        private void searchField_GotFocus(object sender, EventArgs e)
        {
            if (searchField.Text.Length > 0)
            {
                cachedListView.BringToFront();
                cachedListView.Visible = true;
            }
        }
        private void searchField_LostFocus(object sender, EventArgs e)
        {
            cachedListView.Visible = false;
            cachedListView.SendToBack();
        }
        

        public void cachedListView_Click(object sender, EventArgs e) {

            
            Console.WriteLine(cachedListView.FocusedItem.Text);
            searchField.Text = cachedListView.FocusedItem.Text;
            cachedListView.Visible = false;
            /* Display cached object */
            if (authorCheckBox.Checked)
                populateAuthor((SG.Author)cacheObject.Get(searchField.Text, authorCheckBox.Checked));
            else
                populateJournal((SG.Journal)cacheObject.Get(searchField.Text, authorCheckBox.Checked));
        
        }

        private void authorCheckBox_Click(object sender, EventArgs e)
        {
            journalCheckBox.Checked = !(journalCheckBox.Checked);
            updateCacheSuggestions();
            
        }

        private void journalCheckBox_Click(object sender, EventArgs e)
        {
            authorCheckBox.Checked = !(authorCheckBox.Checked);
            updateCacheSuggestions();
        }

        public void searchField_KeyUp(object sender,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchIcon_Click(sender, e);
            }

            updateCacheSuggestions();
        }

        public GroupBox get_sugg()
        {

            return Suggestions;

        }

        public void updateCacheSuggestions()
        {
            cachedListView.Items.Clear();
            if (searchField.Text.Length > 0)
            {
                List<String> cachedList = cacheObject.GetMatchingkeys(searchField.Text, authorCheckBox.Checked);
                if (cachedList.Count > 0)
                {
                    cachedListView.Visible = true;
                    cachedListView.BringToFront();
                    //Console.WriteLine(suggestions.Count);
                    for (int i = 0; i < cachedList.Count; i++)
                    {
                        item = new ListViewItem(cachedList[i]);
                        cachedListView.Items.Add(item);
                    }
                }
                else
                {
                    cachedListView.Visible = false;
                    cachedListView.SendToBack();
                }
            }
            else
            {
                cachedListView.Visible = false;
                cachedListView.SendToBack();
            }
            
        }

        public void populateSuggestions()
        {
            Console.WriteLine("Here");
            Suggestions.Visible = true;
            for (int i = 0; i < authors.Count; i++)
            {

                item = new ListViewItem(authors[i]);
                authorsSuggestions.Items.Add(item);
            }
        }
        private void populateJournal(SG.Journal journal)
        {

            journalResultsListView.Items.Clear();
            authorResultsListView.Visible = false;
            journalResultsListView.Visible = true;

            if (journal != null)
            {
                if (StartYear.getintval() == 0 && EndYear.getintval() == 0)
                    Papers = journal.getPapers();
                else if (StartYear.getintval() != 0 && EndYear.getintval() == 0)
                    Papers = journal.getPaperByYearRange(StartYear.getintval());
                else if (StartYear.getintval() == 0 && EndYear.getintval() != 0)
                    Papers = journal.getPaperUptoYear(EndYear.getintval());
                else if (StartYear.getintval() != 0 && EndYear.getintval() != 0)
                    Papers = journal.getPaperByYearRange(StartYear.getintval(), EndYear.getintval());


                authorNameLabel.Text = journal.Name;
                citesperPaper.Text = journal.getCitesPerPaper().ToString();
                citesperYear.Text = journal.getCitesPerYear().ToString();
                hindex.Text = journal.getHIndex().ToString();
                i10index.Text = journal.getI10Index().ToString();
                citationsNumberLabel.Text = journal.getTotalNumberofCitations().ToString();
                for (int i = 0; i < Papers.Count; i++)
                {
                    item = new ListViewItem(Papers[i].Title);
                    item.SubItems.Add(Papers[i].Authors);
                    item.SubItems.Add(Papers[i].NumberOfCitations.ToString());
                    if (Papers[i].Year == -1 || Papers[i].Year == -1)
                        item.SubItems.Add("--");
                    else
                        item.SubItems.Add(Papers[i].Year.ToString());
                    journalResultsListView.Items.Add(item);

                }
                /* add journal to cache */
                cacheObject.Add(journal.Name, journal, false);
                
                /* add journal to recent */
                RecentSearchKeys.Add(journal.Name);
                updateHistory();
            }
        }

        private void populateAuthor(SG.Author author)
        {

            authorResultsListView.Items.Clear();
            authorResultsListView.Visible = true;
            journalResultsListView.Visible = false;

            if (author != null)
            {
                if (StartYear.getintval() == 0 && EndYear.getintval() == 0)
                    Papers = author.getPapers();
                else if (StartYear.getintval() != 0 && EndYear.getintval() == 0)
                    Papers = author.getPaperByYearRange(StartYear.getintval());
                else if (StartYear.getintval() == 0 && EndYear.getintval() != 0)
                    Papers = author.getPaperUptoYear(EndYear.getintval());
                else if (StartYear.getintval() != 0 && EndYear.getintval() != 0)
                    Papers = author.getPaperByYearRange(StartYear.getintval(), EndYear.getintval());
                Console.WriteLine(Papers.Count);

                /* Statistics */
                authorNameLabel.Text = author.Name;
                citesperPaper.Text = author.getCitesPerPaper().ToString();
                citesperYear.Text = author.getCitesPerYear().ToString();
                hindex.Text = author.getHIndex().ToString();
                i10index.Text = author.getI10Index().ToString();
                citationsNumberLabel.Text = author.getTotalNumberofCitations().ToString();

                /* Papers */
                for (int i = 0; i < Papers.Count; i++)
                {
                    /*populating */
                    item = new ListViewItem(Papers[i].Title);
                    item.SubItems.Add(Papers[i].Publication);
                    if (Papers[i].Year == -1 || Papers[i].Year == -1)
                        item.SubItems.Add("--");
                    else
                        item.SubItems.Add(Papers[i].Year.ToString());
                    item.SubItems.Add(Papers[i].NumberOfCitations.ToString());
                    authorResultsListView.Items.Add(item);
                }

                /* Add to cache */
                cacheObject.Add(author.Name, author, true);
                /* Add to recent History */
                RecentSearchKeys.Add(author.Name);
                updateHistory();
            }
        }

        private void updateHistory()
        {
            for (int i = 0; i < RecentSearchKeys.Count; i++)
            {
                /*populating */
                item = new ListViewItem(RecentSearchKeys[i]);
                recentListView.Items.Add(item);
            }
        }

        public void ArrangeTree()
        {

            FavAuthorList = Form1.favorites.AuthorList;
            FavJournalList = Form1.favorites.JournalList;

            for (int i = 0; i < FavAuthorList.Count; i++)
            {
                Console.WriteLine("URL:" + FavAuthorList[i].HomePageURL);
                favouritesTreeView.Nodes[0].Nodes[0].Nodes.Add(new TreeNode(FavAuthorList[i].Name));
                favouritesTreeView.Nodes[0].Nodes[0].Nodes[i].ContextMenuStrip = favouriteMenuStrip;
            }
            for (int i = 0; i < Form1.favorites.JournalList.Count; i++)
            {
                favouritesTreeView.Nodes[0].Nodes[1].Nodes.Add(new TreeNode(FavJournalList[i].Name));
                favouritesTreeView.Nodes[0].Nodes[1].Nodes[i].ContextMenuStrip = favouriteMenuStrip;
            }
        }

        public void UpdateTree()
        {

            if (authorCheckBox.Checked == true)
            {
                favouritesTreeView.Nodes[0].Nodes[0].Nodes.Clear();
                for (int i = 0; i < FavAuthorList.Count; i++)
                {
                    Console.WriteLine(FavAuthorList[i].HomePageURL);
                    favouritesTreeView.Nodes[0].Nodes[0].Nodes.Add(new TreeNode(FavAuthorList[i].Name));
                    favouritesTreeView.Nodes[0].Nodes[0].Nodes[i].ContextMenuStrip = favouriteMenuStrip;
                }
            }
            else if (journalCheckBox.Checked == true)
            {
                favouritesTreeView.Nodes[0].Nodes[1].Nodes.Clear();
                for (int i = 0; i < Form1.favorites.JournalList.Count; i++)
                {
                    favouritesTreeView.Nodes[0].Nodes[1].Nodes.Add(new TreeNode(FavJournalList[i].Name));
                    favouritesTreeView.Nodes[0].Nodes[1].Nodes[i].ContextMenuStrip = favouriteMenuStrip;
                }
            }
        }

        private void journalResultsListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            if (journalStats != null)
            {
                if (e.Column == 0)
                {

                    if (prevSortedColum[0] == false)
                    {
                        journalStats.sortPapersByTitle(true);
                        prevSortedColum[0] = true;
                    }
                    else
                    {
                        journalStats.sortPapersByTitle(false);
                        prevSortedColum[0] = false;
                    }
                }

                else if (e.Column == 3)
                {
                    if (prevSortedColum[3] == false)
                    {
                        journalStats.sortPapersByYear(true);
                        prevSortedColum[3] = true;
                    }
                    else
                    {
                        journalStats.sortPapersByYear(false);
                        prevSortedColum[3] = false;

                    }
                }
                else if (e.Column == 2)
                {
                    if (prevSortedColum[2] == false)
                    {
                        journalStats.sortPapersByCitations(true);
                        prevSortedColum[2] = true;
                    }
                    else
                    {
                        journalStats.sortPapersByCitations(false);
                        prevSortedColum[2] = false;
                    }
                }
                populateJournal(journalStats);
            }



        }

        private void authorResultsListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (authStats != null)
            {
                if (e.Column == 0)
                {

                    if (prevSortedColum[0] == false)
                    {
                        authStats.sortPapersByTitle(true);
                        prevSortedColum[0] = true;
                    }
                    else
                    {
                        authStats.sortPapersByTitle(false);
                        prevSortedColum[0] = false;
                    }
                }
                else if (e.Column == 1)
                {
                    if (prevSortedColum[1] == false)
                    {
                        authStats.sortPapersByPublication(true);
                        prevSortedColum[1] = true;
                    }
                    else
                    {
                        authStats.sortPapersByPublication(false);
                        prevSortedColum[1] = false;

                    }

                }
                else if (e.Column == 2)
                {
                    if (prevSortedColum[2] == false)
                    {
                        authStats.sortPapersByYear(true);
                        prevSortedColum[2] = true;
                    }
                    else
                    {
                        authStats.sortPapersByYear(false);
                        prevSortedColum[2] = false;

                    }
                }
                else if (e.Column == 3)
                {
                    if (prevSortedColum[3] == false)
                    {
                        authStats.sortPapersByCitations(true);
                        prevSortedColum[3] = true;
                    }
                    else
                    {
                        authStats.sortPapersByCitations(false);
                        prevSortedColum[3] = false;
                    }
                }
                populateAuthor(authStats);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.GetContainerControl();
        }


       

        private void authorResultsListView_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                if (authorResultsListView.FocusedItem.Bounds.Contains(e.Location) == true)
                    optionsMenuStrip.Show(Cursor.Position);
            }
        }

        private void journalResultsListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (journalResultsListView.FocusedItem.Bounds.Contains(e.Location) == true)
                    optionsMenuStrip.Show(Cursor.Position);
            }
        }

        private void Favorites_Click_1(object sender, EventArgs e)
        {
            Form1.favorites.AddAuthor(authStats);
        }

        private void CloseButton_Click_2(object sender, EventArgs e)
        {
            Form1.dub_tab.TabPages.Remove(Form1.dub_tab.SelectedTab);
            Form1.dub_tab.SelectedIndex = Form1.dub_tab.TabCount - 2;
        }

        private void disablePanels()
        {
            
            resultsPanel.Enabled = false;
            favouritesPanel.Enabled = false;
        }

        private void enablePanels()
        {
            resultsPanel.Enabled = true;
            favouritesPanel.Enabled = true;
        }
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.MarqueeAnimationSpeed = 0;
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Value = progressBar.Minimum;
        }

        private void backgroundWorker_genSearchWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("Background worker...");
            if (authorCheckBox.Checked == true)
            {
                prevSelectedIndex = -1;
                // get suggestions
                if (a[0])
                    authSug = CSParser.getAuthSuggestions(searchField.Text);
                else if (a[1])
                    authSug = GSScraper.getAuthSuggestions(searchField.Text);
                else
                    authSug = MSParser.getAuthSuggestions(searchField.Text);

                if (authSug == null || !authSug.isSet())
                {
                    /* Case : No suggestions */
                    if (a[0] == true) authStats = CSParser.getAuthors(searchField.Text,affilationTextBox.Text,KeywordsTextBox.Text);
                    else if (a[1] == true) authStats = GSScraper.getAuthors(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text);
                    /*Add for MAS*/

                    suggestions = false;
                }
                else
                {
                    authors = authSug.getSuggestions();
                    auth_url = authSug.getSuggestionsURL();

                    if (authors.Count == 1)
                    {
                        int index = 0;
                        if (prevSelectedIndex != index)
                        {
                            if (a[0] == true)
                                authStats = CSParser.getAuthStatistics(auth_url[index]);
                            else if (a[1] == true)
                                authStats = GSScraper.getAuthStatistics(auth_url[index]);
                            else if (a[2] == true)
                                authStats = MSParser.getAuthStatistics(auth_url[index]);
                            prevSelectedIndex = index;
                        }
                        suggestions = false;
                    }
                    else
                    {
                        suggestions = true;
                    }
                }
            }
            else // journal
            {
                if (a[0])
                    journalStats = CSParser.getJournals(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text);
                else if (a[1])
                    journalStats = GSScraper.getJournals(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text);
                else
                    journalStats = MSParser.getJournals(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text);
            }
        }

        private void backgroundWorker_authSearchWork(object sender, DoWorkEventArgs e)
        {

            if (prevSelectedIndex != suggestedIndex)
            {
                if (a[0] == true)
                    authStats = CSParser.getAuthStatistics(auth_url[suggestedIndex]);
                else if (a[1] == true)
                    authStats = GSScraper.getAuthStatistics(auth_url[suggestedIndex]);
                else if (a[2] == true)
                    authStats = MSParser.getAuthStatistics(auth_url[suggestedIndex]);
                prevSelectedIndex = suggestedIndex;
            }
        }

        private void backgroundWorker_citationSearchWork(object sender, DoWorkEventArgs e)
        {
            if (a[0] == true)
                Citations = CSParser.getCitations(Papers[citationIndex].CitedByURL);
            else if (a[1] == true)
                Citations = GSScraper.getCitations(Papers[citationIndex].CitedByURL);
            else if (a[2] == true)
                Citations = MSParser.getCitations(Papers[citationIndex].CitedByURL);
        }

        private void authorsSuggestions_MouseClick(object sender, EventArgs e)
        {
            disablePanels();
            suggestedIndex = authorsSuggestions.FocusedItem.Index;
            progressPanel.Visible = true;
            progressBar.BringToFront();
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 15;

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_authSearchWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
            
            backgroundWorker.RunWorkerAsync();
            while (backgroundWorker.IsBusy)
            {
                Application.DoEvents();
                // disable those options which will trigger another thread 
            }
            enablePanels();
            progressPanel.Visible = false;
            progressBar.SendToBack();
            progressBar.Visible = false;
            populateAuthor(authStats);
        }



        private void searchIcon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++) prevSortedColum[i] = false;
            authorsSuggestions.Items.Clear();
            authorResultsListView.Items.Clear();
            journalResultsListView.Items.Clear();

            cachedListView.Visible = false;
            cachedListView.SendToBack();
            disablePanels();
            progressPanel.Visible = true;
            progressBar.BringToFront();
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 15;

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_genSearchWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);

            if (siteComboBox.SelectedItem.ToString().Equals("Citeseer"))
            {
                a[0] = true;
                a[1] = false;
                a[2] = false;
                CSParser = new CSXParser();
            }
            else if (siteComboBox.SelectedItem.ToString().Equals("Google Scholar"))
            {
                a[0] = false;
                a[1] = true;
                a[2] = false;
                GSScraper = new GSScraper();
            }
            else if (siteComboBox.SelectedItem.ToString().Equals("Microsoft Academic Search"))
            {
                a[0] = false;
                a[1] = false;
                a[2] = true;
                MSParser = new MicrosoftScholarParser();
            }

            backgroundWorker.RunWorkerAsync();

            while (backgroundWorker.IsBusy)
            {
                Application.DoEvents();
                // disable those options which will trigger another thread 
            }

            enablePanels();
            progressPanel.Visible = false;
            progressBar.SendToBack();
            progressBar.Visible = false;
            if (authorCheckBox.Checked == true)
            {
                Console.WriteLine("Done" + suggestions);
                if (suggestions)
                    populateSuggestions();
                else
                    populateAuthor(authStats);
            }
            else
            {
                populateJournal(journalStats);
            }
        }

        private void viewURLToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (authorResultsListView.Visible == true)
                openBrowserForUrl(Papers[authorResultsListView.FocusedItem.Index].TitleURL);
            else
                openBrowserForUrl(Papers[journalResultsListView.FocusedItem.Index].TitleURL);
        }

        private void authorResultsListView_MouseDoubleClick(object sender, EventArgs e)
        {
            viewCitationsToolStripMenuItem_Click(sender,e);
        }

        private void journalResultsListView_MouseDoubleClick(object sender, EventArgs e)
        {
            viewCitationsToolStripMenuItem_Click(sender, e);
        }

        private void viewCitationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int type;
            if (authorResultsListView.Visible == true) {
                citationIndex = authorResultsListView.FocusedItem.Index;
                type = authStats.Type;
            }
            else {
                citationIndex = journalResultsListView.FocusedItem.Index;
                type = journalStats.Type;
            }
            if (Papers[citationIndex].NumberOfCitations != 0)
            {
                disablePanels();
                progressPanel.Visible = true;
                progressBar.Style = ProgressBarStyle.Marquee;
                progressBar.MarqueeAnimationSpeed = 15;
                progressBar.BringToFront();
                progressBar.Visible = true;

                backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_citationSearchWork);
                backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);

                backgroundWorker.RunWorkerAsync();

                while (backgroundWorker.IsBusy)
                {
                    Application.DoEvents();
                    // disable those options which will trigger another thread 
                }

                enablePanels();
                progressPanel.Visible = false;
                progressBar.SendToBack();
                progressBar.Visible = false;

                TabPage citationsPage = new TabPage("Citations");
                citationsPage.ImageIndex = 1;
                Form1.dub_tab.TabPages.Insert(Form1.dub_tab.TabPages.Count - 1, citationsPage);
                CitationsTab NcitTab = new CitationsTab();
                citationsPage.Controls.Add(NcitTab);

                NcitTab.populateCitations(Papers[citationIndex], Citations, type);
                
                Form1.dub_tab.SelectedTab = citationsPage;
            }
        }

        private void addToFavourite_Click(object sender, EventArgs e)
        {
            if (authorCheckBox.Checked == true && authStats != null)
            {
                if (a[0]) authStats.Type = 0;
                else if(a[1]) authStats.Type = 1;
                else authStats.Type = 2;
                Form1.favorites.AddAuthor(authStats);

            }
            else if (journalCheckBox.Checked == true && journalStats != null) {
                if (a[0]) journalStats.Type = 0;
                else if(a[1]) journalStats.Type = 1;
                else journalStats.Type = 2;
                Form1.favorites.AddJournal(journalStats);
            }
            UpdateTree();
        }

        private void favouritesTreeView_MouseDoubleClick(object sender, EventArgs e) {

            viewStatisticsToolStripMenuItem_Click(sender, e);
        }

        private void viewStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (favouritesTreeView.SelectedNode.Level == 2)
            {
                if (favouritesTreeView.SelectedNode.Parent.Index == 0)
                {
                    authStats = FavAuthorList[favouritesTreeView.SelectedNode.Index];
                    populateAuthor(authStats);
                }
                else if (favouritesTreeView.SelectedNode.Parent.Index == 1)
                {// Journal selected
                    journalStats = FavJournalList[favouritesTreeView.SelectedNode.Index];
                    populateJournal(journalStats);
                }
            }
            Console.WriteLine(favouritesTreeView.SelectedNode.Level);
        }

        private void removeFromFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (favouritesTreeView.SelectedNode != null)
            {
                if (favouritesTreeView.SelectedNode.Parent.Index == 0)
                {
                    Form1.favorites.removeAuthor(favouritesTreeView.SelectedNode.Index);
                    favouritesTreeView.SelectedNode.Remove();
                }
                else if (favouritesTreeView.SelectedNode.Parent.Index == 1)
                {
                    Form1.favorites.removeJournal(favouritesTreeView.SelectedNode.Index);
                    favouritesTreeView.SelectedNode.Remove();
                }
            }
        }

        private void StartYear_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(StartYear.Text);
            if (StartYear.Text.Length == 4 || StartYear.getintval() == 0)
            {
                if (authorCheckBox.Checked == true && authStats != null)
                    populateAuthor(authStats);
                else if (journalStats != null)
                    populateJournal(journalStats);
            }
        }

        private void EndYear_TextChanged(object sender, EventArgs e)
        {

            if (EndYear.Text.Length == 4 || EndYear.getintval() == 0)
            {
                if (authorCheckBox.Checked == true && authStats != null)
                    populateAuthor(authStats);
                else if (journalStats != null)
                    populateJournal(journalStats);
            }
        }

        private void openBrowserForUrl(string url)
        {
            TabPage bpage = new TabPage("Browser");
            Browser browser;
            browser = new Browser(url);
            bpage.Controls.Add(browser);
            bpage.ImageIndex = 1;
            Form1.dub_tab.TabPages.Insert(Form1.dub_tab.TabPages.Count - 1, bpage);
            Form1.dub_tab.SelectedTab = bpage;
        }

        private void authorNameLabel_Click(object sender, EventArgs e)
        {
            if (authorResultsListView.Visible == true && authStats != null)
            {
                Console.WriteLine(authStats.HomePageURL);
                openBrowserForUrl(authStats.HomePageURL);
            }
        }


        /* not required */
        public void searchWorker()
        {
            for (int i = 0; i < 4; i++) prevSortedColum[i] = false;
            authorsSuggestions.Items.Clear();
            authorResultsListView.Items.Clear();
            journalResultsListView.Items.Clear();

            if (authorCheckBox.Checked == true)
            {

                prevSelectedIndex = -1;

                if (siteComboBox.SelectedItem.ToString().Equals("Citeseer"))
                {
                    a[0] = true;
                    a[1] = false;
                    a[2] = false;
                    Console.WriteLine("in CS: " + searchField.Text);
                    CSParser = new CSXParser();
                    authSug = CSParser.getAuthSuggestions(searchField.Text);

                }
                else if (siteComboBox.SelectedItem.ToString().Equals("Google Scholar"))
                {
                    a[0] = false;
                    a[1] = true;
                    a[2] = false;
                    GSScraper = new GSScraper();
                    Console.WriteLine("in gs" + searchField.Text);

                    authSug = GSScraper.getAuthSuggestions(searchField.Text);

                }
                else if (siteComboBox.SelectedItem.ToString().Equals("Microsoft Academic Search"))
                {
                    a[0] = false;
                    a[1] = false;
                    a[2] = true;
                    MSParser = new MicrosoftScholarParser();
                    Console.WriteLine("in MS : " + searchField.Text);

                    authSug = MSParser.getAuthSuggestions(searchField.Text);
                }


                Console.WriteLine(authSug.isSet());
                if (authSug == null || !authSug.isSet())
                {
                    /* Case : No suggestions */
                    if (a[0] == true) authStats = CSParser.getAuthors(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text);
                    else if (a[1] == true) authStats = GSScraper.getAuthors(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text);
                    /*Add for MAS*/
                    //ProgThread.Abort();
                    populateAuthor(authStats);

                }
                else
                {
                    //System.Console.WriteLine(authSug.isSet());
                    authors = authSug.getSuggestions();
                    auth_url = authSug.getSuggestionsURL();

                    // System.Console.WriteLine(authors[0]);
                    if (authors.Count == 1)
                    {
                        int index = 0;
                        if (prevSelectedIndex != index)
                        {
                            if (a[0] == true)
                                authStats = CSParser.getAuthStatistics(auth_url[index]);
                            else if (a[1] == true)
                                authStats = GSScraper.getAuthStatistics(auth_url[index]);
                            else if (a[2] == true)
                                authStats = MSParser.getAuthStatistics(auth_url[index]);
                            prevSelectedIndex = index;
                        }
                        // ProgThread.Abort();
                        populateAuthor(authStats);
                    }
                    else
                    {

                        Suggestions.Visible = true;
                        for (int i = 0; i < authors.Count; i++)
                        {

                            item = new ListViewItem(authors[i]);
                            authorsSuggestions.Items.Add(item);
                        }
                    }
                }

            }
            if (journalCheckBox.Checked == true)
            {

                if (siteComboBox.SelectedItem.ToString().Equals("Citeseer"))
                {
                    a[0] = true;
                    a[1] = false;
                    a[2] = false;
                    CSParser = new CSXParser();
                    journalStats = CSParser.getJournals(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text);

                }
                else if (siteComboBox.SelectedItem.ToString().Equals("Google Scholar"))
                {
                    a[0] = false;
                    a[1] = true;
                    a[2] = false;
                    GSScraper = new GSScraper();
                    journalStats = GSScraper.getJournals(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text);

                }
                else if (siteComboBox.SelectedItem.ToString().Equals("Microsoft Academic Search"))
                {
                    a[0] = false;
                    a[1] = false;
                    a[2] = true;
                    MSParser = new MicrosoftScholarParser();
                    journalStats = MSParser.getJournals(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text);
                }
                populateJournal(journalStats);
            }
        }

        private void settingsIcon_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(recentSearchPanel, "Left", -300);
            t.run();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(recentSearchPanel, "Left", 0);
            t.run();
        }

        private void favouriteButton_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(favouritesTreeView, "Left", 29);
            t.add(recentSearchPanel, "Left", -200);
            t.run();
        }

        private void recentButton_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(favouritesTreeView, "Left", -200);
            t.add(recentSearchPanel, "Left", 29);
            t.run();
        }
    }
}



