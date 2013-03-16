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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Author1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Author2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Authors", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Journal1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Journal2");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Journals", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Favourites", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.citationsDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.citationsDetailsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.resultsListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.authorImageBox = new System.Windows.Forms.PictureBox();
            this.i10indexLabel = new System.Windows.Forms.Label();
            this.hindexLabel = new System.Windows.Forms.Label();
            this.citerperPaperLabel = new System.Windows.Forms.Label();
            this.citesperYearLabel = new System.Windows.Forms.Label();
            this.citationsLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.favouritesTreeView = new System.Windows.Forms.TreeView();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.citationsDetailsGroupBox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.statisticsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorImageBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1002, 555);
            this.panel6.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.statisticsGroupBox);
            this.panel3.Location = new System.Drawing.Point(280, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 535);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.citationsDetailsGroupBox);
            this.panel5.Location = new System.Drawing.Point(504, 142);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 390);
            this.panel5.TabIndex = 4;
            // 
            // citationsDetailsGroupBox
            // 
            this.citationsDetailsGroupBox.Controls.Add(this.citationsDetailsListView);
            this.citationsDetailsGroupBox.Location = new System.Drawing.Point(4, 4);
            this.citationsDetailsGroupBox.Name = "citationsDetailsGroupBox";
            this.citationsDetailsGroupBox.Size = new System.Drawing.Size(168, 383);
            this.citationsDetailsGroupBox.TabIndex = 0;
            this.citationsDetailsGroupBox.TabStop = false;
            this.citationsDetailsGroupBox.Text = "Citations";
            // 
            // citationsDetailsListView
            // 
            this.citationsDetailsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.citationsDetailsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.citationsDetailsListView.GridLines = true;
            this.citationsDetailsListView.Location = new System.Drawing.Point(3, 16);
            this.citationsDetailsListView.Name = "citationsDetailsListView";
            this.citationsDetailsListView.Size = new System.Drawing.Size(162, 364);
            this.citationsDetailsListView.TabIndex = 0;
            this.citationsDetailsListView.UseCompatibleStateImageBehavior = false;
            this.citationsDetailsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Citations";
            this.columnHeader1.Width = 175;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.resultsGroupBox);
            this.panel4.Location = new System.Drawing.Point(9, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 393);
            this.panel4.TabIndex = 3;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.resultsListView);
            this.resultsGroupBox.Controls.Add(this.listView1);
            this.resultsGroupBox.Location = new System.Drawing.Point(3, 6);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(476, 381);
            this.resultsGroupBox.TabIndex = 0;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results ";
            // 
            // resultsListView
            // 
            this.resultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.resultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsListView.GridLines = true;
            this.resultsListView.Location = new System.Drawing.Point(3, 16);
            this.resultsListView.Name = "resultsListView";
            this.resultsListView.Size = new System.Drawing.Size(470, 362);
            this.resultsListView.TabIndex = 1;
            this.resultsListView.UseCompatibleStateImageBehavior = false;
            this.resultsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Paper";
            this.columnHeader6.Width = 296;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Year";
            this.columnHeader7.Width = 63;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "No.Of Cites";
            this.columnHeader8.Width = 120;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Paper,
            this.Author,
            this.Cites,
            this.Year});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(470, 362);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // Paper
            // 
            this.Paper.Text = "Paper";
            this.Paper.Width = 291;
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
            this.i10index.TabIndex = 23;
            this.i10index.Text = "i10";
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
            // citesperPaper
            // 
            this.citesperPaper.AutoSize = true;
            this.citesperPaper.Location = new System.Drawing.Point(583, 28);
            this.citesperPaper.Name = "citesperPaper";
            this.citesperPaper.Size = new System.Drawing.Size(25, 13);
            this.citesperPaper.TabIndex = 21;
            this.citesperPaper.Text = "cpp";
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
            // citationsNumberLabel
            // 
            this.citationsNumberLabel.AutoSize = true;
            this.citationsNumberLabel.Location = new System.Drawing.Point(312, 53);
            this.citationsNumberLabel.Name = "citationsNumberLabel";
            this.citationsNumberLabel.Size = new System.Drawing.Size(56, 13);
            this.citationsNumberLabel.TabIndex = 19;
            this.citationsNumberLabel.Text = "# citations";
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
            // authorImageBox
            // 
            this.authorImageBox.Location = new System.Drawing.Point(90, 28);
            this.authorImageBox.Name = "authorImageBox";
            this.authorImageBox.Size = new System.Drawing.Size(76, 64);
            this.authorImageBox.TabIndex = 14;
            this.authorImageBox.TabStop = false;
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
            treeNode1.Name = "author1";
            treeNode1.Text = "Author1";
            treeNode2.Name = "author2";
            treeNode2.Text = "Author2";
            treeNode3.Name = "authorsRootNode";
            treeNode3.Text = "Authors";
            treeNode4.Name = "journal1";
            treeNode4.Text = "Journal1";
            treeNode5.Name = "journal2";
            treeNode5.Text = "Journal2";
            treeNode6.Name = "journalsRootNode";
            treeNode6.Text = "Journals";
            treeNode7.Name = "Favourites";
            treeNode7.Text = "Favourites";
            this.favouritesTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.favouritesTreeView.Size = new System.Drawing.Size(180, 175);
            this.favouritesTreeView.TabIndex = 0;
            this.favouritesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // FavPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Name = "FavPanel";
            this.Size = new System.Drawing.Size(1011, 558);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.citationsDetailsGroupBox.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.resultsGroupBox.ResumeLayout(false);
            this.statisticsGroupBox.ResumeLayout(false);
            this.statisticsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorImageBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView favouritesTreeView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox citationsDetailsGroupBox;
        private System.Windows.Forms.ListView citationsDetailsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.ListView resultsListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Paper;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Cites;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.GroupBox statisticsGroupBox;
        private System.Windows.Forms.PictureBox authorImageBox;
        private System.Windows.Forms.Label i10indexLabel;
        private System.Windows.Forms.Label hindexLabel;
        private System.Windows.Forms.Label citerperPaperLabel;
        private System.Windows.Forms.Label citesperYearLabel;
        private System.Windows.Forms.Label citationsLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label citesperYear;
        private System.Windows.Forms.Label citationsNumberLabel;
        private System.Windows.Forms.Label authorNameLabel;
        private System.Windows.Forms.Label i10index;
        private System.Windows.Forms.Label hindex;
        private System.Windows.Forms.Label citesperPaper;
    }
}
