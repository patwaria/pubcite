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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.SuspendLayout();
            // 
            // UrlBox
            // 
            this.UrlBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UrlBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlBox.Location = new System.Drawing.Point(64, 3);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(893, 22);
            this.UrlBox.TabIndex = 0;
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UrlLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.UrlLabel.Location = new System.Drawing.Point(23, 5);
            this.UrlLabel.Margin = new System.Windows.Forms.Padding(3);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.UrlLabel.Size = new System.Drawing.Size(34, 19);
            this.UrlLabel.TabIndex = 1;
            this.UrlLabel.Text = "URL :";
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(963, 1);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(23, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.TabStop = false;
            this.searchButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(0, 32);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(1008, 612);
            this.webBrowser.TabIndex = 3;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.UrlLabel);
            this.Controls.Add(this.UrlBox);
            this.Name = "Browser";
            this.Size = new System.Drawing.Size(1016, 644);
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.WebBrowser webBrowser;

    }
}
