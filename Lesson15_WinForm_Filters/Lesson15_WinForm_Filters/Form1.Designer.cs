namespace Lesson15_WinForm_Filters
{
    partial class PersonGeneratorForm
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
            this.AvalibaleFiltersGroupBox = new System.Windows.Forms.GroupBox();
            this.BlackListFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.WhiteListFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.TimerIntervalGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerIntervalNumeric = new System.Windows.Forms.NumericUpDown();
            this.GeneratedPersonsGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.AvalibaleFiltersGroupBox.SuspendLayout();
            this.TimerIntervalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerIntervalNumeric)).BeginInit();
            this.GeneratedPersonsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AvalibaleFiltersGroupBox
            // 
            this.AvalibaleFiltersGroupBox.Controls.Add(this.BlackListFilterCheckBox);
            this.AvalibaleFiltersGroupBox.Controls.Add(this.WhiteListFilterCheckBox);
            this.AvalibaleFiltersGroupBox.Location = new System.Drawing.Point(12, 12);
            this.AvalibaleFiltersGroupBox.Name = "AvalibaleFiltersGroupBox";
            this.AvalibaleFiltersGroupBox.Size = new System.Drawing.Size(108, 61);
            this.AvalibaleFiltersGroupBox.TabIndex = 0;
            this.AvalibaleFiltersGroupBox.TabStop = false;
            this.AvalibaleFiltersGroupBox.Text = "Avaliable Filters:";
            // 
            // BlackListFilterCheckBox
            // 
            this.BlackListFilterCheckBox.AutoSize = true;
            this.BlackListFilterCheckBox.Checked = true;
            this.BlackListFilterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BlackListFilterCheckBox.Location = new System.Drawing.Point(6, 38);
            this.BlackListFilterCheckBox.Name = "BlackListFilterCheckBox";
            this.BlackListFilterCheckBox.Size = new System.Drawing.Size(97, 17);
            this.BlackListFilterCheckBox.TabIndex = 1;
            this.BlackListFilterCheckBox.Text = "Black List Filter";
            this.BlackListFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // WhiteListFilterCheckBox
            // 
            this.WhiteListFilterCheckBox.AutoSize = true;
            this.WhiteListFilterCheckBox.Checked = true;
            this.WhiteListFilterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WhiteListFilterCheckBox.Location = new System.Drawing.Point(6, 19);
            this.WhiteListFilterCheckBox.Name = "WhiteListFilterCheckBox";
            this.WhiteListFilterCheckBox.Size = new System.Drawing.Size(98, 17);
            this.WhiteListFilterCheckBox.TabIndex = 0;
            this.WhiteListFilterCheckBox.Text = "White List Filter";
            this.WhiteListFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // TimerIntervalGroupBox
            // 
            this.TimerIntervalGroupBox.Controls.Add(this.label1);
            this.TimerIntervalGroupBox.Controls.Add(this.TimerIntervalNumeric);
            this.TimerIntervalGroupBox.Location = new System.Drawing.Point(12, 79);
            this.TimerIntervalGroupBox.Name = "TimerIntervalGroupBox";
            this.TimerIntervalGroupBox.Size = new System.Drawing.Size(108, 47);
            this.TimerIntervalGroupBox.TabIndex = 1;
            this.TimerIntervalGroupBox.TabStop = false;
            this.TimerIntervalGroupBox.Text = "Timer Interval:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sec";
            // 
            // TimerIntervalNumeric
            // 
            this.TimerIntervalNumeric.Location = new System.Drawing.Point(6, 19);
            this.TimerIntervalNumeric.Name = "TimerIntervalNumeric";
            this.TimerIntervalNumeric.Size = new System.Drawing.Size(57, 20);
            this.TimerIntervalNumeric.TabIndex = 0;
            this.TimerIntervalNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GeneratedPersonsGroupBox
            // 
            this.GeneratedPersonsGroupBox.Controls.Add(this.ResultTextBox);
            this.GeneratedPersonsGroupBox.Location = new System.Drawing.Point(126, 12);
            this.GeneratedPersonsGroupBox.Name = "GeneratedPersonsGroupBox";
            this.GeneratedPersonsGroupBox.Size = new System.Drawing.Size(417, 153);
            this.GeneratedPersonsGroupBox.TabIndex = 2;
            this.GeneratedPersonsGroupBox.TabStop = false;
            this.GeneratedPersonsGroupBox.Text = "Generated Persons:";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.White;
            this.ResultTextBox.Location = new System.Drawing.Point(6, 19);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextBox.Size = new System.Drawing.Size(402, 128);
            this.ResultTextBox.TabIndex = 0;
            this.ResultTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 130);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(108, 33);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PersonGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 170);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.GeneratedPersonsGroupBox);
            this.Controls.Add(this.TimerIntervalGroupBox);
            this.Controls.Add(this.AvalibaleFiltersGroupBox);
            this.Name = "PersonGeneratorForm";
            this.Text = "Person Generator";
            this.AvalibaleFiltersGroupBox.ResumeLayout(false);
            this.AvalibaleFiltersGroupBox.PerformLayout();
            this.TimerIntervalGroupBox.ResumeLayout(false);
            this.TimerIntervalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerIntervalNumeric)).EndInit();
            this.GeneratedPersonsGroupBox.ResumeLayout(false);
            this.GeneratedPersonsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AvalibaleFiltersGroupBox;
        private System.Windows.Forms.CheckBox BlackListFilterCheckBox;
        private System.Windows.Forms.CheckBox WhiteListFilterCheckBox;
        private System.Windows.Forms.GroupBox TimerIntervalGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TimerIntervalNumeric;
        private System.Windows.Forms.GroupBox GeneratedPersonsGroupBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button StartButton;
    }
}

