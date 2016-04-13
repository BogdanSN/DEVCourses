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
            this.StackDynamicArray = new System.Windows.Forms.Label();
            this.QueueArrayLabel = new System.Windows.Forms.Label();
            this.QueueDynamicArrayLabel = new System.Windows.Forms.Label();
            this.ResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MethodsGroupBox
            // 
            this.MethodsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MethodsGroupBox.Name = "MethodsGroupBox";
            this.MethodsGroupBox.Size = new System.Drawing.Size(196, 121);
            this.MethodsGroupBox.TabIndex = 0;
            this.MethodsGroupBox.TabStop = false;
            this.MethodsGroupBox.Text = "AvaliableMethods:";
            // 
            // StackNetLabel
            // 
            this.StackNetLabel.AutoSize = true;
            this.StackNetLabel.Location = new System.Drawing.Point(6, 20);
            this.StackNetLabel.Name = "StackNetLabel";
            this.StackNetLabel.Size = new System.Drawing.Size(32, 13);
            this.StackNetLabel.TabIndex = 1;
            this.StackNetLabel.Text = " 0 ms";
            this.StackNetLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // StackArrayLabel
            // 
            this.StackArrayLabel.AutoSize = true;
            this.StackArrayLabel.Location = new System.Drawing.Point(6, 34);
            this.StackArrayLabel.Name = "StackArrayLabel";
            this.StackArrayLabel.Size = new System.Drawing.Size(32, 13);
            this.StackArrayLabel.TabIndex = 2;
            this.StackArrayLabel.Text = " 0 ms";
            this.StackArrayLabel.Click += new System.EventHandler(this.StackArrayLabel_Click);
            // 
            // StackListLabel
            // 
            this.StackListLabel.AutoSize = true;
            this.StackListLabel.Location = new System.Drawing.Point(9, 49);
            this.StackListLabel.Name = "StackListLabel";
            this.StackListLabel.Size = new System.Drawing.Size(29, 13);
            this.StackListLabel.TabIndex = 3;
            this.StackListLabel.Text = "0 ms";
            // 
            // StackDynamicArray
            // 
            this.StackDynamicArray.AutoSize = true;
            this.StackDynamicArray.Location = new System.Drawing.Point(9, 65);
            this.StackDynamicArray.Name = "StackDynamicArray";
            this.StackDynamicArray.Size = new System.Drawing.Size(29, 13);
            this.StackDynamicArray.TabIndex = 4;
            this.StackDynamicArray.Text = "0 ms";
            // 
            // QueueArrayLabel
            // 
            this.QueueArrayLabel.AutoSize = true;
            this.QueueArrayLabel.Location = new System.Drawing.Point(6, 81);
            this.QueueArrayLabel.Name = "QueueArrayLabel";
            this.QueueArrayLabel.Size = new System.Drawing.Size(32, 13);
            this.QueueArrayLabel.TabIndex = 5;
            this.QueueArrayLabel.Text = " 0 ms";
            // 
            // QueueDynamicArrayLabel
            // 
            this.QueueDynamicArrayLabel.AutoSize = true;
            this.QueueDynamicArrayLabel.Location = new System.Drawing.Point(9, 97);
            this.QueueDynamicArrayLabel.Name = "QueueDynamicArrayLabel";
            this.QueueDynamicArrayLabel.Size = new System.Drawing.Size(29, 13);
            this.QueueDynamicArrayLabel.TabIndex = 6;
            this.QueueDynamicArrayLabel.Text = "0 ms";
            // 
            // ResultsGroupBox
            // 
            this.ResultsGroupBox.Controls.Add(this.StackNetLabel);
            this.ResultsGroupBox.Controls.Add(this.QueueDynamicArrayLabel);
            this.ResultsGroupBox.Controls.Add(this.StackArrayLabel);
            this.ResultsGroupBox.Controls.Add(this.QueueArrayLabel);
            this.ResultsGroupBox.Controls.Add(this.StackListLabel);
            this.ResultsGroupBox.Controls.Add(this.StackDynamicArray);
            this.ResultsGroupBox.Location = new System.Drawing.Point(214, 12);
            this.ResultsGroupBox.Name = "ResultsGroupBox";
            this.ResultsGroupBox.Size = new System.Drawing.Size(67, 121);
            this.ResultsGroupBox.TabIndex = 7;
            this.ResultsGroupBox.TabStop = false;
            this.ResultsGroupBox.Text = "Results:";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 139);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(269, 23);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // TimeComparatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 176);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ResultsGroupBox);
            this.Controls.Add(this.MethodsGroupBox);
            this.Name = "TimeComparatorForm";
            this.Text = "TimeComparator";
            this.ResultsGroupBox.ResumeLayout(false);
            this.ResultsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MethodsGroupBox;
        private System.Windows.Forms.Label StackNetLabel;
        private System.Windows.Forms.Label StackArrayLabel;
        private System.Windows.Forms.Label StackListLabel;
        private System.Windows.Forms.Label StackDynamicArray;
        private System.Windows.Forms.Label QueueArrayLabel;
        private System.Windows.Forms.Label QueueDynamicArrayLabel;
        private System.Windows.Forms.GroupBox ResultsGroupBox;
        private System.Windows.Forms.Button StartButton;
    }
}

