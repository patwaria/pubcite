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
            if (authorRadioButton.Checked == true)
            {
                authorResultsListView.Visible = true;
                journalsResultsListView.Visible = false;
                Suggestions.Visible = true;
             }
            if (journalsRadioButton.Checked == true)
            {
                authorResultsListView.Visible = false;
                journalsResultsListView.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.GetContainerControl();   
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
