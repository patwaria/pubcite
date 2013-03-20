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
            this.Filemenu = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.favouritesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.searchTab1 = new System.Windows.Forms.TabPage();
            this.maintabControl = new System.Windows.Forms.TabControl();
            this.Filemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.maintabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Filemenu
            // 
            this.Filemenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
            this.Filemenu.Location = new System.Drawing.Point(0, 0);
            this.Filemenu.Name = "Filemenu";
            this.Filemenu.Size = new System.Drawing.Size(1006, 24);
            this.Filemenu.TabIndex = 0;
            this.Filemenu.Text = "menuStrip1";
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
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem1.Text = "Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // favouritesToolStripMenuItem1
            // 
            this.favouritesToolStripMenuItem1.Name = "favouritesToolStripMenuItem1";
            this.favouritesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.favouritesToolStripMenuItem1.Text = "Favourites";
            this.favouritesToolStripMenuItem1.Click += new System.EventHandler(this.favouritesToolStripMenuItem1_Click);
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
            this.searchTab1.Size = new System.Drawing.Size(983, 598);
            this.searchTab1.TabIndex = 0;
            this.searchTab1.Text = "Favourites";
            // 
            // maintabControl
            // 
            this.maintabControl.Controls.Add(this.searchTab1);
            this.maintabControl.Location = new System.Drawing.Point(3, 27);
            this.maintabControl.Name = "maintabControl";
            this.maintabControl.SelectedIndex = 0;
            this.maintabControl.Size = new System.Drawing.Size(991, 624);
            this.maintabControl.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 663);
            this.Controls.Add(this.maintabControl);
            this.Controls.Add(this.Filemenu);
            this.MainMenuStrip = this.Filemenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Filemenu.ResumeLayout(false);
            this.Filemenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.maintabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Filemenu;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TabControl maintabControl;
        private System.Windows.Forms.TabPage searchTab1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem favouritesToolStripMenuItem1;
    }
}

