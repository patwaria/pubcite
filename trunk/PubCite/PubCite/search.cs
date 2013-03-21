using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace PubCite
{
    public partial class search : UserControl
    {
        List<SG.Author> FavAuthorList;
        List<SG.Journal> FavJournalList;

        List<string> auth_url;
        List<string> authors;
        CSXParser CSParser;
        GSScraper GSScraper;
        MicrosoftScholarParser MSParser;
        ListViewItem item;
        SG.AuthSuggestion authSug;
        SG.Author authStats;
        SG.Journal journalStats;
        List<SG.Paper> Papers;
        Boolean[] a = { false, false, false };
        int prevSelectedIndex;

        public search()
        {
            InitializeComponent();
            
            ArrangeTree();
            
            authorResultsListView.FullRowSelect = true;
            authorResultsListView.MouseClick += new MouseEventHandler(authorResultsListView_MouseClick);
            journalResultsListView.FullRowSelect = true;
            journalResultsListView.MouseClick += new MouseEventHandler(journalResultsListView_MouseClick);

            authorsSuggestions.MouseDoubleClick += new MouseEventHandler(authorsSuggestions_MouseClick);
            authorsSuggestions.FullRowSelect = true;
        }

        public GroupBox get_sugg()
        {

            return Suggestions;

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

            FavAuthorList = Form1.favorites.AuthorList;
            FavJournalList = Form1.favorites.JournalList;

            Console.WriteLine(FavAuthorList.Count);

            if (authorRadioButton.Checked == true)
            {
                favouritesTreeView.Nodes[0].Nodes[0].Nodes.Clear();
                for (int i = 0; i < FavAuthorList.Count; i++)
                {
                    favouritesTreeView.Nodes[0].Nodes[0].Nodes.Add(new TreeNode(FavAuthorList[i].Name));
                    favouritesTreeView.Nodes[0].Nodes[0].Nodes[i].ContextMenuStrip = favouriteMenuStrip;
                }
            }
            else if (journalsRadioButton.Checked == true)
            {
                favouritesTreeView.Nodes[0].Nodes[1].Nodes.Clear();
                for (int i = 0; i < Form1.favorites.JournalList.Count; i++)
                {
                    favouritesTreeView.Nodes[0].Nodes[1].Nodes.Add(new TreeNode(FavJournalList[i].Name));
                    favouritesTreeView.Nodes[0].Nodes[1].Nodes[i].ContextMenuStrip = favouriteMenuStrip;
                }
            }
        }

        private void authorsSuggestions_MouseClick(object sender, EventArgs e)
        {
            int index = authorsSuggestions.FocusedItem.Index;
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
            populateAuthor(authStats);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.GetContainerControl();
        }

        private void populateJournal(SG.Journal journal)
        {

            journalResultsListView.Items.Clear();
            authorResultsListView.Visible = false;
            journalResultsListView.Visible = true;

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
            //citesperYear.Text = FavAuthorList[favouritesTreeView.SelectedNode.Index].get
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
        }

        private void populateAuthor(SG.Author author)
        {
            authorResultsListView.Items.Clear();
            authorResultsListView.Visible = true;
            journalResultsListView.Visible = false;

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
            //citesperYear.Text = authstats.get
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

        private void searchIcon_Click(object sender, EventArgs e)
        {
            authorsSuggestions.Items.Clear();
            authorResultsListView.Items.Clear();
            journalResultsListView.Items.Clear();

            if (authorRadioButton.Checked == true)
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
                    if (a[0] == true) authStats = CSParser.getAuthors(searchField.Text);
                    else if (a[1] == true) authStats = GSScraper.getAuthors(searchField.Text);
                    /*Add for MAS*/

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
            if (journalsRadioButton.Checked == true)
            {
                
                if (siteComboBox.SelectedItem.ToString().Equals("Citeseer"))
                {
                    a[0] = true;
                    a[1] = false;
                    a[2] = false;
                    CSParser = new CSXParser();
                    journalStats = CSParser.getJournals(searchField.Text);

                }
                else if (siteComboBox.SelectedItem.ToString().Equals("Google Scholar"))
                {
                    a[0] = false;
                    a[1] = true;
                    a[2] = false;
                    GSScraper = new GSScraper();
                    journalStats = GSScraper.getJournals(searchField.Text);

                }
                else if (siteComboBox.SelectedItem.ToString().Equals("Microsoft Academic Search"))
                {
                    a[0] = false;
                    a[1] = false;
                    a[2] = true;
                    MSParser = new MicrosoftScholarParser();
                    journalStats = MSParser.getJournals(searchField.Text);
                }
                populateJournal(journalStats);
            }
        }

        private void viewURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage bpage = new TabPage("Browser");
            Browser browser;
            if (authorResultsListView.Visible == true)
                browser = new Browser(Papers[authorResultsListView.FocusedItem.Index].TitleURL);
            else
                browser = new Browser(Papers[journalResultsListView.FocusedItem.Index].TitleURL);
            bpage.Controls.Add(browser);

            Form1.dub_tab.TabPages.Insert(Form1.dub_tab.TabPages.Count - 1, bpage);
            Form1.dub_tab.SelectedTab = bpage;
        }

        private void viewCitationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage citationsPage = new TabPage("Citations");
            Form1.dub_tab.TabPages.Insert(Form1.dub_tab.TabPages.Count - 1, citationsPage);
            CitationsTab NcitTab = new CitationsTab();
            citationsPage.Controls.Add(NcitTab);

            if (a[0] == true)
            {
                Console.WriteLine("URL:" + Papers[authorResultsListView.FocusedItem.Index].CitedByURL);
                NcitTab.populateCitations(Papers[authorResultsListView.FocusedItem.Index], CSParser.getCitations(Papers[authorResultsListView.FocusedItem.Index].CitedByURL), 0);

            }
            else if (a[1] == true)
            {
                // Console.WriteLine("URL:" + Papers[authorResultsListView.FocusedItem.Index].CitedByURL + "Paper Name:" + Papers[authorResultsListView.FocusedItem.Index].Title);
                NcitTab.populateCitations(Papers[authorResultsListView.FocusedItem.Index], GSScraper.getCitations(Papers[authorResultsListView.FocusedItem.Index].CitedByURL), 1);

            } else if(a[2] == true) {

                NcitTab.populateCitations(Papers[authorResultsListView.FocusedItem.Index], MSParser.getCitations(Papers[authorResultsListView.FocusedItem.Index].CitedByURL), 2);
            }

            Form1.dub_tab.SelectedTab = citationsPage;
        }

        private void addToFavourite_Click(object sender, EventArgs e)
        {
            if (authorRadioButton.Checked == true)
                Form1.favorites.AddAuthor(authStats);
            else if (journalsRadioButton.Checked == true)
                Form1.favorites.AddJournal(journalStats);
            UpdateTree();
        }

        private void viewStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // author selected 
            if (favouritesTreeView.SelectedNode.Parent.Index == 0)
            {
                authStats = FavAuthorList[favouritesTreeView.SelectedNode.Index];
                populateAuthor(authStats);
            }
            else if (favouritesTreeView.SelectedNode.Parent.Index == 1) {// Journal selected
                journalStats = FavJournalList[favouritesTreeView.SelectedNode.Index];
                populateJournal(journalStats);
            }
            Console.WriteLine(favouritesTreeView.SelectedNode.Level);
        }

        private void removeFromFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void StartYear_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(StartYear.Text);
            if (StartYear.Text.Length == 4 || StartYear.getintval() == 0)
            {
                if (authorRadioButton.Checked == true && authStats != null)
                    populateAuthor(authStats);
                else if (journalStats != null)
                    populateJournal(journalStats);
            }
        }

        private void EndYear_TextChanged(object sender, EventArgs e)
        {
            
            if (EndYear.Text.Length == 4 || EndYear.getintval() == 0)
            {
                if (authorRadioButton.Checked == true && authStats != null)
                    populateAuthor(authStats);
                else if (journalStats != null)
                    populateJournal(journalStats);
            }
        }
    }
}
