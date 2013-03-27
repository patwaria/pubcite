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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.PictureBox();
            this.viewAll = new System.Windows.Forms.Button();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.publicationsDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.citationsShown = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.publisher = new System.Windows.Forms.Label();
            this.numCitations = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.venue = new System.Windows.Forms.Label();
            this.authorsName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.abstractBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.authorResultsListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.journalsResultsListView = new System.Windows.Forms.ListView();
            this.Paper = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cites = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.optionMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewCitationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).BeginInit();
            this.progressPanel.SuspendLayout();
            this.publicationsDetailsGroupBox.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.optionMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 637);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.filterTextBox);
            this.panel4.Controls.Add(this.stop);
            this.panel4.Controls.Add(this.viewAll);
            this.panel4.Controls.Add(this.progressPanel);
            this.panel4.Controls.Add(this.publicationsDetailsGroupBox);
            this.panel4.Controls.Add(this.resultsGroupBox);
            this.panel4.ForeColor = System.Drawing.SystemColors.Menu;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(992, 631);
            this.panel4.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(524, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Filter by   : ";
            // 
            // filterTextBox
            // 
            this.filterTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.filterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filterTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.filterTextBox.Location = new System.Drawing.Point(593, 197);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(244, 15);
            this.filterTextBox.TabIndex = 26;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // stop
            // 
            this.stop.Image = global::PubCite.Properties.Resources.stop;
            this.stop.Location = new System.Drawing.Point(864, 193);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(20, 20);
            this.stop.TabIndex = 25;
            this.stop.TabStop = false;
            this.stop.Visible = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // viewAll
            // 
            this.viewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAll.Location = new System.Drawing.Point(890, 189);
            this.viewAll.Name = "viewAll";
            this.viewAll.Size = new System.Drawing.Size(98, 23);
            this.viewAll.TabIndex = 24;
            this.viewAll.Text = " View Full List";
            this.viewAll.UseVisualStyleBackColor = true;
            this.viewAll.Click += new System.EventHandler(this.viewAll_Click);
            // 
            // progressPanel
            // 
            this.progressPanel.Controls.Add(this.label7);
            this.progressPanel.Controls.Add(this.progressBar);
            this.progressPanel.Location = new System.Drawing.Point(3, 181);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(476, 32);
            this.progressPanel.TabIndex = 23;
            this.progressPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Please wait while we process your query...";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 10);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(233, 16);
            this.progressBar.TabIndex = 0;
            // 
            // publicationsDetailsGroupBox
            // 
            this.publicationsDetailsGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.publicationsDetailsGroupBox.Controls.Add(this.label13);
            this.publicationsDetailsGroupBox.Controls.Add(this.citationsShown);
            this.publicationsDetailsGroupBox.Controls.Add(this.label15);
            this.publicationsDetailsGroupBox.Controls.Add(this.label8);
            this.publicationsDetailsGroupBox.Controls.Add(this.label9);
            this.publicationsDetailsGroupBox.Controls.Add(this.label10);
            this.publicationsDetailsGroupBox.Controls.Add(this.label11);
            this.publicationsDetailsGroupBox.Controls.Add(this.label12);
            this.publicationsDetailsGroupBox.Controls.Add(this.publisher);
            this.publicationsDetailsGroupBox.Controls.Add(this.numCitations);
            this.publicationsDetailsGroupBox.Controls.Add(this.yearLabel);
            this.publicationsDetailsGroupBox.Controls.Add(this.venue);
            this.publicationsDetailsGroupBox.Controls.Add(this.authorsName);
            this.publicationsDetailsGroupBox.Controls.Add(this.label2);
            this.publicationsDetailsGroupBox.Controls.Add(this.abstractBox);
            this.publicationsDetailsGroupBox.Controls.Add(this.label1);
            this.publicationsDetailsGroupBox.Controls.Add(this.label6);
            this.publicationsDetailsGroupBox.Controls.Add(this.label5);
            this.publicationsDetailsGroupBox.Controls.Add(this.label4);
            this.publicationsDetailsGroupBox.Controls.Add(this.label3);
            this.publicationsDetailsGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.publicationsDetailsGroupBox.Location = new System.Drawing.Point(3, 6);
            this.publicationsDetailsGroupBox.Name = "publicationsDetailsGroupBox";
            this.publicationsDetailsGroupBox.Size = new System.Drawing.Size(988, 174);
            this.publicationsDetailsGroupBox.TabIndex = 8;
            this.publicationsDetailsGroupBox.TabStop = false;
            this.publicationsDetailsGroupBox.Text = "Publication Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(783, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = ":";
            // 
            // citationsShown
            // 
            this.citationsShown.AutoSize = true;
            this.citationsShown.Location = new System.Drawing.Point(804, 38);
            this.citationsShown.Name = "citationsShown";
            this.citationsShown.Size = new System.Drawing.Size(14, 13);
            this.citationsShown.TabIndex = 24;
            this.citationsShown.Text = "#";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(685, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Citations Shown";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(555, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(555, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(71, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(71, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(71, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = ":";
            // 
            // publisher
            // 
            this.publisher.AutoSize = true;
            this.publisher.Location = new System.Drawing.Point(578, 59);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(0, 13);
            this.publisher.TabIndex = 17;
            // 
            // numCitations
            // 
            this.numCitations.AutoSize = true;
            this.numCitations.Location = new System.Drawing.Point(576, 38);
            this.numCitations.Name = "numCitations";
            this.numCitations.Size = new System.Drawing.Size(14, 13);
            this.numCitations.TabIndex = 16;
            this.numCitations.Text = "#";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(92, 58);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(28, 13);
            this.yearLabel.TabIndex = 15;
            this.yearLabel.Text = "Year";
            // 
            // venue
            // 
            this.venue.AutoSize = true;
            this.venue.Location = new System.Drawing.Point(92, 38);
            this.venue.Name = "venue";
            this.venue.Size = new System.Drawing.Size(40, 13);
            this.venue.TabIndex = 14;
            this.venue.Text = "Venue";
            // 
            // authorsName
            // 
            this.authorsName.AutoSize = true;
            this.authorsName.Location = new System.Drawing.Point(92, 18);
            this.authorsName.Name = "authorsName";
            this.authorsName.Size = new System.Drawing.Size(54, 13);
            this.authorsName.TabIndex = 13;
            this.authorsName.Text = "Author(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Abstract/Summary :";
            // 
            // abstractBox
            // 
            this.abstractBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.abstractBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.abstractBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abstractBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.abstractBox.Location = new System.Drawing.Point(9, 94);
            this.abstractBox.Name = "abstractBox";
            this.abstractBox.ReadOnly = true;
            this.abstractBox.Size = new System.Drawing.Size(976, 70);
            this.abstractBox.TabIndex = 11;
            this.abstractBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Publisher ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(490, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Citations ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Year ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Venue ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Author(s) ";
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.authorResultsListView);
            this.resultsGroupBox.Controls.Add(this.journalsResultsListView);
            this.resultsGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsGroupBox.Location = new System.Drawing.Point(0, 214);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(991, 417);
            this.resultsGroupBox.TabIndex = 0;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results ";
            // 
            // authorResultsListView
            // 
            this.authorResultsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authorResultsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.authorResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.authorColumn,
            this.columnHeader7,
            this.columnHeader8});
            this.authorResultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorResultsListView.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorResultsListView.ForeColor = System.Drawing.SystemColors.Menu;
            this.authorResultsListView.Location = new System.Drawing.Point(3, 18);
            this.authorResultsListView.MultiSelect = false;
            this.authorResultsListView.Name = "authorResultsListView";
            this.authorResultsListView.OwnerDraw = true;
            this.authorResultsListView.Size = new System.Drawing.Size(985, 396);
            this.authorResultsListView.TabIndex = 1;
            this.authorResultsListView.UseCompatibleStateImageBehavior = false;
            this.authorResultsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Paper";
            this.columnHeader6.Width = 654;
            // 
            // authorColumn
            // 
            this.authorColumn.Text = "Author(s)";
            this.authorColumn.Width = 161;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Year";
            this.columnHeader7.Width = 71;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "No.Of Cites";
            this.columnHeader8.Width = 98;
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
            this.journalsResultsListView.Location = new System.Drawing.Point(3, 18);
            this.journalsResultsListView.MultiSelect = false;
            this.journalsResultsListView.Name = "journalsResultsListView";
            this.journalsResultsListView.Size = new System.Drawing.Size(985, 396);
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
            // optionMenuStrip
            // 
            this.optionMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCitationsToolStripMenuItem,
            this.viewUrlToolStripMenuItem});
            this.optionMenuStrip.Name = "optionMenuStrip";
            this.optionMenuStrip.Size = new System.Drawing.Size(150, 48);
            // 
            // viewCitationsToolStripMenuItem
            // 
            this.viewCitationsToolStripMenuItem.Name = "viewCitationsToolStripMenuItem";
            this.viewCitationsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewCitationsToolStripMenuItem.Text = "View Citations";
            this.viewCitationsToolStripMenuItem.Click += new System.EventHandler(this.viewCitationsToolStripMenuItem_Click);
            // 
            // viewUrlToolStripMenuItem
            // 
            this.viewUrlToolStripMenuItem.Name = "viewUrlToolStripMenuItem";
            this.viewUrlToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewUrlToolStripMenuItem.Text = "View Url";
            this.viewUrlToolStripMenuItem.Click += new System.EventHandler(this.viewUrlToolStripMenuItem_Click);
            // 
            // CitationsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panel3);
            this.Name = "CitationsTab";
            this.Size = new System.Drawing.Size(1015, 640);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).EndInit();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            this.publicationsDetailsGroupBox.ResumeLayout(false);
            this.publicationsDetailsGroupBox.PerformLayout();
            this.resultsGroupBox.ResumeLayout(false);
            this.optionMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.GroupBox publicationsDetailsGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader authorColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox abstractBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip optionMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewCitationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUrlToolStripMenuItem;
        private System.Windows.Forms.Label authorsName;
        private System.Windows.Forms.Label venue;
        private System.Windows.Forms.Label publisher;
        private System.Windows.Forms.Label numCitations;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Panel progressPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button viewAll;
        private System.Windows.Forms.PictureBox stop;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label citationsShown;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox filterTextBox;


    }
}
