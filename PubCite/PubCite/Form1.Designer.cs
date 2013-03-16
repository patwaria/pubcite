namespace PubCite
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Filemenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.favouritesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.searchTab1 = new System.Windows.Forms.TabPage();
            this.maintabControl = new System.Windows.Forms.TabControl();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripbackButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripforwardButton = new System.Windows.Forms.ToolStripButton();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Filemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.maintabControl.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Filemenu
            // 
            this.Filemenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.Filemenu.Location = new System.Drawing.Point(0, 0);
            this.Filemenu.Name = "Filemenu";
            this.Filemenu.Size = new System.Drawing.Size(1006, 24);
            this.Filemenu.TabIndex = 0;
            this.Filemenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem1,
            this.favouritesToolStripMenuItem1});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.searchToolStripMenuItem.Text = "Open";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.searchToolStripMenuItem1.Text = "Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // favouritesToolStripMenuItem1
            // 
            this.favouritesToolStripMenuItem1.Name = "favouritesToolStripMenuItem1";
            this.favouritesToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.favouritesToolStripMenuItem1.Text = "Favourites";
            this.favouritesToolStripMenuItem1.Click += new System.EventHandler(this.favouritesToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.helpToolStripMenuItem.Text = "History";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // searchTab1
            // 
            this.searchTab1.BackColor = System.Drawing.SystemColors.Control;
            this.searchTab1.Location = new System.Drawing.Point(4, 22);
            this.searchTab1.Name = "searchTab1";
            this.searchTab1.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab1.Size = new System.Drawing.Size(983, 553);
            this.searchTab1.TabIndex = 0;
            this.searchTab1.Text = "Search";
            // 
            // maintabControl
            // 
            this.maintabControl.Controls.Add(this.searchTab1);
            this.maintabControl.Location = new System.Drawing.Point(15, 84);
            this.maintabControl.Name = "maintabControl";
            this.maintabControl.SelectedIndex = 0;
            this.maintabControl.Size = new System.Drawing.Size(991, 579);
            this.maintabControl.TabIndex = 4;
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripbackButton,
            this.toolStripforwardButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1006, 38);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripbackButton
            // 
            this.toolStripbackButton.AutoSize = false;
            this.toolStripbackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbackButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbackButton.Image")));
            this.toolStripbackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbackButton.Name = "toolStripbackButton";
            this.toolStripbackButton.Size = new System.Drawing.Size(35, 35);
            this.toolStripbackButton.Text = "toolStripbackButton";
            this.toolStripbackButton.Click += new System.EventHandler(this.toolStripbackButton_Click);
            // 
            // toolStripforwardButton
            // 
            this.toolStripforwardButton.AutoSize = false;
            this.toolStripforwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripforwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripforwardButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripforwardButton.Image")));
            this.toolStripforwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripforwardButton.Name = "toolStripforwardButton";
            this.toolStripforwardButton.Size = new System.Drawing.Size(35, 35);
            this.toolStripforwardButton.Text = "toolStripforwardButton";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(927, 77);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 663);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.maintabControl);
            this.Controls.Add(this.Filemenu);
            this.MainMenuStrip = this.Filemenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Filemenu.ResumeLayout(false);
            this.Filemenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.maintabControl.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Filemenu;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TabControl maintabControl;
        private System.Windows.Forms.TabPage searchTab1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem favouritesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripbackButton;
        private System.Windows.Forms.ToolStripButton toolStripforwardButton;
    }
}

