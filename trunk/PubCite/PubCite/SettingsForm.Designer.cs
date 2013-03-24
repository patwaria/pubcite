namespace PubCite
{
    partial class SettingsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CacheOptions = new System.Windows.Forms.GroupBox();
            this.CacheOptionslabel = new System.Windows.Forms.Label();
            this.cacheNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.citeseerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.googleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.microsoftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Okbutton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.CacheOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cacheNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citeseerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.googleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoftNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.Okbutton);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.CacheOptions);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 361);
            this.panel1.TabIndex = 0;
            // 
            // CacheOptions
            // 
            this.CacheOptions.Controls.Add(this.cacheNumericUpDown);
            this.CacheOptions.Controls.Add(this.CacheOptionslabel);
            this.CacheOptions.Location = new System.Drawing.Point(3, 24);
            this.CacheOptions.Name = "CacheOptions";
            this.CacheOptions.Size = new System.Drawing.Size(476, 63);
            this.CacheOptions.TabIndex = 0;
            this.CacheOptions.TabStop = false;
            this.CacheOptions.Text = "Results Caching";
            // 
            // CacheOptionslabel
            // 
            this.CacheOptionslabel.AutoSize = true;
            this.CacheOptionslabel.Location = new System.Drawing.Point(92, 28);
            this.CacheOptionslabel.Name = "CacheOptionslabel";
            this.CacheOptionslabel.Size = new System.Drawing.Size(158, 13);
            this.CacheOptionslabel.TabIndex = 0;
            this.CacheOptionslabel.Text = "Keep Cache These Many Days:";
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
            this.cacheNumericUpDown.Size = new System.Drawing.Size(35, 20);
            this.cacheNumericUpDown.TabIndex = 1;
            this.cacheNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.microsoftNumericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.googleNumericUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.citeseerNumericUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query Options";
            // 
            // citeseerNumericUpDown
            // 
            this.citeseerNumericUpDown.Location = new System.Drawing.Point(271, 28);
            this.citeseerNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.citeseerNumericUpDown.Name = "citeseerNumericUpDown";
            this.citeseerNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.citeseerNumericUpDown.TabIndex = 1;
            this.citeseerNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Limit Citeseer Results to:";
            // 
            // googleNumericUpDown
            // 
            this.googleNumericUpDown.Location = new System.Drawing.Point(271, 68);
            this.googleNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.googleNumericUpDown.Name = "googleNumericUpDown";
            this.googleNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.googleNumericUpDown.TabIndex = 3;
            this.googleNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Limit Google  Results to:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Limit Microsoft  Results to:";
            // 
            // microsoftNumericUpDown
            // 
            this.microsoftNumericUpDown.Location = new System.Drawing.Point(271, 109);
            this.microsoftNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.microsoftNumericUpDown.Name = "microsoftNumericUpDown";
            this.microsoftNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.microsoftNumericUpDown.TabIndex = 5;
            this.microsoftNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(127, 291);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(75, 23);
            this.Okbutton.TabIndex = 2;
            this.Okbutton.Text = "Ok";
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(259, 291);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 365);
            this.Controls.Add(this.panel1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.panel1.ResumeLayout(false);
            this.CacheOptions.ResumeLayout(false);
            this.CacheOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cacheNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citeseerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.googleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoftNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox CacheOptions;
        private System.Windows.Forms.Label CacheOptionslabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown microsoftNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown googleNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown citeseerNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cacheNumericUpDown;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button Okbutton;
    }
}