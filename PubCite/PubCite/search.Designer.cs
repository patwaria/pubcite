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
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.citationsDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.Favorites = new System.Windows.Forms.Button();
            this.Ciations = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.authorResultsListView = new System.Windows.Forms.ListView();
            this.PaperHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumOfCitesHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.journalsResultsListView = new System.Windows.Forms.ListView();
            this.Paper = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cites = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statisticsGroupBox = new System.Windows.Forms.GroupBox();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Suggestions = new System.Windows.Forms.GroupBox();
            this.authorsSuggestions = new System.Windows.Forms.ListView();
            this.Authors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.siteComboBox = new System.Windows.Forms.ComboBox();
            this.journalsRadioButton = new System.Windows.Forms.RadioButton();
            this.authorRadioButton = new System.Windows.Forms.RadioButton();
            this.searchSiteLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.EndYear = new PubCite.NumericTextBox();
            this.StartYear = new PubCite.NumericTextBox();
            this.authorImageBox = new System.Windows.Forms.PictureBox();
            this.viewUrl = new System.Windows.Forms.Button();
            this.SearchPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.citationsDetailsGroupBox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.statisticsGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Suggestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.panel3);
            this.SearchPanel.Controls.Add(this.panel2);
            this.SearchPanel.Location = new System.Drawing.Point(0, 3);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(980, 568);
            this.SearchPanel.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CloseButton);
            this.panel3.Controls.Add(this.citationsDetailsGroupBox);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.statisticsGroupBox);
            this.panel3.Location = new System.Drawing.Point(277, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 535);
            this.panel3.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(565, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(107, 23);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_2);
            // 
            // citationsDetailsGroupBox
            // 
            this.citationsDetailsGroupBox.Controls.Add(this.viewUrl);
            this.citationsDetailsGroupBox.Controls.Add(this.Favorites);
            this.citationsDetailsGroupBox.Controls.Add(this.Ciations);
            this.citationsDetailsGroupBox.Location = new System.Drawing.Point(550, 152);
            this.citationsDetailsGroupBox.Name = "citationsDetailsGroupBox";
            this.citationsDetailsGroupBox.Size = new System.Drawing.Size(122, 380);
            this.citationsDetailsGroupBox.TabIndex = 7;
            this.citationsDetailsGroupBox.TabStop = false;
            this.citationsDetailsGroupBox.Text = "options";
            // 
            // Favorites
            // 
            this.Favorites.Location = new System.Drawing.Point(10, 259);
            this.Favorites.Name = "Favorites";
            this.Favorites.Size = new System.Drawing.Size(106, 23);
            this.Favorites.TabIndex = 2;
            this.Favorites.Text = "Add to Favorite";
            this.Favorites.UseVisualStyleBackColor = true;
            this.Favorites.Click += new System.EventHandler(this.Favorites_Click_1);
            // 
            // Ciations
            // 
            this.Ciations.Location = new System.Drawing.Point(10, 288);
            this.Ciations.Name = "Ciations";
            this.Ciations.Size = new System.Drawing.Size(106, 23);
            this.Ciations.TabIndex = 1;
            this.Ciations.Text = "View Citations";
            this.Ciations.UseVisualStyleBackColor = true;
            this.Ciations.Click += new System.EventHandler(this.Ciations_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.resultsGroupBox);
            this.panel4.Location = new System.Drawing.Point(9, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 393);
            this.panel4.TabIndex = 3;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.authorResultsListView);
            this.resultsGroupBox.Controls.Add(this.journalsResultsListView);
            this.resultsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(529, 381);
            this.resultsGroupBox.TabIndex = 0;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results ";
            this.resultsGroupBox.Enter += new System.EventHandler(this.resultsGroupBox_Enter);
            // 
            // authorResultsListView
            // 
            this.authorResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PaperHeader,
            this.YearHeader,
            this.NumOfCitesHeader});
            this.authorResultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorResultsListView.GridLines = true;
            this.authorResultsListView.Location = new System.Drawing.Point(3, 16);
            this.authorResultsListView.MultiSelect = false;
            this.authorResultsListView.Name = "authorResultsListView";
            this.authorResultsListView.Size = new System.Drawing.Size(523, 362);
            this.authorResultsListView.TabIndex = 1;
            this.authorResultsListView.UseCompatibleStateImageBehavior = false;
            this.authorResultsListView.View = System.Windows.Forms.View.Details;
            // 
            // PaperHeader
            // 
            this.PaperHeader.Text = "Paper";
            this.PaperHeader.Width = 374;
            // 
            // YearHeader
            // 
            this.YearHeader.Text = "Year";
            // 
            // NumOfCitesHeader
            // 
            this.NumOfCitesHeader.Text = "No.Of Cites";
            this.NumOfCitesHeader.Width = 86;
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
            this.journalsResultsListView.Size = new System.Drawing.Size(523, 362);
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
            // statisticsGroupBox
            // 
            this.statisticsGroupBox.Controls.Add(this.i10index);
            this.statisticsGroupBox.Controls.Add(this.hindex);
            this.statisticsGroupBox.Controls.Add(this.citesperPaper);
            this.statisticsGroupBox.Controls.Add(this.citesperYear);
            this.statisticsGroupBox.Controls.Add(this.citationsNumberLabel);
            this.statisticsGroupBox.Controls.Add(this.authorNameLabel);
            this.statisticsGroupBox.Controls.Add(this.authorImageBox);
            this.statisticsGroupBox.Controls.Add(this.i10indexLabel);
            this.statisticsGroupBox.Controls.Add(this.hindexLabel);
            this.statisticsGroupBox.Controls.Add(this.citerperPaperLabel);
            this.statisticsGroupBox.Controls.Add(this.citesperYearLabel);
            this.statisticsGroupBox.Controls.Add(this.citationsLabel);
            this.statisticsGroupBox.Controls.Add(this.authorLabel);
            this.statisticsGroupBox.Location = new System.Drawing.Point(9, 26);
            this.statisticsGroupBox.Name = "statisticsGroupBox";
            this.statisticsGroupBox.Size = new System.Drawing.Size(663, 113);
            this.statisticsGroupBox.TabIndex = 2;
            this.statisticsGroupBox.TabStop = false;
            this.statisticsGroupBox.Text = "Statistics";
            // 
            // i10index
            // 
            this.i10index.AutoSize = true;
            this.i10index.Location = new System.Drawing.Point(583, 79);
            this.i10index.Name = "i10index";
            this.i10index.Size = new System.Drawing.Size(21, 13);
            this.i10index.TabIndex = 20;
            this.i10index.Text = "i10";
            // 
            // hindex
            // 
            this.hindex.AutoSize = true;
            this.hindex.Location = new System.Drawing.Point(583, 53);
            this.hindex.Name = "hindex";
            this.hindex.Size = new System.Drawing.Size(13, 13);
            this.hindex.TabIndex = 19;
            this.hindex.Text = "h";
            // 
            // citesperPaper
            // 
            this.citesperPaper.AutoSize = true;
            this.citesperPaper.Location = new System.Drawing.Point(583, 28);
            this.citesperPaper.Name = "citesperPaper";
            this.citesperPaper.Size = new System.Drawing.Size(25, 13);
            this.citesperPaper.TabIndex = 18;
            this.citesperPaper.Text = "cpp";
            // 
            // citesperYear
            // 
            this.citesperYear.AutoSize = true;
            this.citesperYear.Location = new System.Drawing.Point(312, 79);
            this.citesperYear.Name = "citesperYear";
            this.citesperYear.Size = new System.Drawing.Size(24, 13);
            this.citesperYear.TabIndex = 17;
            this.citesperYear.Text = "cpy";
            // 
            // citationsNumberLabel
            // 
            this.citationsNumberLabel.AutoSize = true;
            this.citationsNumberLabel.Location = new System.Drawing.Point(312, 53);
            this.citationsNumberLabel.Name = "citationsNumberLabel";
            this.citationsNumberLabel.Size = new System.Drawing.Size(56, 13);
            this.citationsNumberLabel.TabIndex = 16;
            this.citationsNumberLabel.Text = "# citations";
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.Location = new System.Drawing.Point(312, 28);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(69, 13);
            this.authorNameLabel.TabIndex = 15;
            this.authorNameLabel.Text = "Author Name";
            // 
            // i10indexLabel
            // 
            this.i10indexLabel.AutoSize = true;
            this.i10indexLabel.Location = new System.Drawing.Point(521, 79);
            this.i10indexLabel.Name = "i10indexLabel";
            this.i10indexLabel.Size = new System.Drawing.Size(52, 13);
            this.i10indexLabel.TabIndex = 13;
            this.i10indexLabel.Text = "i10-index:";
            // 
            // hindexLabel
            // 
            this.hindexLabel.AutoSize = true;
            this.hindexLabel.Location = new System.Drawing.Point(529, 53);
            this.hindexLabel.Name = "hindexLabel";
            this.hindexLabel.Size = new System.Drawing.Size(44, 13);
            this.hindexLabel.TabIndex = 12;
            this.hindexLabel.Text = "h-index:";
            // 
            // citerperPaperLabel
            // 
            this.citerperPaperLabel.AutoSize = true;
            this.citerperPaperLabel.Location = new System.Drawing.Point(496, 28);
            this.citerperPaperLabel.Name = "citerperPaperLabel";
            this.citerperPaperLabel.Size = new System.Drawing.Size(81, 13);
            this.citerperPaperLabel.TabIndex = 11;
            this.citerperPaperLabel.Text = "Cites per paper:";
            // 
            // citesperYearLabel
            // 
            this.citesperYearLabel.AutoSize = true;
            this.citesperYearLabel.Location = new System.Drawing.Point(232, 79);
            this.citesperYearLabel.Name = "citesperYearLabel";
            this.citesperYearLabel.Size = new System.Drawing.Size(74, 13);
            this.citesperYearLabel.TabIndex = 10;
            this.citesperYearLabel.Text = "Cites per year:";
            // 
            // citationsLabel
            // 
            this.citationsLabel.AutoSize = true;
            this.citationsLabel.Location = new System.Drawing.Point(256, 53);
            this.citationsLabel.Name = "citationsLabel";
            this.citationsLabel.Size = new System.Drawing.Size(50, 13);
            this.citationsLabel.TabIndex = 9;
            this.citationsLabel.Text = "Citations:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(265, 28);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 8;
            this.authorLabel.Text = "Author:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EndYear);
            this.panel2.Controls.Add(this.StartYear);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Suggestions);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.siteComboBox);
            this.panel2.Controls.Add(this.journalsRadioButton);
            this.panel2.Controls.Add(this.authorRadioButton);
            this.panel2.Controls.Add(this.searchSiteLabel);
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Controls.Add(this.searchField);
            this.panel2.Location = new System.Drawing.Point(4, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 525);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "To:";
            // 
            // Suggestions
            // 
            this.Suggestions.Controls.Add(this.authorsSuggestions);
            this.Suggestions.Location = new System.Drawing.Point(30, 230);
            this.Suggestions.Name = "Suggestions";
            this.Suggestions.Size = new System.Drawing.Size(200, 243);
            this.Suggestions.TabIndex = 8;
            this.Suggestions.TabStop = false;
            this.Suggestions.Text = "Suggestions";
            // 
            // authorsSuggestions
            // 
            this.authorsSuggestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Authors});
            this.authorsSuggestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorsSuggestions.GridLines = true;
            this.authorsSuggestions.Location = new System.Drawing.Point(3, 16);
            this.authorsSuggestions.Name = "authorsSuggestions";
            this.authorsSuggestions.Size = new System.Drawing.Size(194, 224);
            this.authorsSuggestions.TabIndex = 0;
            this.authorsSuggestions.UseCompatibleStateImageBehavior = false;
            this.authorsSuggestions.View = System.Windows.Forms.View.Details;
            // 
            // Authors
            // 
            this.Authors.Text = "Authors";
            this.Authors.Width = 190;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Year Range   From:";
            // 
            // siteComboBox
            // 
            this.siteComboBox.FormattingEnabled = true;
            this.siteComboBox.Items.AddRange(new object[] {
            "Google Scholar",
            "Citeseer",
            "Microsoft Academic Search"});
            this.siteComboBox.Location = new System.Drawing.Point(83, 99);
            this.siteComboBox.Name = "siteComboBox";
            this.siteComboBox.Size = new System.Drawing.Size(147, 21);
            this.siteComboBox.TabIndex = 6;
            this.siteComboBox.Text = "Citeseer";
            this.siteComboBox.SelectedIndexChanged += new System.EventHandler(this.siteComboBox_SelectedIndexChanged);
            // 
            // journalsRadioButton
            // 
            this.journalsRadioButton.AutoSize = true;
            this.journalsRadioButton.Location = new System.Drawing.Point(136, 55);
            this.journalsRadioButton.Name = "journalsRadioButton";
            this.journalsRadioButton.Size = new System.Drawing.Size(64, 17);
            this.journalsRadioButton.TabIndex = 5;
            this.journalsRadioButton.Text = "Journals";
            this.journalsRadioButton.UseVisualStyleBackColor = true;
            // 
            // authorRadioButton
            // 
            this.authorRadioButton.AutoSize = true;
            this.authorRadioButton.Checked = true;
            this.authorRadioButton.Location = new System.Drawing.Point(36, 55);
            this.authorRadioButton.Name = "authorRadioButton";
            this.authorRadioButton.Size = new System.Drawing.Size(61, 17);
            this.authorRadioButton.TabIndex = 4;
            this.authorRadioButton.TabStop = true;
            this.authorRadioButton.Text = "Authors";
            this.authorRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchSiteLabel
            // 
            this.searchSiteLabel.Location = new System.Drawing.Point(8, 102);
            this.searchSiteLabel.Name = "searchSiteLabel";
            this.searchSiteLabel.Size = new System.Drawing.Size(69, 21);
            this.searchSiteLabel.TabIndex = 3;
            this.searchSiteLabel.Text = "Search Site :";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(189, 16);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(3, 16);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(180, 20);
            this.searchField.TabIndex = 1;
            // 
            // EndYear
            // 
            this.EndYear.AllowSpace = false;
            this.EndYear.Location = new System.Drawing.Point(189, 149);
            this.EndYear.Name = "EndYear";
            this.EndYear.Size = new System.Drawing.Size(62, 20);
            this.EndYear.TabIndex = 0;
            // 
            // StartYear
            // 
            this.StartYear.AllowSpace = false;
            this.StartYear.Location = new System.Drawing.Point(104, 149);
            this.StartYear.Name = "StartYear";
            this.StartYear.Size = new System.Drawing.Size(51, 20);
            this.StartYear.TabIndex = 0;
            // 
            // authorImageBox
            // 
            this.authorImageBox.Location = new System.Drawing.Point(90, 28);
            this.authorImageBox.Name = "authorImageBox";
            this.authorImageBox.Size = new System.Drawing.Size(76, 64);
            this.authorImageBox.TabIndex = 14;
            this.authorImageBox.TabStop = false;
            // 
            // viewUrl
            // 
            this.viewUrl.Location = new System.Drawing.Point(10, 318);
            this.viewUrl.Name = "viewUrl";
            this.viewUrl.Size = new System.Drawing.Size(106, 23);
            this.viewUrl.TabIndex = 3;
            this.viewUrl.Text = "View Url";
            this.viewUrl.UseVisualStyleBackColor = true;
            this.viewUrl.Click += new System.EventHandler(this.viewUrl_Click);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchPanel);
            this.Name = "search";
            this.Size = new System.Drawing.Size(1020, 587);
            this.SearchPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.citationsDetailsGroupBox.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.resultsGroupBox.ResumeLayout(false);
            this.statisticsGroupBox.ResumeLayout(false);
            this.statisticsGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Suggestions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authorImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox statisticsGroupBox;
        private System.Windows.Forms.PictureBox authorImageBox;
        private System.Windows.Forms.Label i10indexLabel;
        private System.Windows.Forms.Label hindexLabel;
        private System.Windows.Forms.Label citerperPaperLabel;
        private System.Windows.Forms.Label citesperYearLabel;
        private System.Windows.Forms.Label citationsLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox siteComboBox;
        private System.Windows.Forms.RadioButton journalsRadioButton;
        private System.Windows.Forms.RadioButton authorRadioButton;
        private System.Windows.Forms.Label searchSiteLabel;
        private System.Windows.Forms.Button searchButton;
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
        private System.Windows.Forms.GroupBox citationsDetailsGroupBox;
        private System.Windows.Forms.Button Favorites;
        private System.Windows.Forms.Button Ciations;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.ListView journalsResultsListView;
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
        private System.Windows.Forms.Button viewUrl;
    }
}
