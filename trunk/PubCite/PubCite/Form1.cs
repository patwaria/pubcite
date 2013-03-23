using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PubCite
{
    public partial class Form1 : Form
    {
        public static TabControl dub_tab;
        public static SG.Favorite favorites;
        private TabPage newTabPage;
        TabPage createdTabPage;
        
        public Form1()
        {
            InitializeComponent();
            
            dub_tab = maintabControl;
            favorites = new SG.Favorite();
            favorites.populateFavorites();

            search nSearch = new search();
            searchTab1.Controls.Add(nSearch);

            maintabControl.ImageList = imageList1;
            //maintabControl.ContextMenuStrip = tabMenuStrip;
            newTabPage = new TabPage();
            newTabPage.ImageIndex = 0;
            maintabControl.Controls.Add(newTabPage);
            maintabControl.SelectedIndexChanged += new EventHandler(tabChangeHandler);
            maintabControl.MouseClick+=new MouseEventHandler(maintabControl_MouseClick);
                
        }

        public void maintabControl_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("calledclick");

            for (int i = 0; i < maintabControl.TabCount; i++)
            {
                if (maintabControl.GetTabRect(i).Contains(e.Location))
                {
                    RectangleF tabArea = maintabControl.GetTabRect(i);
                    System.Console.WriteLine(tabArea.X + "///" + tabArea.Y);
                    System.Console.WriteLine(e.X + "a/b/c" + e.Y);
                    RectangleF imageArea = new RectangleF(tabArea.X + 7, tabArea.Y, 15, 15);
                    if (imageArea.Contains(e.Location))
                    { if(maintabControl.TabPages[maintabControl.SelectedIndex + 1] != newTabPage)
                        maintabControl.TabPages.RemoveAt(i);
                    }
                }

            }
        }

        private void tabChangeHandler(object sender, EventArgs e)
        {
            Console.WriteLine("calledchange");
            if (maintabControl.SelectedTab == newTabPage)
            {
                search nSearch = new search();
                createdTabPage = new TabPage("Search");
                
                createdTabPage.ImageIndex = 1;
               
                createdTabPage.Controls.Add(nSearch);
                maintabControl.TabPages.Insert(maintabControl.TabPages.Count - 1, createdTabPage);
                maintabControl.SelectedTab = createdTabPage;
            }
        }
        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string s = "Search";
            TabPage MyTab = new TabPage(s);
            maintabControl.TabPages.Add(MyTab);
            search Nsearch = new search();
            MyTab.Controls.Add(Nsearch);
            Nsearch.get_sugg().Visible = false;
        }

        private void favouritesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string s = "Favourites";
            TabPage MyTab = new TabPage(s);
            maintabControl.TabPages.Add(MyTab);
            FavPanel NFav = new FavPanel();
            MyTab.Controls.Add(NFav);
           
        }

        public static TabControl get_maintab() {

            return dub_tab;
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
