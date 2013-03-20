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
    public partial class Browser : UserControl
    {
        private string url;

        public Browser()
        {
            InitializeComponent();
        }

        public Browser(string url)
        {
            InitializeComponent();
            this.url = url;
            showUrlContents();
        }

        public void showUrlContents() {

            this.webBrowser.Navigate(this.url);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.url = this.UrlBox.Text;
            showUrlContents();
        }

        private void closeBrowser_Click(object sender, EventArgs e)
        {
            Form1.dub_tab.TabPages.Remove(Form1.dub_tab.SelectedTab);
        }
    }
}
