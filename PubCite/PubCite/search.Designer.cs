namespace PubCite
{
    partial class search
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Authors");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Journals");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Favourites", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingsIcon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.KeywordsTextBox = new System.Windows.Forms.TextBox();
            this.journalCheckBox = new System.Windows.Forms.CheckBox();
            this.searchField = new System.Windows.Forms.TextBox();
            this.authorCheckBox = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.graphsPanel = new System.Windows.Forms.Panel();
            this.graphsCloseIcon = new System.Windows.Forms.PictureBox();
            this.graphsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.arbitPanel = new System.Windows.Forms.Panel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsCloseIcon = new System.Windows.Forms.PictureBox();
            this.settingsOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.microsoftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.googleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.citeseerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.CacheOptions = new System.Windows.Forms.GroupBox();
            this.cacheNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CacheOptionslabel = new System.Windows.Forms.Label();
            this.authorResultsListView = new System.Windows.Forms.ListView();
            this.PaperHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.venueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumOfCitesHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.journalResultsListView = new System.Windows.Forms.ListView();
            this.Paper = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cites = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statisticsGroupBox = new System.Windows.Forms.GroupBox();
            this.addToFav = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.graphComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numPapers = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.i10index = new System.Windows.Forms.Label();
            this.hindex = new System.Windows.Forms.Label();
            this.citesperPaper = new System.Windows.Forms.Label();
            this.citesperYear = new System.Windows.Forms.Label();
            this.citationsNumberLabel = new System.Windows.Forms.Label();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.i10indexLabel = new System.Windows.Forms.Label();
            this.hindexLabel = new System.Windows.Forms.Label();
            this.citerperPaperLabel = new System.Windows.Forms.Label();
            this.citesperYearLabel = new System.Windows.Forms.Label();
            this.citationsLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.favouritesPanel = new System.Windows.Forms.Panel();
            this.recentSearchPanel = new System.Windows.Forms.Panel();
            this.recentListView = new System.Windows.Forms.ListView();
            this.recentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.recentButton = new System.Windows.Forms.Button();
            this.favouriteButton = new System.Windows.Forms.Button();
            this.favouritesTreeView = new System.Windows.Forms.TreeView();
            this.Suggestions = new System.Windows.Forms.GroupBox();
            this.authorsSuggestions = new System.Windows.Forms.ListView();
            this.Authors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.siteComboBox = new System.Windows.Forms.ComboBox();
            this.searchSiteLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.stopButton = new System.Windows.Forms.PictureBox();
            this.cachedListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.optionsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewCitationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouriteMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.recentMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.EndYear = new PubCite.NumericTextBox();
            this.StartYear = new PubCite.NumericTextBox();
            this.SearchPanel.SuspendLayout();
            this.progressPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsIcon)).BeginInit();
            this.resultsPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.graphsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphsCloseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphsChart)).BeginInit();
            this.resultsGroupBox.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsCloseIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.microsoftNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.googleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citeseerNumericUpDown)).BeginInit();
            this.CacheOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cacheNumericUpDown)).BeginInit();
            this.statisticsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.favouritesPanel.SuspendLayout();
            this.recentSearchPanel.SuspendLayout();
            this.Suggestions.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopButton)).BeginInit();
            this.optionsMenuStrip.SuspendLayout();
            this.favouriteMenuStrip.SuspendLayout();
            this.recentMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchPanel.Controls.Add(this.progressPanel);
            this.SearchPanel.Controls.Add(this.panel2);
            this.SearchPanel.Controls.Add(this.panel1);
            this.SearchPanel.Controls.Add(this.settingsIcon);
            this.SearchPanel.Controls.Add(this.label4);
            this.SearchPanel.Controls.Add(this.KeywordsTextBox);
            this.SearchPanel.Controls.Add(this.journalCheckBox);
            this.SearchPanel.Controls.Add(this.searchField);
            this.SearchPanel.Controls.Add(this.authorCheckBox);
            this.SearchPanel.Controls.Add(this.progressBar);
            this.SearchPanel.Controls.Add(this.EndYear);
            this.SearchPanel.Controls.Add(this.resultsPanel);
            this.SearchPanel.Controls.Add(this.StartYear);
            this.SearchPanel.Controls.Add(this.favouritesPanel);
            this.SearchPanel.Controls.Add(this.label2);
            this.SearchPanel.Controls.Add(this.label1);
            this.SearchPanel.Controls.Add(this.siteComboBox);
            this.SearchPanel.Controls.Add(this.searchSiteLabel);
            this.SearchPanel.Controls.Add(this.panel6);
            this.SearchPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.SearchPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(1038, 647);
            this.SearchPanel.TabIndex = 2;
            // 
            // progressPanel
            // 
            this.progressPanel.Controls.Add(this.label3);
            this.progressPanel.Location = new System.Drawing.Point(780, 72);
            this.progressPanel.Margin = new System.Windows.Forms.Padding(0);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(229, 10);
            this.progressPanel.TabIndex = 44;
            this.progressPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Please wait while we process your query...";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-28, 626);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 6);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Location = new System.Drawing.Point(-3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 5);
            this.panel1.TabIndex = 2;
            // 
            // settingsIcon
            // 
            this.settingsIcon.BackColor = System.Drawing.Color.LightGray;
            this.settingsIcon.Image = global::PubCite.Properties.Resources.settings;
            this.settingsIcon.Location = new System.Drawing.Point(969, 9);
            this.settingsIcon.Name = "settingsIcon";
            this.settingsIcon.Size = new System.Drawing.Size(25, 25);
            this.settingsIcon.TabIndex = 30;
            this.settingsIcon.TabStop = false;
            this.settingsIcon.Click += new System.EventHandler(this.settingsIcon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label4.Location = new System.Drawing.Point(427, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Advanced Search Filter :";
            // 
            // KeywordsTextBox
            // 
            this.KeywordsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.KeywordsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeywordsTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeywordsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.KeywordsTextBox.Location = new System.Drawing.Point(561, 38);
            this.KeywordsTextBox.Name = "KeywordsTextBox";
            this.KeywordsTextBox.Size = new System.Drawing.Size(362, 22);
            this.KeywordsTextBox.TabIndex = 26;
            this.toolTip.SetToolTip(this.KeywordsTextBox, "Add space separated keywords to add to your search");
            // 
            // journalCheckBox
            // 
            this.journalCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.journalCheckBox.AutoSize = true;
            this.journalCheckBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.journalCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.journalCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chocolate;
            this.journalCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.journalCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journalCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.journalCheckBox.Location = new System.Drawing.Point(67, 8);
            this.journalCheckBox.Name = "journalCheckBox";
            this.journalCheckBox.Size = new System.Drawing.Size(53, 23);
            this.journalCheckBox.TabIndex = 24;
            this.journalCheckBox.Text = "Journal";
            this.journalCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.journalCheckBox.UseVisualStyleBackColor = false;
            // 
            // searchField
            // 
            this.searchField.BackColor = System.Drawing.SystemColors.Window;
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchField.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.searchField.Location = new System.Drawing.Point(128, 9);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(795, 22);
            this.searchField.TabIndex = 1;
            // 
            // authorCheckBox
            // 
            this.authorCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.authorCheckBox.AutoSize = true;
            this.authorCheckBox.BackColor = System.Drawing.Color.LightGray;
            this.authorCheckBox.Checked = true;
            this.authorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.authorCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.authorCheckBox.FlatAppearance.BorderSize = 0;
            this.authorCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.authorCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.authorCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.authorCheckBox.Location = new System.Drawing.Point(11, 8);
            this.authorCheckBox.Name = "authorCheckBox";
            this.authorCheckBox.Size = new System.Drawing.Size(51, 23);
            this.authorCheckBox.TabIndex = 23;
            this.authorCheckBox.Text = "Author";
            this.authorCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.authorCheckBox.UseVisualStyleBackColor = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(128, 9);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(795, 22);
            this.progressBar.TabIndex = 0;
            // 
            // resultsPanel
            // 
            this.resultsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.resultsPanel.Controls.Add(this.panel4);
            this.resultsPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.resultsPanel.Location = new System.Drawing.Point(236, 88);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(776, 531);
            this.resultsPanel.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.graphsPanel);
            this.panel4.Controls.Add(this.resultsGroupBox);
            this.panel4.Controls.Add(this.statisticsGroupBox);
            this.panel4.Location = new System.Drawing.Point(4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(769, 534);
            this.panel4.TabIndex = 3;
            // 
            // graphsPanel
            // 
            this.graphsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphsPanel.Controls.Add(this.graphsCloseIcon);
            this.graphsPanel.Controls.Add(this.graphsChart);
            this.graphsPanel.Location = new System.Drawing.Point(5, -900);
            this.graphsPanel.Name = "graphsPanel";
            this.graphsPanel.Size = new System.Drawing.Size(746, 293);
            this.graphsPanel.TabIndex = 43;
            // 
            // graphsCloseIcon
            // 
            this.graphsCloseIcon.BackColor = System.Drawing.Color.White;
            this.graphsCloseIcon.Image = global::PubCite.Properties.Resources.close;
            this.graphsCloseIcon.Location = new System.Drawing.Point(721, 5);
            this.graphsCloseIcon.Name = "graphsCloseIcon";
            this.graphsCloseIcon.Size = new System.Drawing.Size(17, 22);
            this.graphsCloseIcon.TabIndex = 1;
            this.graphsCloseIcon.TabStop = false;
            this.graphsCloseIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // graphsChart
            // 
            chartArea2.Name = "ChartArea1";
            this.graphsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graphsChart.Legends.Add(legend2);
            this.graphsChart.Location = new System.Drawing.Point(3, 3);
            this.graphsChart.Name = "graphsChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graphsChart.Series.Add(series2);
            this.graphsChart.Size = new System.Drawing.Size(744, 287);
            this.graphsChart.TabIndex = 0;
            this.graphsChart.Text = "chart1";
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.resultsGroupBox.Controls.Add(this.arbitPanel);
            this.resultsGroupBox.Controls.Add(this.settingsPanel);
            this.resultsGroupBox.Controls.Add(this.authorResultsListView);
            this.resultsGroupBox.Controls.Add(this.journalResultsListView);
            this.resultsGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.resultsGroupBox.Location = new System.Drawing.Point(2, 102);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(752, 426);
            this.resultsGroupBox.TabIndex = 0;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "PUBLICATIONS";
            // 
            // arbitPanel
            // 
            this.arbitPanel.Location = new System.Drawing.Point(3, -3);
            this.arbitPanel.Name = "arbitPanel";
            this.arbitPanel.Size = new System.Drawing.Size(746, 2);
            this.arbitPanel.TabIndex = 42;
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.LightGray;
            this.settingsPanel.Controls.Add(this.settingsCloseIcon);
            this.settingsPanel.Controls.Add(this.settingsOk);
            this.settingsPanel.Controls.Add(this.groupBox1);
            this.settingsPanel.Controls.Add(this.CacheOptions);
            this.settingsPanel.Location = new System.Drawing.Point(100, -800);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(499, 319);
            this.settingsPanel.TabIndex = 41;
            // 
            // settingsCloseIcon
            // 
            this.settingsCloseIcon.Image = global::PubCite.Properties.Resources.close;
            this.settingsCloseIcon.Location = new System.Drawing.Point(472, 4);
            this.settingsCloseIcon.Name = "settingsCloseIcon";
            this.settingsCloseIcon.Size = new System.Drawing.Size(16, 15);
            this.settingsCloseIcon.TabIndex = 3;
            this.settingsCloseIcon.TabStop = false;
            this.settingsCloseIcon.Click += new System.EventHandler(this.settingsCloseIcon_Click);
            // 
            // settingsOk
            // 
            this.settingsOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsOk.Location = new System.Drawing.Point(202, 281);
            this.settingsOk.Name = "settingsOk";
            this.settingsOk.Size = new System.Drawing.Size(75, 23);
            this.settingsOk.TabIndex = 2;
            this.settingsOk.Text = "OK";
            this.settingsOk.UseVisualStyleBackColor = true;
            this.settingsOk.Click += new System.EventHandler(this.settingsOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.microsoftNumericUpDown);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.googleNumericUpDown);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.citeseerNumericUpDown);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(11, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query Options";
            // 
            // microsoftNumericUpDown
            // 
            this.microsoftNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.microsoftNumericUpDown.Location = new System.Drawing.Point(271, 109);
            this.microsoftNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.microsoftNumericUpDown.Name = "microsoftNumericUpDown";
            this.microsoftNumericUpDown.Size = new System.Drawing.Size(44, 22);
            this.microsoftNumericUpDown.TabIndex = 5;
            this.microsoftNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Limit Microsoft Academic Search Results to:";
            // 
            // googleNumericUpDown
            // 
            this.googleNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.googleNumericUpDown.Location = new System.Drawing.Point(271, 68);
            this.googleNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.googleNumericUpDown.Name = "googleNumericUpDown";
            this.googleNumericUpDown.Size = new System.Drawing.Size(44, 22);
            this.googleNumericUpDown.TabIndex = 3;
            this.googleNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(75, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Limit Google Scholar Results to:";
            // 
            // citeseerNumericUpDown
            // 
            this.citeseerNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.citeseerNumericUpDown.Location = new System.Drawing.Point(271, 28);
            this.citeseerNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.citeseerNumericUpDown.Name = "citeseerNumericUpDown";
            this.citeseerNumericUpDown.Size = new System.Drawing.Size(44, 22);
            this.citeseerNumericUpDown.TabIndex = 1;
            this.citeseerNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(110, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Limit CiteSeerX Results to:";
            // 
            // CacheOptions
            // 
            this.CacheOptions.Controls.Add(this.cacheNumericUpDown);
            this.CacheOptions.Controls.Add(this.CacheOptionslabel);
            this.CacheOptions.Location = new System.Drawing.Point(11, 28);
            this.CacheOptions.Name = "CacheOptions";
            this.CacheOptions.Size = new System.Drawing.Size(476, 63);
            this.CacheOptions.TabIndex = 0;
            this.CacheOptions.TabStop = false;
            this.CacheOptions.Text = "Results Caching";
            // 
            // cacheNumericUpDown
            // 
            this.cacheNumericUpDown.Location = new System.Drawing.Point(271, 26);
            this.cacheNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.cacheNumericUpDown.Name = "cacheNumericUpDown";
            this.cacheNumericUpDown.Size = new System.Drawing.Size(35, 22);
            this.cacheNumericUpDown.TabIndex = 1;
            this.cacheNumericUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // CacheOptionslabel
            // 
            this.CacheOptionslabel.AutoSize = true;
            this.CacheOptionslabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CacheOptionslabel.Location = new System.Drawing.Point(92, 28);
            this.CacheOptionslabel.Name = "CacheOptionslabel";
            this.CacheOptionslabel.Size = new System.Drawing.Size(160, 13);
            this.CacheOptionslabel.TabIndex = 0;
            this.CacheOptionslabel.Text = "Keep Cache These Many Days:";
            // 
            // authorResultsListView
            // 
            this.authorResultsListView.BackColor = System.Drawing.SystemColors.Window;
            this.authorResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PaperHeader,
            this.venueHeader,
            this.YearHeader,
            this.NumOfCitesHeader});
            this.authorResultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorResultsListView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorResultsListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.authorResultsListView.GridLines = true;
            this.authorResultsListView.Location = new System.Drawing.Point(3, 18);
            this.authorResultsListView.MultiSelect = false;
            this.authorResultsListView.Name = "authorResultsListView";
            this.authorResultsListView.Size = new System.Drawing.Size(746, 405);
            this.authorResultsListView.TabIndex = 1;
            this.authorResultsListView.UseCompatibleStateImageBehavior = false;
            this.authorResultsListView.View = System.Windows.Forms.View.Details;
            // 
            // PaperHeader
            // 
            this.PaperHeader.Text = "Paper";
            this.PaperHeader.Width = 358;
            // 
            // venueHeader
            // 
            this.venueHeader.Text = "Venue";
            this.venueHeader.Width = 243;
            // 
            // YearHeader
            // 
            this.YearHeader.Text = "Year";
            this.YearHeader.Width = 51;
            // 
            // NumOfCitesHeader
            // 
            this.NumOfCitesHeader.Text = "No.Of Cites";
            this.NumOfCitesHeader.Width = 77;
            // 
            // journalResultsListView
            // 
            this.journalResultsListView.BackColor = System.Drawing.SystemColors.Window;
            this.journalResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Paper,
            this.Author,
            this.Cites,
            this.Year});
            this.journalResultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journalResultsListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.journalResultsListView.GridLines = true;
            this.journalResultsListView.Location = new System.Drawing.Point(3, 18);
            this.journalResultsListView.MultiSelect = false;
            this.journalResultsListView.Name = "journalResultsListView";
            this.journalResultsListView.Size = new System.Drawing.Size(746, 405);
            this.journalResultsListView.TabIndex = 0;
            this.journalResultsListView.UseCompatibleStateImageBehavior = false;
            this.journalResultsListView.View = System.Windows.Forms.View.Details;
            this.journalResultsListView.Visible = false;
            // 
            // Paper
            // 
            this.Paper.Text = "Paper";
            this.Paper.Width = 407;
            // 
            // Author
            // 
            this.Author.Text = "Author(s)";
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
            this.Year.Width = 87;
            // 
            // statisticsGroupBox
            // 
            this.statisticsGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statisticsGroupBox.Controls.Add(this.addToFav);
            this.statisticsGroupBox.Controls.Add(this.pictureBox1);
            this.statisticsGroupBox.Controls.Add(this.graphComboBox);
            this.statisticsGroupBox.Controls.Add(this.label16);
            this.statisticsGroupBox.Controls.Add(this.numPapers);
            this.statisticsGroupBox.Controls.Add(this.label15);
            this.statisticsGroupBox.Controls.Add(this.label5);
            this.statisticsGroupBox.Controls.Add(this.label6);
            this.statisticsGroupBox.Controls.Add(this.label7);
            this.statisticsGroupBox.Controls.Add(this.label8);
            this.statisticsGroupBox.Controls.Add(this.label9);
            this.statisticsGroupBox.Controls.Add(this.label10);
            this.statisticsGroupBox.Controls.Add(this.i10index);
            this.statisticsGroupBox.Controls.Add(this.hindex);
            this.statisticsGroupBox.Controls.Add(this.citesperPaper);
            this.statisticsGroupBox.Controls.Add(this.citesperYear);
            this.statisticsGroupBox.Controls.Add(this.citationsNumberLabel);
            this.statisticsGroupBox.Controls.Add(this.authorNameLabel);
            this.statisticsGroupBox.Controls.Add(this.i10indexLabel);
            this.statisticsGroupBox.Controls.Add(this.hindexLabel);
            this.statisticsGroupBox.Controls.Add(this.citerperPaperLabel);
            this.statisticsGroupBox.Controls.Add(this.citesperYearLabel);
            this.statisticsGroupBox.Controls.Add(this.citationsLabel);
            this.statisticsGroupBox.Controls.Add(this.authorLabel);
            this.statisticsGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.statisticsGroupBox.Location = new System.Drawing.Point(2, 3);
            this.statisticsGroupBox.Name = "statisticsGroupBox";
            this.statisticsGroupBox.Size = new System.Drawing.Size(752, 93);
            this.statisticsGroupBox.TabIndex = 2;
            this.statisticsGroupBox.TabStop = false;
            this.statisticsGroupBox.Text = "STATISTICS";
            // 
            // addToFav
            // 
            this.addToFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToFav.Location = new System.Drawing.Point(629, 64);
            this.addToFav.Name = "addToFav";
            this.addToFav.Size = new System.Drawing.Size(105, 23);
            this.addToFav.TabIndex = 39;
            this.addToFav.Text = "Add to Favourite";
            this.addToFav.UseVisualStyleBackColor = true;
            this.addToFav.Click += new System.EventHandler(this.addToFav_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PubCite.Properties.Resources.bar_chart_2;
            this.pictureBox1.Location = new System.Drawing.Point(219, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // graphComboBox
            // 
            this.graphComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.graphComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.graphComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.graphComboBox.FormattingEnabled = true;
            this.graphComboBox.Items.AddRange(new object[] {
            "Citations of Publications Per Year",
            "Publications Per Year"});
            this.graphComboBox.Location = new System.Drawing.Point(13, 69);
            this.graphComboBox.Name = "graphComboBox";
            this.graphComboBox.Size = new System.Drawing.Size(200, 21);
            this.graphComboBox.TabIndex = 37;
            this.graphComboBox.SelectedIndexChanged += new System.EventHandler(this.graphComboBox_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(547, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(10, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = ":";
            // 
            // numPapers
            // 
            this.numPapers.AutoSize = true;
            this.numPapers.Location = new System.Drawing.Point(563, 18);
            this.numPapers.Name = "numPapers";
            this.numPapers.Size = new System.Drawing.Size(0, 13);
            this.numPapers.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(445, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Number of Papers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(682, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(547, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(316, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(60, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = ":";
            // 
            // i10index
            // 
            this.i10index.AutoSize = true;
            this.i10index.Location = new System.Drawing.Point(693, 37);
            this.i10index.Name = "i10index";
            this.i10index.Size = new System.Drawing.Size(0, 13);
            this.i10index.TabIndex = 20;
            // 
            // hindex
            // 
            this.hindex.AutoSize = true;
            this.hindex.Location = new System.Drawing.Point(559, 39);
            this.hindex.Name = "hindex";
            this.hindex.Size = new System.Drawing.Size(0, 13);
            this.hindex.TabIndex = 19;
            // 
            // citesperPaper
            // 
            this.citesperPaper.AutoSize = true;
            this.citesperPaper.Location = new System.Drawing.Point(328, 18);
            this.citesperPaper.Name = "citesperPaper";
            this.citesperPaper.Size = new System.Drawing.Size(0, 13);
            this.citesperPaper.TabIndex = 18;
            // 
            // citesperYear
            // 
            this.citesperYear.AutoSize = true;
            this.citesperYear.Location = new System.Drawing.Point(328, 39);
            this.citesperYear.Name = "citesperYear";
            this.citesperYear.Size = new System.Drawing.Size(0, 13);
            this.citesperYear.TabIndex = 17;
            // 
            // citationsNumberLabel
            // 
            this.citationsNumberLabel.AutoSize = true;
            this.citationsNumberLabel.Location = new System.Drawing.Point(71, 38);
            this.citationsNumberLabel.Name = "citationsNumberLabel";
            this.citationsNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.citationsNumberLabel.TabIndex = 16;
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.authorNameLabel.Location = new System.Drawing.Point(71, 16);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(0, 13);
            this.authorNameLabel.TabIndex = 15;
            this.toolTip.SetToolTip(this.authorNameLabel, "Click to View Home Page");
            this.authorNameLabel.Click += new System.EventHandler(this.authorNameLabel_Click);
            // 
            // i10indexLabel
            // 
            this.i10indexLabel.AutoSize = true;
            this.i10indexLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i10indexLabel.Location = new System.Drawing.Point(626, 37);
            this.i10indexLabel.Name = "i10indexLabel";
            this.i10indexLabel.Size = new System.Drawing.Size(55, 13);
            this.i10indexLabel.TabIndex = 13;
            this.i10indexLabel.Text = "i10-index";
            // 
            // hindexLabel
            // 
            this.hindexLabel.AutoSize = true;
            this.hindexLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hindexLabel.Location = new System.Drawing.Point(445, 37);
            this.hindexLabel.Name = "hindexLabel";
            this.hindexLabel.Size = new System.Drawing.Size(47, 13);
            this.hindexLabel.TabIndex = 12;
            this.hindexLabel.Text = "h-index";
            // 
            // citerperPaperLabel
            // 
            this.citerperPaperLabel.AutoSize = true;
            this.citerperPaperLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citerperPaperLabel.Location = new System.Drawing.Point(234, 16);
            this.citerperPaperLabel.Name = "citerperPaperLabel";
            this.citerperPaperLabel.Size = new System.Drawing.Size(85, 13);
            this.citerperPaperLabel.TabIndex = 11;
            this.citerperPaperLabel.Text = "Cites per paper";
            // 
            // citesperYearLabel
            // 
            this.citesperYearLabel.AutoSize = true;
            this.citesperYearLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citesperYearLabel.Location = new System.Drawing.Point(234, 37);
            this.citesperYearLabel.Name = "citesperYearLabel";
            this.citesperYearLabel.Size = new System.Drawing.Size(77, 13);
            this.citesperYearLabel.TabIndex = 10;
            this.citesperYearLabel.Text = "Cites per year";
            // 
            // citationsLabel
            // 
            this.citationsLabel.AutoSize = true;
            this.citationsLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citationsLabel.Location = new System.Drawing.Point(10, 38);
            this.citationsLabel.Name = "citationsLabel";
            this.citationsLabel.Size = new System.Drawing.Size(53, 13);
            this.citationsLabel.TabIndex = 9;
            this.citationsLabel.Text = "Citations";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(10, 16);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 8;
            this.authorLabel.Text = "Name";
            // 
            // favouritesPanel
            // 
            this.favouritesPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.favouritesPanel.Controls.Add(this.recentSearchPanel);
            this.favouritesPanel.Controls.Add(this.recentButton);
            this.favouritesPanel.Controls.Add(this.favouriteButton);
            this.favouritesPanel.Controls.Add(this.favouritesTreeView);
            this.favouritesPanel.Controls.Add(this.Suggestions);
            this.favouritesPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.favouritesPanel.Location = new System.Drawing.Point(8, 88);
            this.favouritesPanel.Name = "favouritesPanel";
            this.favouritesPanel.Size = new System.Drawing.Size(222, 540);
            this.favouritesPanel.TabIndex = 0;
            // 
            // recentSearchPanel
            // 
            this.recentSearchPanel.Controls.Add(this.recentListView);
            this.recentSearchPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentSearchPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.recentSearchPanel.Location = new System.Drawing.Point(-250, 43);
            this.recentSearchPanel.Name = "recentSearchPanel";
            this.recentSearchPanel.Size = new System.Drawing.Size(192, 209);
            this.recentSearchPanel.TabIndex = 1;
            // 
            // recentListView
            // 
            this.recentListView.BackColor = System.Drawing.SystemColors.Window;
            this.recentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.recentHeader,
            this.typeHeader});
            this.recentListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.recentListView.GridLines = true;
            this.recentListView.Location = new System.Drawing.Point(0, 0);
            this.recentListView.Name = "recentListView";
            this.recentListView.Size = new System.Drawing.Size(192, 209);
            this.recentListView.TabIndex = 0;
            this.recentListView.UseCompatibleStateImageBehavior = false;
            this.recentListView.View = System.Windows.Forms.View.Details;
            // 
            // recentHeader
            // 
            this.recentHeader.Text = "History";
            this.recentHeader.Width = 134;
            // 
            // typeHeader
            // 
            this.typeHeader.Text = "Type";
            this.typeHeader.Width = 56;
            // 
            // recentButton
            // 
            this.recentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recentButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.recentButton.Location = new System.Drawing.Point(77, 6);
            this.recentButton.Name = "recentButton";
            this.recentButton.Size = new System.Drawing.Size(83, 29);
            this.recentButton.TabIndex = 11;
            this.recentButton.Text = "Recent";
            this.recentButton.UseVisualStyleBackColor = true;
            this.recentButton.Click += new System.EventHandler(this.recentButton_Click);
            // 
            // favouriteButton
            // 
            this.favouriteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.favouriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favouriteButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favouriteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.favouriteButton.Location = new System.Drawing.Point(7, 6);
            this.favouriteButton.Name = "favouriteButton";
            this.favouriteButton.Size = new System.Drawing.Size(70, 29);
            this.favouriteButton.TabIndex = 10;
            this.favouriteButton.Text = "Favourite";
            this.favouriteButton.UseVisualStyleBackColor = true;
            this.favouriteButton.Click += new System.EventHandler(this.favouriteButton_Click);
            // 
            // favouritesTreeView
            // 
            this.favouritesTreeView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.favouritesTreeView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favouritesTreeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.favouritesTreeView.Location = new System.Drawing.Point(11, 43);
            this.favouritesTreeView.Name = "favouritesTreeView";
            treeNode4.Name = "authorsRootNode";
            treeNode4.Text = "Authors";
            treeNode5.Name = "journalsRootNode";
            treeNode5.Text = "Journals";
            treeNode6.Name = "Favourites";
            treeNode6.Text = "Favourites";
            this.favouritesTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.favouritesTreeView.Size = new System.Drawing.Size(192, 209);
            this.favouritesTreeView.TabIndex = 9;
            // 
            // Suggestions
            // 
            this.Suggestions.Controls.Add(this.authorsSuggestions);
            this.Suggestions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suggestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.Suggestions.Location = new System.Drawing.Point(11, 258);
            this.Suggestions.Name = "Suggestions";
            this.Suggestions.Size = new System.Drawing.Size(192, 273);
            this.Suggestions.TabIndex = 8;
            this.Suggestions.TabStop = false;
            this.Suggestions.Text = "Suggestions";
            // 
            // authorsSuggestions
            // 
            this.authorsSuggestions.BackColor = System.Drawing.SystemColors.Window;
            this.authorsSuggestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Authors});
            this.authorsSuggestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorsSuggestions.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorsSuggestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.authorsSuggestions.GridLines = true;
            this.authorsSuggestions.Location = new System.Drawing.Point(3, 18);
            this.authorsSuggestions.Name = "authorsSuggestions";
            this.authorsSuggestions.Size = new System.Drawing.Size(186, 252);
            this.authorsSuggestions.TabIndex = 0;
            this.authorsSuggestions.UseCompatibleStateImageBehavior = false;
            this.authorsSuggestions.View = System.Windows.Forms.View.Details;
            // 
            // Authors
            // 
            this.Authors.Text = "Authors";
            this.Authors.Width = 186;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label2.Location = new System.Drawing.Point(343, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label1.Location = new System.Drawing.Point(246, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "From:";
            // 
            // siteComboBox
            // 
            this.siteComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.siteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siteComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.siteComboBox.FormattingEnabled = true;
            this.siteComboBox.Items.AddRange(new object[] {
            "Google Scholar",
            "CiteSeerX",
            "Microsoft Academic Search"});
            this.siteComboBox.Location = new System.Drawing.Point(85, 38);
            this.siteComboBox.Name = "siteComboBox";
            this.siteComboBox.Size = new System.Drawing.Size(145, 21);
            this.siteComboBox.TabIndex = 6;
            // 
            // searchSiteLabel
            // 
            this.searchSiteLabel.BackColor = System.Drawing.Color.LightGray;
            this.searchSiteLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSiteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.searchSiteLabel.Location = new System.Drawing.Point(12, 41);
            this.searchSiteLabel.Name = "searchSiteLabel";
            this.searchSiteLabel.Size = new System.Drawing.Size(69, 21);
            this.searchSiteLabel.TabIndex = 3;
            this.searchSiteLabel.Text = "Search Site :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.searchIcon);
            this.panel6.Controls.Add(this.stopButton);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1015, 64);
            this.panel6.TabIndex = 43;
            // 
            // searchIcon
            // 
            this.searchIcon.BackColor = System.Drawing.Color.LightGray;
            this.searchIcon.Image = global::PubCite.Properties.Resources.search_button2;
            this.searchIcon.Location = new System.Drawing.Point(937, 9);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(24, 29);
            this.searchIcon.TabIndex = 11;
            this.searchIcon.TabStop = false;
            this.toolTip.SetToolTip(this.searchIcon, "Search..");
            this.searchIcon.Click += new System.EventHandler(this.searchIcon_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.LightGray;
            this.stopButton.Image = global::PubCite.Properties.Resources.icon_pause1;
            this.stopButton.Location = new System.Drawing.Point(937, 8);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(25, 25);
            this.stopButton.TabIndex = 31;
            this.stopButton.TabStop = false;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // cachedListView
            // 
            this.cachedListView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cachedListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cachedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.cachedListView.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cachedListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.cachedListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.cachedListView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cachedListView.Location = new System.Drawing.Point(129, 31);
            this.cachedListView.Name = "cachedListView";
            this.cachedListView.Size = new System.Drawing.Size(795, 97);
            this.cachedListView.TabIndex = 29;
            this.cachedListView.UseCompatibleStateImageBehavior = false;
            this.cachedListView.View = System.Windows.Forms.View.Details;
            this.cachedListView.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 461;
            // 
            // optionsMenuStrip
            // 
            this.optionsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCitationsToolStripMenuItem,
            this.viewURLToolStripMenuItem});
            this.optionsMenuStrip.Name = "optionsMenuStrip";
            this.optionsMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.optionsMenuStrip.Size = new System.Drawing.Size(150, 48);
            // 
            // viewCitationsToolStripMenuItem
            // 
            this.viewCitationsToolStripMenuItem.Name = "viewCitationsToolStripMenuItem";
            this.viewCitationsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewCitationsToolStripMenuItem.Text = "View Citations";
            this.viewCitationsToolStripMenuItem.Click += new System.EventHandler(this.viewCitationsToolStripMenuItem_Click);
            // 
            // viewURLToolStripMenuItem
            // 
            this.viewURLToolStripMenuItem.Name = "viewURLToolStripMenuItem";
            this.viewURLToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewURLToolStripMenuItem.Text = "View Url";
            this.viewURLToolStripMenuItem.Click += new System.EventHandler(this.viewURLToolStripMenuItem_Click);
            // 
            // favouriteMenuStrip
            // 
            this.favouriteMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStatisticsToolStripMenuItem,
            this.removeFromFavouritesToolStripMenuItem,
            this.clearFavouritesToolStripMenuItem});
            this.favouriteMenuStrip.Name = "favouriteMenuStrip";
            this.favouriteMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.favouriteMenuStrip.Size = new System.Drawing.Size(204, 70);
            // 
            // viewStatisticsToolStripMenuItem
            // 
            this.viewStatisticsToolStripMenuItem.Name = "viewStatisticsToolStripMenuItem";
            this.viewStatisticsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.viewStatisticsToolStripMenuItem.Text = "View Statistics";
            this.viewStatisticsToolStripMenuItem.Click += new System.EventHandler(this.viewStatisticsToolStripMenuItem_Click);
            // 
            // removeFromFavouritesToolStripMenuItem
            // 
            this.removeFromFavouritesToolStripMenuItem.Name = "removeFromFavouritesToolStripMenuItem";
            this.removeFromFavouritesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.removeFromFavouritesToolStripMenuItem.Text = "Remove from Favourites";
            this.removeFromFavouritesToolStripMenuItem.Click += new System.EventHandler(this.removeFromFavouritesToolStripMenuItem_Click);
            // 
            // clearFavouritesToolStripMenuItem
            // 
            this.clearFavouritesToolStripMenuItem.Name = "clearFavouritesToolStripMenuItem";
            this.clearFavouritesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.clearFavouritesToolStripMenuItem.Text = "Clear Favourites";
            this.clearFavouritesToolStripMenuItem.Click += new System.EventHandler(this.clearFavouritesToolStripMenuItem_Click);
            // 
            // recentMenuStrip
            // 
            this.recentMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.clearHistoryToolStripMenuItem});
            this.recentMenuStrip.Name = "recentMenuStrip";
            this.recentMenuStrip.Size = new System.Drawing.Size(143, 48);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.clearHistoryToolStripMenuItem.Text = "Clear History";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // EndYear
            // 
            this.EndYear.AllowSpace = false;
            this.EndYear.BackColor = System.Drawing.SystemColors.Window;
            this.EndYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EndYear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.EndYear.Location = new System.Drawing.Point(371, 38);
            this.EndYear.Name = "EndYear";
            this.EndYear.Size = new System.Drawing.Size(44, 22);
            this.EndYear.TabIndex = 0;
            this.toolTip.SetToolTip(this.EndYear, "End Year");
            this.EndYear.TextChanged += new System.EventHandler(this.EndYear_TextChanged);
            // 
            // StartYear
            // 
            this.StartYear.AllowSpace = false;
            this.StartYear.BackColor = System.Drawing.SystemColors.Window;
            this.StartYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartYear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.StartYear.Location = new System.Drawing.Point(288, 38);
            this.StartYear.Name = "StartYear";
            this.StartYear.Size = new System.Drawing.Size(44, 22);
            this.StartYear.TabIndex = 0;
            this.toolTip.SetToolTip(this.StartYear, "Start Year");
            this.StartYear.TextChanged += new System.EventHandler(this.StartYear_TextChanged);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cachedListView);
            this.Controls.Add(this.SearchPanel);
            this.Name = "search";
            this.Size = new System.Drawing.Size(1015, 631);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsIcon)).EndInit();
            this.resultsPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.graphsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphsCloseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphsChart)).EndInit();
            this.resultsGroupBox.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsCloseIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.microsoftNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.googleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citeseerNumericUpDown)).EndInit();
            this.CacheOptions.ResumeLayout(false);
            this.CacheOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cacheNumericUpDown)).EndInit();
            this.statisticsGroupBox.ResumeLayout(false);
            this.statisticsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.favouritesPanel.ResumeLayout(false);
            this.recentSearchPanel.ResumeLayout(false);
            this.Suggestions.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopButton)).EndInit();
            this.optionsMenuStrip.ResumeLayout(false);
            this.favouriteMenuStrip.ResumeLayout(false);
            this.recentMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Panel resultsPanel;
        private System.Windows.Forms.GroupBox statisticsGroupBox;
        private System.Windows.Forms.Label i10indexLabel;
        private System.Windows.Forms.Label hindexLabel;
        private System.Windows.Forms.Label citerperPaperLabel;
        private System.Windows.Forms.Label citesperYearLabel;
        private System.Windows.Forms.Label citationsLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Panel favouritesPanel;
        private System.Windows.Forms.ComboBox siteComboBox;
        private System.Windows.Forms.Label searchSiteLabel;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Suggestions;
        private System.Windows.Forms.ListView authorsSuggestions;
        private System.Windows.Forms.ColumnHeader Authors;
        private System.Windows.Forms.Label i10index;
        private System.Windows.Forms.Label hindex;
        private System.Windows.Forms.Label citesperPaper;
        private System.Windows.Forms.Label citesperYear;
        private System.Windows.Forms.Label citationsNumberLabel;
        private System.Windows.Forms.Label authorNameLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.ListView journalResultsListView;
        private System.Windows.Forms.ColumnHeader Paper;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Cites;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ListView authorResultsListView;
        private System.Windows.Forms.ColumnHeader PaperHeader;
        private System.Windows.Forms.ColumnHeader YearHeader;
        private System.Windows.Forms.ColumnHeader NumOfCitesHeader;
        private NumericTextBox StartYear;
        private NumericTextBox EndYear;
        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.ColumnHeader venueHeader;
        private System.Windows.Forms.ContextMenuStrip optionsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewCitationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewURLToolStripMenuItem;
        private System.Windows.Forms.TreeView favouritesTreeView;
        private System.Windows.Forms.ContextMenuStrip favouriteMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFromFavouritesToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox authorCheckBox;
        private System.Windows.Forms.CheckBox journalCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KeywordsTextBox;
        private System.Windows.Forms.ListView cachedListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox settingsIcon;
        private System.Windows.Forms.Panel recentSearchPanel;
        private System.Windows.Forms.Button recentButton;
        private System.Windows.Forms.Button favouriteButton;
        private System.Windows.Forms.ListView recentListView;
        private System.Windows.Forms.ColumnHeader recentHeader;
        private System.Windows.Forms.PictureBox stopButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Button settingsOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown microsoftNumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown googleNumericUpDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown citeseerNumericUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox CacheOptions;
        private System.Windows.Forms.NumericUpDown cacheNumericUpDown;
        private System.Windows.Forms.Label CacheOptionslabel;
        private System.Windows.Forms.PictureBox settingsCloseIcon;
        private System.Windows.Forms.Panel arbitPanel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label numPapers;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ColumnHeader typeHeader;
        private System.Windows.Forms.ContextMenuStrip recentMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFavouritesToolStripMenuItem;
        private System.Windows.Forms.ComboBox graphComboBox;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel graphsPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphsChart;
        private System.Windows.Forms.PictureBox graphsCloseIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel progressPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addToFav;
    }
}
