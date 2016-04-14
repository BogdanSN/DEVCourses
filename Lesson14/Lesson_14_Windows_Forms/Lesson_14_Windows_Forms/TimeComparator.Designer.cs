namespace Lesson_14_Windows_Forms
{
    partial class TimeComparatorForm
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
            this.MethodsGroupBox = new System.Windows.Forms.GroupBox();
            this.StackNetLabel = new System.Windows.Forms.Label();
            this.StackArrayLabel = new System.Windows.Forms.Label();
            this.StackListLabel = new System.Windows.Forms.Label();
            this.StackDynamicArrayLabel = new System.Windows.Forms.Label();
            this.QueueArrayLabel = new System.Windows.Forms.Label();
            this.QueueDynamicArrayLabel = new System.Windows.Forms.Label();
            this.ResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StackNetCheckBox = new System.Windows.Forms.CheckBox();
            this.StackArrayCheckBox = new System.Windows.Forms.CheckBox();
            this.StackDynamicArrayCheckBox = new System.Windows.Forms.CheckBox();
            this.StackListCheckBox = new System.Windows.Forms.CheckBox();
            this.QueueArrayCheckBox = new System.Windows.Forms.CheckBox();
            this.QueueDynamicArrayCheckBox = new System.Windows.Forms.CheckBox();
            this.QueueNetCheckBox = new System.Windows.Forms.CheckBox();
            this.QueueNetLabel = new System.Windows.Forms.Label();
            this.MethodsGroupBox.SuspendLayout();
            this.ResultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MethodsGroupBox
            // 
            this.MethodsGroupBox.Controls.Add(this.QueueNetCheckBox);
            this.MethodsGroupBox.Controls.Add(this.QueueDynamicArrayCheckBox);
            this.MethodsGroupBox.Controls.Add(this.QueueArrayCheckBox);
            this.MethodsGroupBox.Controls.Add(this.StackListCheckBox);
            this.MethodsGroupBox.Controls.Add(this.StackDynamicArrayCheckBox);
            this.MethodsGroupBox.Controls.Add(this.StackArrayCheckBox);
            this.MethodsGroupBox.Controls.Add(this.StackNetCheckBox);
            this.MethodsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MethodsGroupBox.Name = "MethodsGroupBox";
            this.MethodsGroupBox.Size = new System.Drawing.Size(196, 131);
            this.MethodsGroupBox.TabIndex = 0;
            this.MethodsGroupBox.TabStop = false;
            this.MethodsGroupBox.Text = "AvaliableMethods:";
            // 
            // StackNetLabel
            // 
            this.StackNetLabel.AutoSize = true;
            this.StackNetLabel.Location = new System.Drawing.Point(6, 15);
            this.StackNetLabel.Name = "StackNetLabel";
            this.StackNetLabel.Size = new System.Drawing.Size(32, 13);
            this.StackNetLabel.TabIndex = 1;
            this.StackNetLabel.Text = " 0 ms";
            this.StackNetLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // StackArrayLabel
            // 
            this.StackArrayLabel.AutoSize = true;
            this.StackArrayLabel.Location = new System.Drawing.Point(6, 29);
            this.StackArrayLabel.Name = "StackArrayLabel";
            this.StackArrayLabel.Size = new System.Drawing.Size(32, 13);
            this.StackArrayLabel.TabIndex = 2;
            this.StackArrayLabel.Text = " 0 ms";
            this.StackArrayLabel.Click += new System.EventHandler(this.StackArrayLabel_Click);
            // 
            // StackListLabel
            // 
            this.StackListLabel.AutoSize = true;
            this.StackListLabel.Location = new System.Drawing.Point(9, 60);
            this.StackListLabel.Name = "StackListLabel";
            this.StackListLabel.Size = new System.Drawing.Size(29, 13);
            this.StackListLabel.TabIndex = 3;
            this.StackListLabel.Text = "0 ms";
            // 
            // StackDynamicArrayLabel
            // 
            this.StackDynamicArrayLabel.AutoSize = true;
            this.StackDynamicArrayLabel.Location = new System.Drawing.Point(9, 45);
            this.StackDynamicArrayLabel.Name = "StackDynamicArrayLabel";
            this.StackDynamicArrayLabel.Size = new System.Drawing.Size(29, 13);
            this.StackDynamicArrayLabel.TabIndex = 4;
            this.StackDynamicArrayLabel.Text = "0 ms";
            // 
            // QueueArrayLabel
            // 
            this.QueueArrayLabel.AutoSize = true;
            this.QueueArrayLabel.Location = new System.Drawing.Point(6, 91);
            this.QueueArrayLabel.Name = "QueueArrayLabel";
            this.QueueArrayLabel.Size = new System.Drawing.Size(32, 13);
            this.QueueArrayLabel.TabIndex = 5;
            this.QueueArrayLabel.Text = " 0 ms";
            // 
            // QueueDynamicArrayLabel
            // 
            this.QueueDynamicArrayLabel.AutoSize = true;
            this.QueueDynamicArrayLabel.Location = new System.Drawing.Point(9, 107);
            this.QueueDynamicArrayLabel.Name = "QueueDynamicArrayLabel";
            this.QueueDynamicArrayLabel.Size = new System.Drawing.Size(29, 13);
            this.QueueDynamicArrayLabel.TabIndex = 6;
            this.QueueDynamicArrayLabel.Text = "0 ms";
            // 
            // ResultsGroupBox
            // 
            this.ResultsGroupBox.Controls.Add(this.QueueNetLabel);
            this.ResultsGroupBox.Controls.Add(this.StackNetLabel);
            this.ResultsGroupBox.Controls.Add(this.QueueDynamicArrayLabel);
            this.ResultsGroupBox.Controls.Add(this.StackArrayLabel);
            this.ResultsGroupBox.Controls.Add(this.QueueArrayLabel);
            this.ResultsGroupBox.Controls.Add(this.StackListLabel);
            this.ResultsGroupBox.Controls.Add(this.StackDynamicArrayLabel);
            this.ResultsGroupBox.Location = new System.Drawing.Point(214, 12);
            this.ResultsGroupBox.Name = "ResultsGroupBox";
            this.ResultsGroupBox.Size = new System.Drawing.Size(67, 131);
            this.ResultsGroupBox.TabIndex = 7;
            this.ResultsGroupBox.TabStop = false;
            this.ResultsGroupBox.Text = "Results:";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 149);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(269, 23);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StackNetCheckBox
            // 
            this.StackNetCheckBox.AutoSize = true;
            this.StackNetCheckBox.Location = new System.Drawing.Point(6, 16);
            this.StackNetCheckBox.Name = "StackNetCheckBox";
            this.StackNetCheckBox.Size = new System.Drawing.Size(124, 17);
            this.StackNetCheckBox.TabIndex = 0;
            this.StackNetCheckBox.Text = "Stack based on .Net";
            this.StackNetCheckBox.UseVisualStyleBackColor = true;
            this.StackNetCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // StackArrayCheckBox
            // 
            this.StackArrayCheckBox.AutoSize = true;
            this.StackArrayCheckBox.Location = new System.Drawing.Point(6, 31);
            this.StackArrayCheckBox.Name = "StackArrayCheckBox";
            this.StackArrayCheckBox.Size = new System.Drawing.Size(128, 17);
            this.StackArrayCheckBox.TabIndex = 1;
            this.StackArrayCheckBox.Text = "Stack based on Array";
            this.StackArrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // StackDynamicArrayCheckBox
            // 
            this.StackDynamicArrayCheckBox.AutoSize = true;
            this.StackDynamicArrayCheckBox.Location = new System.Drawing.Point(6, 45);
            this.StackDynamicArrayCheckBox.Name = "StackDynamicArrayCheckBox";
            this.StackDynamicArrayCheckBox.Size = new System.Drawing.Size(164, 17);
            this.StackDynamicArrayCheckBox.TabIndex = 2;
            this.StackDynamicArrayCheckBox.Text = "Stack based on Dynaic Array";
            this.StackDynamicArrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // StackListCheckBox
            // 
            this.StackListCheckBox.AutoSize = true;
            this.StackListCheckBox.Location = new System.Drawing.Point(6, 61);
            this.StackListCheckBox.Name = "StackListCheckBox";
            this.StackListCheckBox.Size = new System.Drawing.Size(120, 17);
            this.StackListCheckBox.TabIndex = 3;
            this.StackListCheckBox.Text = "Stack based on List";
            this.StackListCheckBox.UseVisualStyleBackColor = true;
            // 
            // QueueArrayCheckBox
            // 
            this.QueueArrayCheckBox.AutoSize = true;
            this.QueueArrayCheckBox.Location = new System.Drawing.Point(6, 91);
            this.QueueArrayCheckBox.Name = "QueueArrayCheckBox";
            this.QueueArrayCheckBox.Size = new System.Drawing.Size(132, 17);
            this.QueueArrayCheckBox.TabIndex = 4;
            this.QueueArrayCheckBox.Text = "Queue based on Array";
            this.QueueArrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // QueueDynamicArrayCheckBox
            // 
            this.QueueDynamicArrayCheckBox.AutoSize = true;
            this.QueueDynamicArrayCheckBox.Location = new System.Drawing.Point(6, 107);
            this.QueueDynamicArrayCheckBox.Name = "QueueDynamicArrayCheckBox";
            this.QueueDynamicArrayCheckBox.Size = new System.Drawing.Size(176, 17);
            this.QueueDynamicArrayCheckBox.TabIndex = 5;
            this.QueueDynamicArrayCheckBox.Text = "Queue based on Dynamic Array";
            this.QueueDynamicArrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // QueueNetCheckBox
            // 
            this.QueueNetCheckBox.AutoSize = true;
            this.QueueNetCheckBox.Location = new System.Drawing.Point(6, 77);
            this.QueueNetCheckBox.Name = "QueueNetCheckBox";
            this.QueueNetCheckBox.Size = new System.Drawing.Size(128, 17);
            this.QueueNetCheckBox.TabIndex = 6;
            this.QueueNetCheckBox.Text = "Queue based on .Net";
            this.QueueNetCheckBox.UseVisualStyleBackColor = true;
            // 
            // QueueNetLabel
            // 
            this.QueueNetLabel.AutoSize = true;
            this.QueueNetLabel.Location = new System.Drawing.Point(9, 75);
            this.QueueNetLabel.Name = "QueueNetLabel";
            this.QueueNetLabel.Size = new System.Drawing.Size(29, 13);
            this.QueueNetLabel.TabIndex = 7;
            this.QueueNetLabel.Text = "0 ms";
            // 
            // TimeComparatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 183);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ResultsGroupBox);
            this.Controls.Add(this.MethodsGroupBox);
            this.Name = "TimeComparatorForm";
            this.Text = "TimeComparator";
            this.MethodsGroupBox.ResumeLayout(false);
            this.MethodsGroupBox.PerformLayout();
            this.ResultsGroupBox.ResumeLayout(false);
            this.ResultsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MethodsGroupBox;
        private System.Windows.Forms.Label StackNetLabel;
        private System.Windows.Forms.Label StackArrayLabel;
        private System.Windows.Forms.Label StackListLabel;
        private System.Windows.Forms.Label StackDynamicArrayLabel;
        private System.Windows.Forms.Label QueueArrayLabel;
        private System.Windows.Forms.Label QueueDynamicArrayLabel;
        private System.Windows.Forms.GroupBox ResultsGroupBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.CheckBox StackNetCheckBox;
        private System.Windows.Forms.CheckBox StackArrayCheckBox;
        private System.Windows.Forms.CheckBox QueueDynamicArrayCheckBox;
        private System.Windows.Forms.CheckBox QueueArrayCheckBox;
        private System.Windows.Forms.CheckBox StackListCheckBox;
        private System.Windows.Forms.CheckBox StackDynamicArrayCheckBox;
        private System.Windows.Forms.CheckBox QueueNetCheckBox;
        private System.Windows.Forms.Label QueueNetLabel;
    }
}

