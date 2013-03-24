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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Authors");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Journals");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Favourites", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.cachedListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.affiliation = new System.Windows.Forms.Label();
            this.KeywordsTextBox = new System.Windows.Forms.TextBox();
            this.affilationTextBox = new System.Windows.Forms.TextBox();
            this.journalCheckBox = new System.Windows.Forms.CheckBox();
            this.searchField = new System.Windows.Forms.TextBox();
            this.authorCheckBox = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.addToFavourite = new System.Windows.Forms.PictureBox();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.i10index = new System.Windows.Forms.Label();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
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
            this.favouritesTreeView = new System.Windows.Forms.TreeView();
            this.Suggestions = new System.Windows.Forms.GroupBox();
            this.authorsSuggestions = new System.Windows.Forms.ListView();
            this.Authors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.siteComboBox = new System.Windows.Forms.ComboBox();
            this.searchSiteLabel = new System.Windows.Forms.Label();
            this.optionsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewCitationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouriteMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.EndYear = new PubCite.NumericTextBox();
            this.StartYear = new PubCite.NumericTextBox();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addToFavourite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.resultsPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.statisticsGroupBox.SuspendLayout();
            this.progressPanel.SuspendLayout();
            this.favouritesPanel.SuspendLayout();
            this.Suggestions.SuspendLayout();
            this.optionsMenuStrip.SuspendLayout();
            this.favouriteMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.SystemColors.Window;
            this.SearchPanel.Controls.Add(this.label4);
            this.SearchPanel.Controls.Add(this.affiliation);
            this.SearchPanel.Controls.Add(this.KeywordsTextBox);
            this.SearchPanel.Controls.Add(this.affilationTextBox);
            this.SearchPanel.Controls.Add(this.journalCheckBox);
            this.SearchPanel.Controls.Add(this.searchField);
            this.SearchPanel.Controls.Add(this.authorCheckBox);
            this.SearchPanel.Controls.Add(this.progressBar);
            this.SearchPanel.Controls.Add(this.addToFavourite);
            this.SearchPanel.Controls.Add(this.searchIcon);
            this.SearchPanel.Controls.Add(this.EndYear);
            this.SearchPanel.Controls.Add(this.resultsPanel);
            this.SearchPanel.Controls.Add(this.StartYear);
            this.SearchPanel.Controls.Add(this.favouritesPanel);
            this.SearchPanel.Controls.Add(this.label2);
            this.SearchPanel.Controls.Add(this.label1);
            this.SearchPanel.Controls.Add(this.siteComboBox);
            this.SearchPanel.Controls.Add(this.searchSiteLabel);
            this.SearchPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPanel.Location = new System.Drawing.Point(10, 3);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(979, 595);
            this.SearchPanel.TabIndex = 2;
            // 
            // cachedListView
            // 
            this.cachedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.cachedListView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cachedListView.Location = new System.Drawing.Point(-123, 42);
            this.cachedListView.Name = "cachedListView";
            this.cachedListView.Size = new System.Drawing.Size(771, 97);
            this.cachedListView.TabIndex = 29;
            this.cachedListView.UseCompatibleStateImageBehavior = false;
            this.cachedListView.View = System.Windows.Forms.View.Details;
            this.cachedListView.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 461;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(703, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Keywords:";
            // 
            // affiliation
            // 
            this.affiliation.AutoSize = true;
            this.affiliation.Location = new System.Drawing.Point(493, 36);
            this.affiliation.Name = "affiliation";
            this.affiliation.Size = new System.Drawing.Size(61, 13);
            this.affiliation.TabIndex = 27;
            this.affiliation.Text = "Affiliation:";
            // 
            // KeywordsTextBox
            // 
            this.KeywordsTextBox.Location = new System.Drawing.Point(768, 35);
            this.KeywordsTextBox.Name = "KeywordsTextBox";
            this.KeywordsTextBox.Size = new System.Drawing.Size(105, 22);
            this.KeywordsTextBox.TabIndex = 26;
            this.toolTip.SetToolTip(this.KeywordsTextBox, "Add space separated keywords to add to your search");
            // 
            // affilationTextBox
            // 
            this.affilationTextBox.Location = new System.Drawing.Point(572, 32);
            this.affilationTextBox.Name = "affilationTextBox";
            this.affilationTextBox.Size = new System.Drawing.Size(105, 22);
            this.affilationTextBox.TabIndex = 25;
            this.toolTip.SetToolTip(this.affilationTextBox, "Affiliation/ISSN Number");
            // 
            // journalCheckBox
            // 
            this.journalCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.journalCheckBox.AutoSize = true;
            this.journalCheckBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.journalCheckBox.FlatAppearance.BorderSize = 0;
            this.journalCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chocolate;
            this.journalCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.journalCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.journalCheckBox.Location = new System.Drawing.Point(67, 2);
            this.journalCheckBox.Name = "journalCheckBox";
            this.journalCheckBox.Size = new System.Drawing.Size(55, 23);
            this.journalCheckBox.TabIndex = 24;
            this.journalCheckBox.Text = "Journal";
            this.journalCheckBox.UseVisualStyleBackColor = false;
            // 
            // searchField
            // 
            this.searchField.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchField.Location = new System.Drawing.Point(128, 3);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(771, 22);
            this.searchField.TabIndex = 1;
            // 
            // authorCheckBox
            // 
            this.authorCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.authorCheckBox.AutoSize = true;
            this.authorCheckBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.authorCheckBox.Checked = true;
            this.authorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.authorCheckBox.FlatAppearance.BorderSize = 0;
            this.authorCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chocolate;
            this.authorCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.authorCheckBox.Location = new System.Drawing.Point(15, 2);
            this.authorCheckBox.Name = "authorCheckBox";
            this.authorCheckBox.Size = new System.Drawing.Size(53, 23);
            this.authorCheckBox.TabIndex = 23;
            this.authorCheckBox.Text = "Author";
            this.authorCheckBox.UseVisualStyleBackColor = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(128, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(771, 22);
            this.progressBar.TabIndex = 0;
            // 
            // addToFavourite
            // 
            this.addToFavourite.Image = global::PubCite.Properties.Resources.star;
            this.addToFavourite.Location = new System.Drawing.Point(939, 0);
            this.addToFavourite.Name = "addToFavourite";
            this.addToFavourite.Size = new System.Drawing.Size(25, 28);
            this.addToFavourite.TabIndex = 21;
            this.addToFavourite.TabStop = false;
            this.toolTip.SetToolTip(this.addToFavourite, "Add to Favourite");
            this.addToFavourite.Click += new System.EventHandler(this.addToFavourite_Click);
            // 
            // searchIcon
            // 
            this.searchIcon.Image = global::PubCite.Properties.Resources.search_button2;
            this.searchIcon.Location = new System.Drawing.Point(909, 0);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(24, 28);
            this.searchIcon.TabIndex = 11;
            this.searchIcon.TabStop = false;
            this.toolTip.SetToolTip(this.searchIcon, "Search..");
            this.searchIcon.Click += new System.EventHandler(this.searchIcon_Click);
            // 
            // resultsPanel
            // 
            this.resultsPanel.BackColor = System.Drawing.SystemColors.Window;
            this.resultsPanel.Controls.Add(this.panel4);
            this.resultsPanel.Location = new System.Drawing.Point(236, 88);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(745, 504);
            this.resultsPanel.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.resultsGroupBox);
            this.panel4.Controls.Add(this.statisticsGroupBox);
            this.panel4.Location = new System.Drawing.Point(4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(736, 496);
            this.panel4.TabIndex = 3;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.cachedListView);
            this.resultsGroupBox.Controls.Add(this.authorResultsListView);
            this.resultsGroupBox.Controls.Add(this.journalResultsListView);
            this.resultsGroupBox.Location = new System.Drawing.Point(2, 88);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(731, 408);
            this.resultsGroupBox.TabIndex = 0;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results ";
            // 
            // authorResultsListView
            // 
            this.authorResultsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.authorResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PaperHeader,
            this.venueHeader,
            this.YearHeader,
            this.NumOfCitesHeader});
            this.authorResultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorResultsListView.GridLines = true;
            this.authorResultsListView.Location = new System.Drawing.Point(3, 18);
            this.authorResultsListView.MultiSelect = false;
            this.authorResultsListView.Name = "authorResultsListView";
            this.authorResultsListView.Size = new System.Drawing.Size(725, 387);
            this.authorResultsListView.TabIndex = 1;
            this.authorResultsListView.UseCompatibleStateImageBehavior = false;
            this.authorResultsListView.View = System.Windows.Forms.View.Details;
            // 
            // PaperHeader
            // 
            this.PaperHeader.Text = "Paper";
            this.PaperHeader.Width = 403;
            // 
            // venueHeader
            // 
            this.venueHeader.Text = "Venue";
            this.venueHeader.Width = 170;
            // 
            // YearHeader
            // 
            this.YearHeader.Text = "Year";
            this.YearHeader.Width = 63;
            // 
            // NumOfCitesHeader
            // 
            this.NumOfCitesHeader.Text = "No.Of Cites";
            this.NumOfCitesHeader.Width = 86;
            // 
            // journalResultsListView
            // 
            this.journalResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Paper,
            this.Author,
            this.Cites,
            this.Year});
            this.journalResultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journalResultsListView.GridLines = true;
            this.journalResultsListView.Location = new System.Drawing.Point(3, 18);
            this.journalResultsListView.MultiSelect = false;
            this.journalResultsListView.Name = "journalResultsListView";
            this.journalResultsListView.Size = new System.Drawing.Size(725, 387);
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
            this.Year.Width = 66;
            // 
            // statisticsGroupBox
            // 
            this.statisticsGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.statisticsGroupBox.Controls.Add(this.label5);
            this.statisticsGroupBox.Controls.Add(this.label6);
            this.statisticsGroupBox.Controls.Add(this.label7);
            this.statisticsGroupBox.Controls.Add(this.label8);
            this.statisticsGroupBox.Controls.Add(this.label9);
            this.statisticsGroupBox.Controls.Add(this.label10);
            this.statisticsGroupBox.Controls.Add(this.i10index);
            this.statisticsGroupBox.Controls.Add(this.progressPanel);
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
            this.statisticsGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsGroupBox.Location = new System.Drawing.Point(8, 3);
            this.statisticsGroupBox.Name = "statisticsGroupBox";
            this.statisticsGroupBox.Size = new System.Drawing.Size(722, 79);
            this.statisticsGroupBox.TabIndex = 2;
            this.statisticsGroupBox.TabStop = false;
            this.statisticsGroupBox.Text = "Statistics";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(309, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(309, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = ":";
            // 
            // i10index
            // 
            this.i10index.AutoSize = true;
            this.i10index.Location = new System.Drawing.Point(64, 60);
            this.i10index.Name = "i10index";
            this.i10index.Size = new System.Drawing.Size(22, 13);
            this.i10index.TabIndex = 20;
            this.i10index.Text = "i10";
            // 
            // progressPanel
            // 
            this.progressPanel.Controls.Add(this.label3);
            this.progressPanel.Location = new System.Drawing.Point(421, 50);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(295, 29);
            this.progressPanel.TabIndex = 22;
            this.progressPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Please wait while we process your query...";
            // 
            // hindex
            // 
            this.hindex.AutoSize = true;
            this.hindex.Location = new System.Drawing.Point(321, 60);
            this.hindex.Name = "hindex";
            this.hindex.Size = new System.Drawing.Size(14, 13);
            this.hindex.TabIndex = 19;
            this.hindex.Text = "h";
            // 
            // citesperPaper
            // 
            this.citesperPaper.AutoSize = true;
            this.citesperPaper.Location = new System.Drawing.Point(321, 18);
            this.citesperPaper.Name = "citesperPaper";
            this.citesperPaper.Size = new System.Drawing.Size(26, 13);
            this.citesperPaper.TabIndex = 18;
            this.citesperPaper.Text = "cpp";
            // 
            // citesperYear
            // 
            this.citesperYear.AutoSize = true;
            this.citesperYear.Location = new System.Drawing.Point(321, 39);
            this.citesperYear.Name = "citesperYear";
            this.citesperYear.Size = new System.Drawing.Size(24, 13);
            this.citesperYear.TabIndex = 17;
            this.citesperYear.Text = "cpy";
            // 
            // citationsNumberLabel
            // 
            this.citationsNumberLabel.AutoSize = true;
            this.citationsNumberLabel.Location = new System.Drawing.Point(64, 38);
            this.citationsNumberLabel.Name = "citationsNumberLabel";
            this.citationsNumberLabel.Size = new System.Drawing.Size(61, 13);
            this.citationsNumberLabel.TabIndex = 16;
            this.citationsNumberLabel.Text = "# citations";
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.authorNameLabel.Location = new System.Drawing.Point(64, 16);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(36, 13);
            this.authorNameLabel.TabIndex = 15;
            this.authorNameLabel.Text = "Name";
            this.toolTip.SetToolTip(this.authorNameLabel, "Click to View Home Page");
            this.authorNameLabel.Click += new System.EventHandler(this.authorNameLabel_Click);
            // 
            // i10indexLabel
            // 
            this.i10indexLabel.AutoSize = true;
            this.i10indexLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i10indexLabel.Location = new System.Drawing.Point(3, 60);
            this.i10indexLabel.Name = "i10indexLabel";
            this.i10indexLabel.Size = new System.Drawing.Size(55, 13);
            this.i10indexLabel.TabIndex = 13;
            this.i10indexLabel.Text = "i10-index";
            // 
            // hindexLabel
            // 
            this.hindexLabel.AutoSize = true;
            this.hindexLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hindexLabel.Location = new System.Drawing.Point(227, 58);
            this.hindexLabel.Name = "hindexLabel";
            this.hindexLabel.Size = new System.Drawing.Size(47, 13);
            this.hindexLabel.TabIndex = 12;
            this.hindexLabel.Text = "h-index";
            // 
            // citerperPaperLabel
            // 
            this.citerperPaperLabel.AutoSize = true;
            this.citerperPaperLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citerperPaperLabel.Location = new System.Drawing.Point(227, 16);
            this.citerperPaperLabel.Name = "citerperPaperLabel";
            this.citerperPaperLabel.Size = new System.Drawing.Size(85, 13);
            this.citerperPaperLabel.TabIndex = 11;
            this.citerperPaperLabel.Text = "Cites per paper";
            // 
            // citesperYearLabel
            // 
            this.citesperYearLabel.AutoSize = true;
            this.citesperYearLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citesperYearLabel.Location = new System.Drawing.Point(227, 37);
            this.citesperYearLabel.Name = "citesperYearLabel";
            this.citesperYearLabel.Size = new System.Drawing.Size(77, 13);
            this.citesperYearLabel.TabIndex = 10;
            this.citesperYearLabel.Text = "Cites per year";
            // 
            // citationsLabel
            // 
            this.citationsLabel.AutoSize = true;
            this.citationsLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citationsLabel.Location = new System.Drawing.Point(3, 38);
            this.citationsLabel.Name = "citationsLabel";
            this.citationsLabel.Size = new System.Drawing.Size(53, 13);
            this.citationsLabel.TabIndex = 9;
            this.citationsLabel.Text = "Citations";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(3, 16);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 8;
            this.authorLabel.Text = "Name";
            // 
            // favouritesPanel
            // 
            this.favouritesPanel.BackColor = System.Drawing.SystemColors.Window;
            this.favouritesPanel.Controls.Add(this.favouritesTreeView);
            this.favouritesPanel.Controls.Add(this.Suggestions);
            this.favouritesPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.favouritesPanel.Location = new System.Drawing.Point(8, 88);
            this.favouritesPanel.Name = "favouritesPanel";
            this.favouritesPanel.Size = new System.Drawing.Size(228, 504);
            this.favouritesPanel.TabIndex = 0;
            // 
            // favouritesTreeView
            // 
            this.favouritesTreeView.BackColor = System.Drawing.SystemColors.Window;
            this.favouritesTreeView.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.favouritesTreeView.Location = new System.Drawing.Point(7, 6);
            this.favouritesTreeView.Name = "favouritesTreeView";
            treeNode1.Name = "authorsRootNode";
            treeNode1.Text = "Authors";
            treeNode2.Name = "journalsRootNode";
            treeNode2.Text = "Journals";
            treeNode3.Name = "Favourites";
            treeNode3.Text = "Favourites";
            this.favouritesTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.favouritesTreeView.Size = new System.Drawing.Size(209, 224);
            this.favouritesTreeView.TabIndex = 9;
            // 
            // Suggestions
            // 
            this.Suggestions.Controls.Add(this.authorsSuggestions);
            this.Suggestions.Location = new System.Drawing.Point(4, 241);
            this.Suggestions.Name = "Suggestions";
            this.Suggestions.Size = new System.Drawing.Size(215, 255);
            this.Suggestions.TabIndex = 8;
            this.Suggestions.TabStop = false;
            this.Suggestions.Text = "Suggestions";
            // 
            // authorsSuggestions
            // 
            this.authorsSuggestions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.authorsSuggestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Authors});
            this.authorsSuggestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorsSuggestions.GridLines = true;
            this.authorsSuggestions.Location = new System.Drawing.Point(3, 18);
            this.authorsSuggestions.Name = "authorsSuggestions";
            this.authorsSuggestions.Size = new System.Drawing.Size(209, 234);
            this.authorsSuggestions.TabIndex = 0;
            this.authorsSuggestions.UseCompatibleStateImageBehavior = false;
            this.authorsSuggestions.View = System.Windows.Forms.View.Details;
            // 
            // Authors
            // 
            this.Authors.Text = "Authors";
            this.Authors.Width = 204;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "From:";
            // 
            // siteComboBox
            // 
            this.siteComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siteComboBox.FormattingEnabled = true;
            this.siteComboBox.Items.AddRange(new object[] {
            "Google Scholar",
            "Citeseer",
            "Microsoft Academic Search"});
            this.siteComboBox.Location = new System.Drawing.Point(91, 32);
            this.siteComboBox.Name = "siteComboBox";
            this.siteComboBox.Size = new System.Drawing.Size(120, 21);
            this.siteComboBox.TabIndex = 6;
            this.siteComboBox.Text = "Citeseer";
            // 
            // searchSiteLabel
            // 
            this.searchSiteLabel.Location = new System.Drawing.Point(16, 35);
            this.searchSiteLabel.Name = "searchSiteLabel";
            this.searchSiteLabel.Size = new System.Drawing.Size(69, 21);
            this.searchSiteLabel.TabIndex = 3;
            this.searchSiteLabel.Text = "Search Site :";
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
            this.removeFromFavouritesToolStripMenuItem});
            this.favouriteMenuStrip.Name = "favouriteMenuStrip";
            this.favouriteMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.favouriteMenuStrip.Size = new System.Drawing.Size(204, 48);
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
            // EndYear
            // 
            this.EndYear.AllowSpace = false;
            this.EndYear.Location = new System.Drawing.Point(415, 32);
            this.EndYear.Name = "EndYear";
            this.EndYear.Size = new System.Drawing.Size(44, 22);
            this.EndYear.TabIndex = 0;
            this.toolTip.SetToolTip(this.EndYear, "End Year");
            this.EndYear.TextChanged += new System.EventHandler(this.EndYear_TextChanged);
            // 
            // StartYear
            // 
            this.StartYear.AllowSpace = false;
            this.StartYear.Location = new System.Drawing.Point(332, 32);
            this.StartYear.Name = "StartYear";
            this.StartYear.Size = new System.Drawing.Size(45, 22);
            this.StartYear.TabIndex = 0;
            this.toolTip.SetToolTip(this.StartYear, "Start Year");
            this.StartYear.TextChanged += new System.EventHandler(this.StartYear_TextChanged);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchPanel);
            this.Name = "search";
            this.Size = new System.Drawing.Size(981, 599);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addToFavourite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.resultsPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.resultsGroupBox.ResumeLayout(false);
            this.statisticsGroupBox.ResumeLayout(false);
            this.statisticsGroupBox.PerformLayout();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            this.favouritesPanel.ResumeLayout(false);
            this.Suggestions.ResumeLayout(false);
            this.optionsMenuStrip.ResumeLayout(false);
            this.favouriteMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox addToFavourite;
        private System.Windows.Forms.TreeView favouritesTreeView;
        private System.Windows.Forms.ContextMenuStrip favouriteMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFromFavouritesToolStripMenuItem;
        private System.Windows.Forms.Panel progressPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox authorCheckBox;
        private System.Windows.Forms.CheckBox journalCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label affiliation;
        private System.Windows.Forms.TextBox KeywordsTextBox;
        private System.Windows.Forms.TextBox affilationTextBox;
        private System.Windows.Forms.ListView cachedListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
