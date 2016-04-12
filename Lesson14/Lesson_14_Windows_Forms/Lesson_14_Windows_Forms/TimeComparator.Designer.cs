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
            this.SuspendLayout();
            // 
            // MethodsGroupBox
            // 
            this.MethodsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MethodsGroupBox.Name = "MethodsGroupBox";
            this.MethodsGroupBox.Size = new System.Drawing.Size(655, 293);
            this.MethodsGroupBox.TabIndex = 0;
            this.MethodsGroupBox.TabStop = false;
            this.MethodsGroupBox.Text = "AvaliableMethods";
            // 
            // TimeComparatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 472);
            this.Controls.Add(this.MethodsGroupBox);
            this.Name = "TimeComparatorForm";
            this.Text = "TimeComparator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MethodsGroupBox;
    }
}

