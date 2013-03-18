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
        public Form1()
        {
            InitializeComponent();
            search Nsearch = new search();
            searchTab1.Controls.Add(Nsearch);
            Nsearch.get_sugg().Visible = false;
            dub_tab = maintabControl;
            favorites = new SG.Favorite();
            favorites.populateFavorites();
        }

        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

       

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
        private void toolStripbackButton_Click(object sender, EventArgs e)
        {

        }

       

        
    }
}
