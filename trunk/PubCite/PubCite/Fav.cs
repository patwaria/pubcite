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
    public partial class FavPanel : UserControl
    {
        
        List<SG.Author> FavAuthorList;
        List<SG.Paper> Papers;
        ListViewItem item;
        public FavPanel()
        {
            InitializeComponent();
            ArrangeTree();
        }

        private void ArrangeTree() {

           FavAuthorList = Form1.favorites.AuthorList;
           Console.WriteLine(FavAuthorList.Count);
           for (int i = 0; i < FavAuthorList.Count; i++) {

               favouritesTreeView.Nodes[0].Nodes[0].Nodes.Add(new TreeNode(FavAuthorList[i].Name));
           
           }

            ;
           Console.WriteLine(FavAuthorList.Count);
           for (int i = 0; i < Form1.favorites.JournalList.Count; i++)
           {

               favouritesTreeView.Nodes[0].Nodes[1].Nodes.Add(new TreeNode(Form1.favorites.JournalList[i].Name));

           }

        
        
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (favouritesTreeView.SelectedNode.Parent.Level == 1) {


                if (favouritesTreeView.SelectedNode.Parent.Index == 0) {

                    authorResultsListView.Items.Clear();
                    Papers = FavAuthorList[favouritesTreeView.SelectedNode.Index].getPapers();

                    authorNameLabel.Text = FavAuthorList[favouritesTreeView.SelectedNode.Index].Name;
                    citesperPaper.Text = FavAuthorList[favouritesTreeView.SelectedNode.Index].getCitesPerPaper().ToString();
                    //citesperYear.Text = FavAuthorList[favouritesTreeView.SelectedNode.Index].get
                    hindex.Text = FavAuthorList[favouritesTreeView.SelectedNode.Index].getHIndex().ToString();
                    i10index.Text = FavAuthorList[favouritesTreeView.SelectedNode.Index].getI10Index().ToString();
                    citationsNumberLabel.Text = FavAuthorList[favouritesTreeView.SelectedNode.Index].getTotalNumberofCitations().ToString();
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
            
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("blah");

            
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            Form1.dub_tab.TabPages.Remove(Form1.dub_tab.SelectedTab);
        }
    }
}
