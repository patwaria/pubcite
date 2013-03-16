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
            CSXParser Parser = new CSXParser();
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

                if (authSug == null)
                    System.Console.WriteLine("NULL");
                else
                {
                    //System.Console.WriteLine(authSug.isSet());
                    List<string> authors = authSug.getSuggestions();
                    System.Console.WriteLine(authors[0]);
                    ListViewItem item;
                    for(int i = 0; i < authors.Count; i++) {
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.GetContainerControl();   
        }

        private void siteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void authorsSuggestions_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
