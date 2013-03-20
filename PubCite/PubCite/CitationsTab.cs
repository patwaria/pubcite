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
        GSScraper Scraper;

        public CitationsTab()
        {
            InitializeComponent();
        }


        public void populateCitations(List<SG.Paper> Papers) {
            MainPapers = Papers;
            authorResultsListView.Items.Clear();
            for (int i = 0; i < Papers.Count; i++)
            {


                /*populating */


                item = new ListViewItem(Papers[i].Title);
                item.SubItems.Add(Papers[i].Year.ToString());
                item.SubItems.Add(Papers[i].NumberOfCitations.ToString());
                authorResultsListView.Items.Add(item);
                Console.WriteLine(Papers[i].Title + Papers[i].Year + Papers[i].NumberOfCitations);


            }
            authorResultsListView.FullRowSelect = true;
        
        
        
        
        
        }

        private void CitationsButton_Click(object sender, EventArgs e)
        {
            Scraper = new GSScraper();
            populateCitations(Scraper.getCitations(MainPapers[authorResultsListView.FocusedItem.Index].CitedByURL));

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Form1.dub_tab.TabPages.Remove(Form1.dub_tab.SelectedTab);
        }
    }
}
