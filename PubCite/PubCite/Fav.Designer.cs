namespace PubCite
{
    partial class FavPanel
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Authors");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Journals", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Favourites", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3});
            this.panel1 = new System.Windows.Forms.Panel();
            this.favouritesTreeView = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statisticsGroupBox = new System.Windows.Forms.GroupBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.citationsLabel = new System.Windows.Forms.Label();
            this.citesperYearLabel = new System.Windows.Forms.Label();
            this.citerperPaperLabel = new System.Windows.Forms.Label();
            this.hindexLabel = new System.Windows.Forms.Label();
            this.i10indexLabel = new System.Windows.Forms.Label();
            this.authorImageBox = new System.Windows.Forms.PictureBox();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.citationsNumberLabel = new System.Windows.Forms.Label();
            this.citesperYear = new System.Windows.Forms.Label();
            this.citesperPaper = new System.Windows.Forms.Label();
            this.hindex = new System.Windows.Forms.Label();
            this.i10index = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.citationsDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.Ciations = new System.Windows.Forms.Button();
            this.Favorites = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.journalsResultsListView = new System.Windows.Forms.ListView();
            this.Paper = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cites = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorResultsListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statisticsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorImageBox)).BeginInit();
            this.citationsDetailsGroupBox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.favouritesTreeView);
            this.panel1.Location = new System.Drawing.Point(7, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 525);
            this.panel1.TabIndex = 1;
            // 
            // favouritesTreeView
            // 
            this.favouritesTreeView.BackColor = System.Drawing.SystemColors.MenuBar;
            this.favouritesTreeView.Location = new System.Drawing.Point(43, 74);
            this.favouritesTreeView.Name = "favouritesTreeView";
            treeNode1.Name = "authorsRootNode";
            treeNode1.Text = "Authors";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            treeNode3.Name = "journalsRootNode";
            treeNode3.Text = "Journals";
            treeNode4.Name = "Favourites";
            treeNode4.Text = "Favourites";
            this.favouritesTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.favouritesTreeView.Size = new System.Drawing.Size(180, 175);
            this.favouritesTreeView.TabIndex = 0;
            this.favouritesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.citationsDetailsGroupBox);
            this.panel3.Controls.Add(this.CloseButton);
            this.panel3.Controls.Add(this.statisticsGroupBox);
            this.panel3.Location = new System.Drawing.Point(280, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 535);
            this.panel3.TabIndex = 2;
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
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(265, 28);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 8;
            this.authorLabel.Text = "Author:";
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
            // citesperYearLabel
            // 
            this.citesperYearLabel.AutoSize = true;
            this.citesperYearLabel.Location = new System.Drawing.Point(232, 79);
            this.citesperYearLabel.Name = "citesperYearLabel";
            this.citesperYearLabel.Size = new System.Drawing.Size(74, 13);
            this.citesperYearLabel.TabIndex = 10;
            this.citesperYearLabel.Text = "Cites per year:";
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
            // hindexLabel
            // 
            this.hindexLabel.AutoSize = true;
            this.hindexLabel.Location = new System.Drawing.Point(529, 53);
            this.hindexLabel.Name = "hindexLabel";
            this.hindexLabel.Size = new System.Drawing.Size(44, 13);
            this.hindexLabel.TabIndex = 12;
            this.hindexLabel.Text = "h-index:";
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
            // authorImageBox
            // 
            this.authorImageBox.Location = new System.Drawing.Point(90, 28);
            this.authorImageBox.Name = "authorImageBox";
            this.authorImageBox.Size = new System.Drawing.Size(76, 64);
            this.authorImageBox.TabIndex = 14;
            this.authorImageBox.TabStop = false;
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.Location = new System.Drawing.Point(312, 28);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(69, 13);
            this.authorNameLabel.TabIndex = 18;
            this.authorNameLabel.Text = "Author Name";
            // 
            // citationsNumberLabel
            // 
            this.citationsNumberLabel.AutoSize = true;
            this.citationsNumberLabel.Location = new System.Drawing.Point(312, 53);
            this.citationsNumberLabel.Name = "citationsNumberLabel";
            this.citationsNumberLabel.Size = new System.Drawing.Size(56, 13);
            this.citationsNumberLabel.TabIndex = 19;
            this.citationsNumberLabel.Text = "# citations";
            // 
            // citesperYear
            // 
            this.citesperYear.AutoSize = true;
            this.citesperYear.Location = new System.Drawing.Point(312, 79);
            this.citesperYear.Name = "citesperYear";
            this.citesperYear.Size = new System.Drawing.Size(24, 13);
            this.citesperYear.TabIndex = 20;
            this.citesperYear.Text = "cpy";
            // 
            // citesperPaper
            // 
            this.citesperPaper.AutoSize = true;
            this.citesperPaper.Location = new System.Drawing.Point(583, 28);
            this.citesperPaper.Name = "citesperPaper";
            this.citesperPaper.Size = new System.Drawing.Size(25, 13);
            this.citesperPaper.TabIndex = 21;
            this.citesperPaper.Text = "cpp";
            // 
            // hindex
            // 
            this.hindex.AutoSize = true;
            this.hindex.Location = new System.Drawing.Point(583, 53);
            this.hindex.Name = "hindex";
            this.hindex.Size = new System.Drawing.Size(13, 13);
            this.hindex.TabIndex = 22;
            this.hindex.Text = "h";
            // 
            // i10index
            // 
            this.i10index.AutoSize = true;
            this.i10index.Location = new System.Drawing.Point(583, 79);
            this.i10index.Name = "i10index";
            this.i10index.Size = new System.Drawing.Size(21, 13);
            this.i10index.TabIndex = 23;
            this.i10index.Text = "i10";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(565, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(107, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // citationsDetailsGroupBox
            // 
            this.citationsDetailsGroupBox.Controls.Add(this.Favorites);
            this.citationsDetailsGroupBox.Controls.Add(this.Ciations);
            this.citationsDetailsGroupBox.Location = new System.Drawing.Point(575, 143);
            this.citationsDetailsGroupBox.Name = "citationsDetailsGroupBox";
            this.citationsDetailsGroupBox.Size = new System.Drawing.Size(122, 383);
            this.citationsDetailsGroupBox.TabIndex = 6;
            this.citationsDetailsGroupBox.TabStop = false;
            this.citationsDetailsGroupBox.Text = "options";
            // 
            // Ciations
            // 
            this.Ciations.Location = new System.Drawing.Point(6, 73);
            this.Ciations.Name = "Ciations";
            this.Ciations.Size = new System.Drawing.Size(106, 23);
            this.Ciations.TabIndex = 1;
            this.Ciations.Text = "View Citations";
            this.Ciations.UseVisualStyleBackColor = true;
            // 
            // Favorites
            // 
            this.Favorites.Location = new System.Drawing.Point(6, 32);
            this.Favorites.Name = "Favorites";
            this.Favorites.Size = new System.Drawing.Size(106, 23);
            this.Favorites.TabIndex = 2;
            this.Favorites.Text = "Remove From Favorite";
            this.Favorites.UseVisualStyleBackColor = true;
            this.Favorites.Click += new System.EventHandler(this.Favorites_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.resultsGroupBox);
            this.panel4.Location = new System.Drawing.Point(3, 145);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(566, 393);
            this.panel4.TabIndex = 7;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.authorResultsListView);
            this.resultsGroupBox.Controls.Add(this.journalsResultsListView);
            this.resultsGroupBox.Location = new System.Drawing.Point(3, 6);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(560, 381);
            this.resultsGroupBox.TabIndex = 0;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results ";
            // 
            // journalResultsListView
            // 
            this.journalsResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Paper,
            this.Author,
            this.Cites,
            this.Year});
            this.journalsResultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journalsResultsListView.GridLines = true;
            this.journalsResultsListView.Location = new System.Drawing.Point(3, 16);
            this.journalsResultsListView.Name = "journalsResultsListView";
            this.journalsResultsListView.Size = new System.Drawing.Size(554, 362);
            this.journalsResultsListView.TabIndex = 0;
            this.journalsResultsListView.UseCompatibleStateImageBehavior = false;
            this.journalsResultsListView.View = System.Windows.Forms.View.Details;
            this.journalsResultsListView.Visible = false;
            // 
            // Paper
            // 
            this.Paper.Text = "Paper";
            this.Paper.Width = 151;
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
            // authorResultsListView
            // 
            this.authorResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.authorResultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorResultsListView.GridLines = true;
            this.authorResultsListView.Location = new System.Drawing.Point(3, 16);
            this.authorResultsListView.Name = "authorResultsListView";
            this.authorResultsListView.Size = new System.Drawing.Size(554, 362);
            this.authorResultsListView.TabIndex = 1;
            this.authorResultsListView.UseCompatibleStateImageBehavior = false;
            this.authorResultsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Paper";
            this.columnHeader6.Width = 386;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Year";
            this.columnHeader7.Width = 68;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "No.Of Cites";
            this.columnHeader8.Width = 96;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(981, 596);
            this.panel6.TabIndex = 3;
            // 
            // FavPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Name = "FavPanel";
            this.Size = new System.Drawing.Size(983, 598);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.statisticsGroupBox.ResumeLayout(false);
            this.statisticsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorImageBox)).EndInit();
            this.citationsDetailsGroupBox.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.resultsGroupBox.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView favouritesTreeView;
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
        private System.Windows.Forms.GroupBox citationsDetailsGroupBox;
        private System.Windows.Forms.Button Favorites;
        private System.Windows.Forms.Button Ciations;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.GroupBox statisticsGroupBox;
        private System.Windows.Forms.Label i10index;
        private System.Windows.Forms.Label hindex;
        private System.Windows.Forms.Label citesperPaper;
        private System.Windows.Forms.Label citesperYear;
        private System.Windows.Forms.Label citationsNumberLabel;
        private System.Windows.Forms.Label authorNameLabel;
        private System.Windows.Forms.PictureBox authorImageBox;
        private System.Windows.Forms.Label i10indexLabel;
        private System.Windows.Forms.Label hindexLabel;
        private System.Windows.Forms.Label citerperPaperLabel;
        private System.Windows.Forms.Label citesperYearLabel;
        private System.Windows.Forms.Label citationsLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Panel panel6;

    }
}
