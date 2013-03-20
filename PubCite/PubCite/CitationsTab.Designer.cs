namespace PubCite
{
    partial class CitationsTab
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.authorResultsListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.journalsResultsListView = new System.Windows.Forms.ListView();
            this.Paper = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cites = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CitationsButton = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CitationsButton);
            this.panel3.Controls.Add(this.CloseButton);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(974, 562);
            this.panel3.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(852, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(107, 23);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.resultsGroupBox);
            this.panel4.Location = new System.Drawing.Point(9, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(837, 546);
            this.panel4.TabIndex = 3;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.authorResultsListView);
            this.resultsGroupBox.Controls.Add(this.journalsResultsListView);
            this.resultsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(834, 543);
            this.resultsGroupBox.TabIndex = 0;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results ";
            // 
            // authorResultsListView
            // 
            this.authorResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.authorResultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorResultsListView.GridLines = true;
            this.authorResultsListView.Location = new System.Drawing.Point(3, 16);
            this.authorResultsListView.MultiSelect = false;
            this.authorResultsListView.Name = "authorResultsListView";
            this.authorResultsListView.Size = new System.Drawing.Size(828, 524);
            this.authorResultsListView.TabIndex = 1;
            this.authorResultsListView.UseCompatibleStateImageBehavior = false;
            this.authorResultsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Paper";
            this.columnHeader6.Width = 677;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Year";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "No.Of Cites";
            this.columnHeader8.Width = 86;
            // 
            // journalsResultsListView
            // 
            this.journalsResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Paper,
            this.Author,
            this.Cites,
            this.Year});
            this.journalsResultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journalsResultsListView.GridLines = true;
            this.journalsResultsListView.Location = new System.Drawing.Point(3, 16);
            this.journalsResultsListView.MultiSelect = false;
            this.journalsResultsListView.Name = "journalsResultsListView";
            this.journalsResultsListView.Size = new System.Drawing.Size(828, 524);
            this.journalsResultsListView.TabIndex = 0;
            this.journalsResultsListView.UseCompatibleStateImageBehavior = false;
            this.journalsResultsListView.View = System.Windows.Forms.View.Details;
            this.journalsResultsListView.Visible = false;
            // 
            // Paper
            // 
            this.Paper.Text = "Paper";
            this.Paper.Width = 205;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 166;
            // 
            // Cites
            // 
            this.Cites.Text = "No.Of Cites";
            this.Cites.Width = 83;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 66;
            // 
            // CitationsButton
            // 
            this.CitationsButton.Location = new System.Drawing.Point(852, 75);
            this.CitationsButton.Name = "CitationsButton";
            this.CitationsButton.Size = new System.Drawing.Size(107, 23);
            this.CitationsButton.TabIndex = 9;
            this.CitationsButton.Text = "View Citations";
            this.CitationsButton.UseVisualStyleBackColor = true;
            this.CitationsButton.Click += new System.EventHandler(this.CitationsButton_Click);
            // 
            // CitationsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "CitationsTab";
            this.Size = new System.Drawing.Size(980, 566);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.resultsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.ListView authorResultsListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView journalsResultsListView;
        private System.Windows.Forms.ColumnHeader Paper;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Cites;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.Button CitationsButton;


    }
}
