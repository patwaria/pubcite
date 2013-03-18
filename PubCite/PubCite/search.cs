﻿using System;
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
                Console.WriteLine("in gs22");
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
                    Console.WriteLine("in gs" + searchField.Text);
                    
                    authSug = Scraper.getAuthSuggestions(searchField.Text);
                    
                
                }
                else if (siteComboBox.SelectedItem.ToString().Equals("Microsoft Academic Search"))
                    System.Console.WriteLine("MAS Not available");

                Console.WriteLine(authSug.getSuggestions());

                Console.WriteLine(authSug.isSet());
                if (authSug == null || !authSug.isSet())
                {
                    
                    authorResultsListView.Items.Clear();
                    Results = new SG.ClassifyAuthors();
                    if (a[0] == true) Results = Parser.getAuthors(searchField.Text);
                    else if (a[1] == true) Results = Scraper.getAuthors(searchField.Text);
                    Papers =(Results.Papers);
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
                      
                       Suggestions.Visible = true;
                       
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

                if (siteComboBox.SelectedItem.ToString().Equals("Citeseer"))
                {
                    a[0] = true;
                    a[1] = false;
                    a[2] = false;
                    Parser = new CSXParser();
                    populateJournals();

                }
                else if (siteComboBox.SelectedItem.ToString().Equals("Google Scholar"))
                {
                    a[0] = false;
                    a[1] = true;
                    a[2] = false;
                    Scraper = new GSScraper();
                    populateJournals();

                  


                }
                else if (siteComboBox.SelectedItem.ToString().Equals("Microsoft Academic Search"))
                    System.Console.WriteLine("MAS Not available");



            }

            System.Console.WriteLine();
        }

        private void populateJournals() {

            if (a[0] == true)
                JournalResu = Parser.getJournals(searchField.Text);
            else if (a[1] == true)
                JournalResu = Scraper.getJournals(searchField.Text);
            Papers = JournalResu.papers;
            for (int i = 0; i < Papers.Count; i++) {

                item = new ListViewItem(Papers[i].Title);
                item.SubItems.Add(Papers[i].Authors);
                item.SubItems.Add(Papers[i].Citations.ToString());
                item.SubItems.Add(Papers[i].Year.ToString());
                journalsResultsListView.Items.Add(item);
            
            }
            
            
        
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
            authorResultsListView.FullRowSelect=true;
            authorResultsListView.Click += new EventHandler(authorResultsListView_OnClick);
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
        List<SG.Paper> CitationPapers;
        SG.ClassifyJournals JournalResu;
        Boolean[] a = { false,false,false };

        private void authorResultsListView_OnClick(object sender, EventArgs e)
        {
            if (Papers[authorResultsListView.FocusedItem.Index].NumberOfCitations > 0) {

              CitationPapers = Scraper.getCitations(Papers[authorResultsListView.FocusedItem.Index].CitedByURL);
              for (int i = 0; i < CitationPapers.Count; i++) {
                  item = new ListViewItem(CitationPapers[i].Title);
                  citationsDetailsListView.Items.Add(item);
              
              }
            
            }
        }

        private void resultsGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
    
    

}
