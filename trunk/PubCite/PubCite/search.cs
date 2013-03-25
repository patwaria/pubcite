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
        
        
        int prevSelectedIndex;
        int suggestedIndex;
        int citationIndex;
        int citationType;
        Boolean[] prevSortedColum = { false, false, false, false };
        Boolean[] a = { false, false, false };
        Boolean suggestions;
        Boolean nextData;
        Boolean STOP;


        public search()
        {
            InitializeComponent();
            CSParser = new CSXParser();
            GSScraper = new GSScraper();
            MSParser = new MicrosoftScholarParser();
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

            showSearch();
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
            {
                authStats = (SG.Author)cacheObject.Get(searchField.Text, authorCheckBox.Checked);
                populateAuthor();
            }
            else {
                journalStats = (SG.Journal)cacheObject.Get(searchField.Text, authorCheckBox.Checked);
                populateJournal();
            }
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
            
            Suggestions.Visible = true;
            for (int i = 0; i < authors.Count; i++)
            {

                item = new ListViewItem(authors[i]);
                authorsSuggestions.Items.Add(item);
            }
        }
        private void populateJournal()
        {

            if (journalStats != null && journalStats.getNumberOfPapers() != 0)
            {
                journalResultsListView.Items.Clear();
                authorResultsListView.Visible = false;
                journalResultsListView.Visible = true;
                if (StartYear.getintval() == 0 && EndYear.getintval() == 0)
                    Papers = journalStats.getPapers();
                else if (StartYear.getintval() != 0 && EndYear.getintval() == 0)
                    Papers = journalStats.getPaperByYearRange(StartYear.getintval());
                else if (StartYear.getintval() == 0 && EndYear.getintval() != 0)
                    Papers = journalStats.getPaperUptoYear(EndYear.getintval());
                else if (StartYear.getintval() != 0 && EndYear.getintval() != 0)
                    Papers = journalStats.getPaperByYearRange(StartYear.getintval(), EndYear.getintval());


                authorNameLabel.Text = journalStats.Name;
                citesperPaper.Text = journalStats.getCitesPerPaper().ToString();
                citesperYear.Text = journalStats.getCitesPerYear().ToString();
                hindex.Text = journalStats.getHIndex().ToString();
                i10index.Text = journalStats.getI10Index().ToString();
                citationsNumberLabel.Text = journalStats.getTotalNumberofCitations().ToString();
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
            }
            else
            {
                MessageBox.Show("Journal results not found!");
            }
        }

        private void populateAuthor()
        {

            if (authStats != null && authStats.getNumberOfPapers() != 0)
            {

                authorResultsListView.Items.Clear();
                authorResultsListView.Visible = true;
                journalResultsListView.Visible = false;

                if (StartYear.getintval() == 0 && EndYear.getintval() == 0)
                    Papers = authStats.getPapers();
                else if (StartYear.getintval() != 0 && EndYear.getintval() == 0)
                    Papers = authStats.getPaperByYearRange(StartYear.getintval());
                else if (StartYear.getintval() == 0 && EndYear.getintval() != 0)
                    Papers = authStats.getPaperUptoYear(EndYear.getintval());
                else if (StartYear.getintval() != 0 && EndYear.getintval() != 0)
                    Papers = authStats.getPaperByYearRange(StartYear.getintval(), EndYear.getintval());
                Console.WriteLine(Papers.Count);

                /* Statistics */
                authorNameLabel.Text = authStats.Name;
                citesperPaper.Text = authStats.getCitesPerPaper().ToString();
                citesperYear.Text = authStats.getCitesPerYear().ToString();
                hindex.Text = authStats.getHIndex().ToString();
                i10index.Text = authStats.getI10Index().ToString();
                citationsNumberLabel.Text = authStats.getTotalNumberofCitations().ToString();

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
            }
            else
            {
                MessageBox.Show("Author results not found!");
            }
        }

        private void updateHistory(string name)
        {
            item = new ListViewItem(name);
            recentListView.Items.Add(item);
        }

        public void ArrangeTree()
        {

            FavAuthorList = Form1.favorites.AuthorList;
            FavJournalList = Form1.favorites.JournalList;

            for (int i = 0; i < FavAuthorList.Count; i++)
            {
                
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
                populateJournal();
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
                populateAuthor();
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

        private void startProgressUI()
        {
            showStop();
            disablePanels();
            progressPanel.Visible = true;
            progressBar.BringToFront();
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 15;
        }

        private void endProgressUI() {

            showSearch();
            /* Stop the progress bar */
            progressBar.MarqueeAnimationSpeed = 0;
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Value = progressBar.Minimum;

            /* enable panels */
            enablePanels();
            progressPanel.Visible = false;
            progressBar.SendToBack();
            progressBar.Visible = false;
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
                    if (a[0] == true)
                    {
                        authStats = CSParser.getAuthors(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text);
                        authStats.Type = 0;
                    }
                    else if (a[1] == true)
                    {
                        authStats = GSScraper.getAuthors(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text);
                        authStats.Type = 0;
                    }
                    else
                    {
                        authStats = MSParser.getAuthors(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text);
                        authStats.Type = 0;
                    }
                    suggestions = false;
                }
                else
                {
                    authors = authSug.getSuggestions();
                    auth_url = authSug.getSuggestionsURL();

                    if (authors.Count == 1)
                    {
                        suggestedIndex = 0;
                        if (prevSelectedIndex != suggestedIndex)
                        {
                            if (a[0] == true)
                            {
                                authStats = CSParser.getAuthStatistics(auth_url[suggestedIndex]);
                                authStats.Type = 0;
                            }
                            else if (a[1] == true)
                            {
                                authStats = GSScraper.getAuthStatistics(auth_url[suggestedIndex]);
                                authStats.Type = 1;
                            }
                            else if (a[2] == true)
                            {
                                authStats = MSParser.getAuthStatistics(auth_url[suggestedIndex]);
                                authStats.Type = 2;
                            }
                            prevSelectedIndex = suggestedIndex;
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
                {
                    journalStats = CSParser.getJournals(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text);
                    journalStats.Type = 0;
                }
                else if (a[1])
                {
                    journalStats = GSScraper.getJournals(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text);
                    journalStats.Type = 1;
                }
                else
                {
                    journalStats = MSParser.getJournals(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text);
                    journalStats.Type = 2;
                }
            }
        }

        private void backgroundWorker_authSearchWork(object sender, DoWorkEventArgs e)
        {

            if (prevSelectedIndex != suggestedIndex)
            {
                if (a[0] == true)
                {
                    authStats = CSParser.getAuthStatistics(auth_url[suggestedIndex]);
                    authStats.Type = 0;
                }
                else if (a[1] == true)
                {
                    authStats = GSScraper.getAuthStatistics(auth_url[suggestedIndex]);
                    authStats.Type = 1;
                }
                else if (a[2] == true)
                {
                    authStats = MSParser.getAuthStatistics(auth_url[suggestedIndex]);
                    authStats.Type = 2;
                } 
                prevSelectedIndex = suggestedIndex;
            }
        }

        private void backgroundWorker_citationSearchWork(object sender, DoWorkEventArgs e)
        {
            if (citationType == 0)
            {
                Console.WriteLine("url:" + Papers[citationIndex].CitedByURL);
                Citations = CSParser.getCitations(Papers[citationIndex].CitedByURL);
                
            }
            else if (citationType == 1)
            {
                Console.WriteLine("url:" + Papers[citationIndex].CitedByURL);
                Citations = GSScraper.getCitations(Papers[citationIndex].CitedByURL);
              
            }
            else if (citationType == 2)
            {
                Console.WriteLine("url:" + Papers[citationIndex].CitedByURL);
                Citations = MSParser.getCitations(Papers[citationIndex].CitedByURL);
               
            }
        }

        private void backgroundWorker_authstatsNextDataWork(object sender, DoWorkEventArgs e)
        {
            nextData = MSParser.getAuthStatisticsNext(auth_url[suggestedIndex], ref authStats);

        }

        private void backgroundWorker_authorsNextDataWork(object sender, DoWorkEventArgs e)
        {
            nextData = MSParser.getAuthorsNext(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text, ref authStats);

        }

        private void backgroundWorker_journalsNextDataWork(object sender, DoWorkEventArgs e)
        {
            nextData = MSParser.getJournalsNext(searchField.Text, affilationTextBox.Text, KeywordsTextBox.Text, ref journalStats);

        }

        private void getNextAuthStats(bool hasProfile)
        {
            /* Get author data in the background 
             * Note : only for MSParser now
             * 
             */
            if (authStats.getNumberOfPapers() >= 20 && authStats.Type == 2)
            {
                nextData = true;
                while (nextData == true)
                {
                    BackgroundWorker backgroundWorker1 = new BackgroundWorker();
                    if(hasProfile)
                        backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker_authstatsNextDataWork);
                    else
                        backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker_authorsNextDataWork);
                    backgroundWorker1.RunWorkerAsync();
                    while (backgroundWorker1.IsBusy)
                    {
                        Application.DoEvents();
                        // disable those options which will trigger another thread 
                    }

                    populateAuthor();
                }
            }
        }

        private void getNextJournal()
        {
            /* Get next journal data in the background 
             * Note : only for MSParser now
             * 
             */
            if (journalStats.getNumberOfPapers() >= 20 && journalStats.Type == 2)
            {
                nextData = true;
                while (nextData == true)
                {
                    Console.WriteLine("Journal");
                    BackgroundWorker backgroundWorker1 = new BackgroundWorker();
                    backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker_journalsNextDataWork);
                    backgroundWorker1.RunWorkerAsync();
                    while (backgroundWorker1.IsBusy)
                    {
                        Application.DoEvents();
                        // disable those options which will trigger another thread 
                    }

                    populateJournal();
                }
            }
        }

        private void authorsSuggestions_MouseClick(object sender, EventArgs e)
        {
            suggestedIndex = authorsSuggestions.FocusedItem.Index;
            startProgressUI();
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_authSearchWork);
            //backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
            
            backgroundWorker.RunWorkerAsync();
            while (backgroundWorker.IsBusy)
            {
                Application.DoEvents();
                // disable those options which will trigger another thread 
            }

            /* Add to cache */
            cacheObject.Add(authStats.Name, authStats, true);
            /* Add to recent History */
            RecentSearchKeys.Add(authStats.Name);
            updateHistory(authStats.Name);
            populateAuthor();
            endProgressUI();

            getNextAuthStats(true);

        }

        private void searchIcon_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 4; i++) prevSortedColum[i] = false;
            
            authorsSuggestions.Items.Clear();
            authorResultsListView.Items.Clear();
            journalResultsListView.Items.Clear();

            cachedListView.Visible = false;
            cachedListView.SendToBack();

            startProgressUI();

            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_genSearchWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);

            if (siteComboBox.SelectedItem.ToString().Equals("Citeseer"))
            {
                a[0] = true;
                a[1] = false;
                a[2] = false;
                
            }
            else if (siteComboBox.SelectedItem.ToString().Equals("Google Scholar"))
            {
                a[0] = false;
                a[1] = true;
                a[2] = false;

            }
            else if (siteComboBox.SelectedItem.ToString().Equals("Microsoft Academic Search"))
            {
                a[0] = false;
                a[1] = false;
                a[2] = true;
            }

            backgroundWorker.RunWorkerAsync();

            while (backgroundWorker.IsBusy)
            {
                Application.DoEvents();
                // disable those options which will trigger another thread 
            }

            endProgressUI();
            if (authorCheckBox.Checked == true)
            {
                Console.WriteLine("Done" + suggestions);
                if (suggestions)
                    populateSuggestions();
                else
                {
                    /* Add to cache */
                    cacheObject.Add(authStats.Name, authStats, true);
                    /* Add to recent History */
                    RecentSearchKeys.Add(authStats.Name);
                    updateHistory(authStats.Name);
                    populateAuthor();

                    /* Add threading */
                    /* Only for MSParser now */

                    getNextAuthStats(false);
                }
            }
            else
            {
                /* add journal to cache */
                cacheObject.Add(journalStats.Name, journalStats, false);

                /* add journal to recent */
                RecentSearchKeys.Add(journalStats.Name);
                updateHistory(journalStats.Name);
                populateJournal();

                getNextJournal();
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
            if (authorResultsListView.Visible == true) {
                citationIndex = authorResultsListView.FocusedItem.Index;
                citationType = authStats.Type;
                Papers = authStats.getPapers();
                
            }
            else {
                citationIndex = journalResultsListView.FocusedItem.Index;
                citationType = journalStats.Type;
                Papers = journalStats.getPapers();
            }

            if (Papers[citationIndex].NumberOfCitations != 0)
            {
                disablePanels();
                progressPanel.Visible = true;
                progressBar.Style = ProgressBarStyle.Marquee;
                progressBar.MarqueeAnimationSpeed = 15;
                progressBar.BringToFront();
                progressBar.Visible = true;

                BackgroundWorker backgroundWorker = new BackgroundWorker();
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

               
                NcitTab.populateCitations(Papers[citationIndex], Citations, citationType);
                
                Form1.dub_tab.SelectedTab = citationsPage;
            }
        }

        private void addToFavourite_Click(object sender, EventArgs e)
        {
            if (authorCheckBox.Checked == true && authStats != null)
            {
                
                Form1.favorites.AddAuthor(authStats);

            }
            else if (journalCheckBox.Checked == true && journalStats != null) {
                
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
                    populateAuthor();
                }
                else if (favouritesTreeView.SelectedNode.Parent.Index == 1)
                {// Journal selected
                    journalStats = FavJournalList[favouritesTreeView.SelectedNode.Index];
                    populateJournal();
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
                    populateAuthor();
                else if (journalStats != null)
                    populateJournal();
            }
        }

        private void EndYear_TextChanged(object sender, EventArgs e)
        {

            if (EndYear.Text.Length == 4 || EndYear.getintval() == 0)
            {
                if (authorCheckBox.Checked == true && authStats != null)
                    populateAuthor();
                else if (journalStats != null)
                    populateJournal();
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
            t.add(favouritesTreeView, "Left", 7);
            t.add(recentSearchPanel, "Left", -250);
            t.run();
        }

        private void recentButton_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(favouritesTreeView, "Left", -250);
            t.add(recentSearchPanel, "Left", 7);
            t.run();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("say cheese");
            
            
        }

        private void showSearch()
        {
            stopButton.Visible = false;
            stopButton.SendToBack();
            searchIcon.BringToFront();
            searchIcon.Visible = true;
        }

        private void showStop()
        {
            stopButton.BringToFront();
            stopButton.Visible = true;
            searchIcon.SendToBack();
            searchIcon.Visible = false;
        }
    }
}



