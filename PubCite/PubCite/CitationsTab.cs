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
        GSScraper GSScraper;
        CSXParser CSParser;
        MicrosoftScholarParser MSParser;
        int type;
        public CitationsTab()
        {
            InitializeComponent();
        }


        public void populateCitations(SG.Paper paper, List<SG.Paper> Papers,int t) {
            MainPapers = Papers;
            type = t;

            /* Add statistics */
            publicationsDetailsGroupBox.Text = paper.Title;
            authorsName.Text = paper.Authors;
            yearLabel.Text = paper.Year.ToString();
            venue.Text = paper.Publication;
            numCitations.Text = paper.NumberOfCitations.ToString();
            publisher.Text = paper.Publisher;

            authorResultsListView.Items.Clear();
            for (int i = 0; i < Papers.Count; i++)
            {

                /*populating */
                item = new ListViewItem(Papers[i].Title);
                item.SubItems.Add(Papers[i].Authors);
                item.SubItems.Add(Papers[i].Year.ToString());
                item.SubItems.Add(Papers[i].NumberOfCitations.ToString());
                authorResultsListView.Items.Add(item);
                Console.WriteLine(Papers[i].Title + Papers[i].Year + Papers[i].NumberOfCitations);


            }
            authorResultsListView.FullRowSelect = true;
            authorResultsListView.MouseClick += new MouseEventHandler(authorResultsListView_MouseClick);                                        
        }


        private void authorResultsListView_MouseClick(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Right)
            {

                if (authorResultsListView.FocusedItem.Bounds.Contains(e.Location) == true)
                    optionMenuStrip.Show(Cursor.Position);

            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Form1.dub_tab.TabPages.Remove(Form1.dub_tab.SelectedTab);
            Form1.dub_tab.SelectedIndex = Form1.dub_tab.TabCount - 2;
        }

        private void viewCitationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (type == 0)
            {
                CSParser = new CSXParser();
                populateCitations(MainPapers[authorResultsListView.FocusedItem.Index], CSParser.getCitations(MainPapers[authorResultsListView.FocusedItem.Index].CitedByURL), type);

            }
            else if (type == 1)
            {
                GSScraper = new GSScraper();
                populateCitations(MainPapers[authorResultsListView.FocusedItem.Index], GSScraper.getCitations(MainPapers[authorResultsListView.FocusedItem.Index].CitedByURL), type);
            }
            else if (type == 2)
            {
                MSParser = new MicrosoftScholarParser();
                populateCitations(MainPapers[authorResultsListView.FocusedItem.Index], MSParser.getCitations(MainPapers[authorResultsListView.FocusedItem.Index].CitedByURL), type);
            }
        }

        private void viewUrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage bpage = new TabPage("Browser");
            Browser browser;
            if (authorResultsListView.Visible == true)
                browser = new Browser(MainPapers[authorResultsListView.FocusedItem.Index].TitleURL);
            else
                browser = new Browser(MainPapers[journalsResultsListView.FocusedItem.Index].TitleURL);
            bpage.Controls.Add(browser);

            Form1.dub_tab.TabPages.Insert(Form1.dub_tab.TabPages.Count - 1, bpage);
            Form1.dub_tab.SelectedTab = bpage;
        }
    }
}
