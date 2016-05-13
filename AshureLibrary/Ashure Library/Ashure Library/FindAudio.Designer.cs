namespace Ashure_Library
{
    partial class FindAudioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindAudioForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.FileFormatCheckBox = new System.Windows.Forms.ComboBox();
            this.FileNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.BrowseTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddToPlayList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddToPlayList);
            this.groupBox1.Controls.Add(this.FindButton);
            this.groupBox1.Controls.Add(this.FileFormatCheckBox);
            this.groupBox1.Controls.Add(this.FileNameText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BrowseButton);
            this.groupBox1.Controls.Add(this.BrowseTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(273, 35);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(126, 23);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Find";
            this.FindButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FileFormatCheckBox
            // 
            this.FileFormatCheckBox.FormattingEnabled = true;
            this.FileFormatCheckBox.Items.AddRange(new object[] {
            "*.mp3"});
            this.FileFormatCheckBox.Location = new System.Drawing.Point(93, 59);
            this.FileFormatCheckBox.Name = "FileFormatCheckBox";
            this.FileFormatCheckBox.Size = new System.Drawing.Size(161, 21);
            this.FileFormatCheckBox.TabIndex = 6;
            this.FileFormatCheckBox.Text = "*.mp3";
            // 
            // FileNameText
            // 
            this.FileNameText.Location = new System.Drawing.Point(93, 36);
            this.FileNameText.Name = "FileNameText";
            this.FileNameText.Size = new System.Drawing.Size(161, 20);
            this.FileNameText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "File Name:";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(273, 11);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(126, 23);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // BrowseTextBox
            // 
            this.BrowseTextBox.Location = new System.Drawing.Point(93, 13);
            this.BrowseTextBox.Name = "BrowseTextBox";
            this.BrowseTextBox.Size = new System.Drawing.Size(161, 20);
            this.BrowseTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Fomat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File(s) Location:";
            // 
            // ResultListView
            // 
            this.ResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.ResultListView.Location = new System.Drawing.Point(12, 105);
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.Size = new System.Drawing.Size(405, 170);
            this.ResultListView.TabIndex = 1;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "File Name";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Song Title";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Singer";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Album";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Year";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Comment";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Location";
            // 
            // AddToPlayList
            // 
            this.AddToPlayList.Location = new System.Drawing.Point(273, 59);
            this.AddToPlayList.Name = "AddToPlayList";
            this.AddToPlayList.Size = new System.Drawing.Size(126, 23);
            this.AddToPlayList.TabIndex = 8;
            this.AddToPlayList.Text = "Add to plyalist";
            this.AddToPlayList.UseVisualStyleBackColor = true;
            this.AddToPlayList.Click += new System.EventHandler(this.AddToPlayList_Click);
            // 
            // FindAudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 287);
            this.Controls.Add(this.ResultListView);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindAudioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find Audio Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.ComboBox FileFormatCheckBox;
        private System.Windows.Forms.TextBox FileNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox BrowseTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ResultListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button AddToPlayList;
    }
}