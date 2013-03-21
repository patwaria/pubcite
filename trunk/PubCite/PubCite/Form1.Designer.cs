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
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.maintabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // searchTab1
            // 
            this.searchTab1.BackColor = System.Drawing.SystemColors.Window;
            this.searchTab1.Location = new System.Drawing.Point(4, 22);
            this.searchTab1.Name = "searchTab1";
            this.searchTab1.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab1.Size = new System.Drawing.Size(995, 636);
            this.searchTab1.TabIndex = 0;
            this.searchTab1.Text = "Search";
            // 
            // maintabControl
            // 
            this.maintabControl.Controls.Add(this.searchTab1);
            this.maintabControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintabControl.Location = new System.Drawing.Point(3, 0);
            this.maintabControl.Name = "maintabControl";
            this.maintabControl.SelectedIndex = 0;
            this.maintabControl.Size = new System.Drawing.Size(1003, 662);
            this.maintabControl.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "plus.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 663);
            this.Controls.Add(this.maintabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.maintabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TabControl maintabControl;
        private System.Windows.Forms.TabPage searchTab1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

