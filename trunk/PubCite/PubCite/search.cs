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
             Parser = new CSXParser();
            if (siteComboBox.SelectedItem.ToString().Equals("Citeseer"))
                System.Console.WriteLine("Citeseer available");
            else if (siteComboBox.SelectedItem.ToString().Equals("Google Scholar"))
                System.Console.WriteLine("GS Not available");
            else if (siteComboBox.SelectedItem.ToString().Equals("Microsoft Academic Search"))
                System.Console.WriteLine("MAS Not available");


            if (authorRadioButton.Checked == true)
            {
                authorResultsListView.Visible = true;
                journalsResultsListView.Visible = false;
                Suggestions.Visible = true;

                SG.AuthSuggestion authSug = Parser.getAuthSuggestions(searchField.Text);

                if (authSug == null || !authSug.isSet())
                {
                    // TODO : show message to user and gofor exhaustive search results
                    
                    System.Console.WriteLine("Data Not Available!");
                }
                else
                {
                    //System.Console.WriteLine(authSug.isSet());
                   authors = authSug.getSuggestions();
                   auth_url = authSug.getSuggestionsURL();

                   // System.Console.WriteLine(authors[0]);
                    ListViewItem item;
                    for (int i = 0; i < authors.Count; i++)
                    {
                        item = new ListViewItem(authors[i]);
                        authorsSuggestions.Items.Add(item);
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
            SG.Author authstas = Parser.getAuthStatistics(auth_url[authorsSuggestions.FocusedItem.Index]);
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.GetContainerControl();   
        }

        private void siteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        List<string> auth_url;
        List<string> authors;
        CSXParser Parser;
    }
    
    

}
