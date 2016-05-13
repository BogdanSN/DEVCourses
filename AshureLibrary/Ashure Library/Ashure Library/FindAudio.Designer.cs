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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BrowseTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FileNameText = new System.Windows.Forms.TextBox();
            this.FileFormatCheckBox = new System.Windows.Forms.ComboBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(361, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Fomat:";
            // 
            // BrowseTextBox
            // 
            this.BrowseTextBox.Location = new System.Drawing.Point(93, 13);
            this.BrowseTextBox.Name = "BrowseTextBox";
            this.BrowseTextBox.Size = new System.Drawing.Size(161, 20);
            this.BrowseTextBox.TabIndex = 2;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(273, 11);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
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
            // FileNameText
            // 
            this.FileNameText.Location = new System.Drawing.Point(93, 36);
            this.FileNameText.Name = "FileNameText";
            this.FileNameText.Size = new System.Drawing.Size(161, 20);
            this.FileNameText.TabIndex = 5;
            // 
            // FileFormatCheckBox
            // 
            this.FileFormatCheckBox.FormattingEnabled = true;
            this.FileFormatCheckBox.Items.AddRange(new object[] {
            "*.*",
            "*.mp3"});
            this.FileFormatCheckBox.Location = new System.Drawing.Point(93, 59);
            this.FileFormatCheckBox.Name = "FileFormatCheckBox";
            this.FileFormatCheckBox.Size = new System.Drawing.Size(161, 21);
            this.FileFormatCheckBox.TabIndex = 6;
            this.FileFormatCheckBox.Text = "*.*";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(273, 52);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Find";
            this.FindButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ResultListBox
            // 
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.Location = new System.Drawing.Point(12, 110);
            this.ResultListBox.MultiColumn = true;
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.ScrollAlwaysVisible = true;
            this.ResultListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ResultListBox.Size = new System.Drawing.Size(348, 160);
            this.ResultListBox.TabIndex = 1;
            // 
            // FindAudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 287);
            this.Controls.Add(this.ResultListBox);
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
        private System.Windows.Forms.ListBox ResultListBox;
    }
}