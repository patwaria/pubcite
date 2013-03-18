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
    public partial class search : UserControl
    {
        public search()
        {
            InitializeComponent();
        }

        public GroupBox get_sugg() {

            return Suggestions;    
        
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
           //this.Parent.
            //Form1.closeTab();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            authorsSuggestions.Items.Clear();
            if (authorRadioButton.Checked == true)
            {
                authorResultsListView.Visible = true;
                journalsResultsListView.Visible = false;
             

                if (siteComboBox.SelectedItem.ToString().Equals("Citeseer"))
                {
                    a[0] = true;
                    a[1] = false;
                    a[2] = false;
                    Parser = new CSXParser();
                    authSug = Parser.getAuthSuggestions(searchField.Text);
                
                }
                else if (siteComboBox.SelectedItem.ToString().Equals("Google Scholar"))
                {
                    a[0] = false;
                    a[1] = true;
                    a[2] = false;
                    Scraper = new GSScraper();
                    authSug = Scraper.getAuthSuggestions(searchField.Text);
                    
                
                }
                else if (siteComboBox.SelectedItem.ToString().Equals("Microsoft Academic Search"))
                    System.Console.WriteLine("MAS Not available");

               

                if (authSug == null || !authSug.isSet())
                {
                    authorResultsListView.Items.Clear();
                    Results = new SG.ClassifyAuthors();
                    if (a[0] == true) Results = Parser.getAuthors(searchField.Text);
                    else if (a[1] == true) Results = Scraper.getAuthors(searchField.Text);
                    Papers = Results.Papers;
                    for (int i = 0; i < Papers.Count; i++)
                    {


                        /*populating */
                        item = new ListViewItem(Papers[i].Title);
                        item.SubItems.Add(Papers[i].Year.ToString());
                        item.SubItems.Add(Papers[i].NumberOfCitations.ToString());
                        authorResultsListView.Items.Add(item);
                        Console.WriteLine(Papers[i].Title + Papers[i].Year + Papers[i].NumberOfCitations);


                    }
                    
                    // TODO : show message to user and gofor exhaustive search results
                    System.Console.WriteLine("Data Not Available!");
                    
                }
                else
                {
                    //System.Console.WriteLine(authSug.isSet());
                   authors = authSug.getSuggestions();
                   auth_url = authSug.getSuggestionsURL();

                   // System.Console.WriteLine(authors[0]);
                   if (authors.Count == 1)
                   {
                       populatePapers(0);
                   }
                   else
                   {
                       System.Console.WriteLine("I'm called 1");
                       Suggestions.Visible = true;
                       System.Console.WriteLine("I'm called 2");
                       for (int i = 0; i < authors.Count; i++)
                       {
                           
                           item = new ListViewItem(authors[i]);
                           authorsSuggestions.Items.Add(item);
                       }
                   }
                    authorsSuggestions.FullRowSelect = true;
                    authorsSuggestions.Click += new EventHandler(authorsSuggestions_Click);
                }
                
             }
            if (journalsRadioButton.Checked == true)
            {
                authorResultsListView.Visible = false;
                journalsResultsListView.Visible = true;
            }

            System.Console.WriteLine();
        }

        private void authorsSuggestions_Click(object sender, EventArgs e)
        {

            populatePapers(authorsSuggestions.FocusedItem.Index);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.GetContainerControl();   
        }

        private void siteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void populatePapers(int index) {
            authorResultsListView.Items.Clear();
            if (a[0] == true)
                authstats = Parser.getAuthStatistics(auth_url[index]);
            else if (a[1] == true)
                authstats = Scraper.getAuthStatistics(auth_url[index]);
            Papers = authstats.getPapers();
            Console.WriteLine(Papers.Count);
            authorNameLabel.Text = authstats.Name;
            citesperPaper.Text = authstats.getCitesPerPaper().ToString();
            //citesperYear.Text = authstats.get
            hindex.Text = authstats.getHIndex().ToString();
            i10index.Text = authstats.getI10Index().ToString();
            citationsNumberLabel.Text = authstats.getTotalNumberofCitations().ToString();
            for (int i = 0; i < Papers.Count; i++)
            {


                /*populating */


                item = new ListViewItem(Papers[i].Title);
                item.SubItems.Add(Papers[i].Year.ToString());
                item.SubItems.Add(Papers[i].NumberOfCitations.ToString());
                authorResultsListView.Items.Add(item);
                Console.WriteLine(Papers[i].Title + Papers[i].Year + Papers[i].NumberOfCitations);


            }
        }

        List<string> auth_url;
        List<string> authors;
        CSXParser Parser;
        GSScraper Scraper;
        ListViewItem item;
        SG.AuthSuggestion authSug;
        SG.Author authstats;
        SG.ClassifyAuthors Results;
        List<SG.Paper> Papers;
        Boolean[] a = { false,false,false };
    }
    
    

}
