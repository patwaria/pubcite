namespace PubCite
{
    partial class Browser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.closeBrowser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.SuspendLayout();
            // 
            // UrlBox
            // 
            this.UrlBox.Location = new System.Drawing.Point(64, 3);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(777, 20);
            this.UrlBox.TabIndex = 0;
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Location = new System.Drawing.Point(23, 6);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(35, 13);
            this.UrlLabel.TabIndex = 1;
            this.UrlLabel.Text = "URL :";
            // 
            // searchButton
            // 
            this.searchButton.Image = global::PubCite.Properties.Resources.search_button2;
            this.searchButton.Location = new System.Drawing.Point(857, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(23, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.TabStop = false;
            this.searchButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(26, 32);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(960, 596);
            this.webBrowser.TabIndex = 3;
            // 
            // closeBrowser
            // 
            this.closeBrowser.Location = new System.Drawing.Point(895, 1);
            this.closeBrowser.Name = "closeBrowser";
            this.closeBrowser.Size = new System.Drawing.Size(75, 23);
            this.closeBrowser.TabIndex = 4;
            this.closeBrowser.Text = "Close";
            this.closeBrowser.UseVisualStyleBackColor = true;
            this.closeBrowser.Click += new System.EventHandler(this.closeBrowser_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeBrowser);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.UrlLabel);
            this.Controls.Add(this.UrlBox);
            this.Name = "Browser";
            this.Size = new System.Drawing.Size(996, 644);
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button closeBrowser;

    }
}
