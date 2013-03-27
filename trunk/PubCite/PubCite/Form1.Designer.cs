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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.searchTab1 = new System.Windows.Forms.TabPage();
            this.maintabControl = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.maintabControl.SuspendLayout();
            this.tabMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // searchTab1
            // 
            this.searchTab1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchTab1.ImageIndex = 1;
            this.searchTab1.Location = new System.Drawing.Point(4, 22);
            this.searchTab1.Margin = new System.Windows.Forms.Padding(0);
            this.searchTab1.Name = "searchTab1";
            this.searchTab1.Size = new System.Drawing.Size(1008, 630);
            this.searchTab1.TabIndex = 0;
            this.searchTab1.Text = "Search";
            // 
            // maintabControl
            // 
            this.maintabControl.Controls.Add(this.searchTab1);
            this.maintabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintabControl.ItemSize = new System.Drawing.Size(48, 18);
            this.maintabControl.Location = new System.Drawing.Point(-4, 0);
            this.maintabControl.Name = "maintabControl";
            this.maintabControl.SelectedIndex = 0;
            this.maintabControl.Size = new System.Drawing.Size(1016, 656);
            this.maintabControl.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "plus.png");
            this.imageList1.Images.SetKeyName(1, "close.gif");
            // 
            // tabMenuStrip
            // 
            this.tabMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.tabMenuStrip.Name = "contextMenuStrip1";
            this.tabMenuStrip.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::PubCite.Properties.Resources.close;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1006, 652);
            this.Controls.Add(this.maintabControl);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PubCite";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.maintabControl.ResumeLayout(false);
            this.tabMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TabControl maintabControl;
        private System.Windows.Forms.TabPage searchTab1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip tabMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

