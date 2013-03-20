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
    public partial class CitationsTab : UserControl
    {
        ListViewItem item;
        List<SG.Paper> MainPapers;
        GSScraper GSScraper;
        CSXParser CSParser;

        int type;
        public CitationsTab()
        {
            InitializeComponent();
        }


        public void populateCitations(List<SG.Paper> Papers,int t) {
            MainPapers = Papers;
            type = t;
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

        private void CitationsButton_Click(object sender, EventArgs e)
        {
            if (type == 0) {
                CSParser = new CSXParser();
                populateCitations(CSParser.getCitations(MainPapers[authorResultsListView.FocusedItem.Index].CitedByURL), type);
            
            }
            else if (type == 1)
            {
                GSScraper = new GSScraper();
                populateCitations(GSScraper.getCitations(MainPapers[authorResultsListView.FocusedItem.Index].CitedByURL), type);
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Form1.dub_tab.TabPages.Remove(Form1.dub_tab.SelectedTab);
        }

        private void viewCitationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (type == 0)
            {
                CSParser = new CSXParser();
                populateCitations(CSParser.getCitations(MainPapers[authorResultsListView.FocusedItem.Index].CitedByURL), type);

            }
            else if (type == 1)
            {
                GSScraper = new GSScraper();
                populateCitations(GSScraper.getCitations(MainPapers[authorResultsListView.FocusedItem.Index].CitedByURL), type);
            }
        }

        private void viewUrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage bpage = new TabPage("Browser");
            Browser browser;
            if (authorResultsListView.Visible == true)
                browser = new Browser(MainPapers[authorResultsListView.FocusedItem.Index].CitedByURL);
            else
                browser = new Browser(MainPapers[journalsResultsListView.FocusedItem.Index].CitedByURL);
            bpage.Controls.Add(browser);
            Form1.dub_tab.TabPages.Add(bpage);
        }
    }
}