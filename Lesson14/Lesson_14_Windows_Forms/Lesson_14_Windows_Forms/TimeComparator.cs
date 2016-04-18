using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_14_Windows_Forms
{
    public partial class TimeComparatorForm : Form
    {
        public TimeComparatorForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StackArrayLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Stack based on .Net
            if (StackNetCheckBox.Checked)
            {
                MyStackNet mySN = new MyStackNet();
                long time = mySN.Start();
                StackNetLabel.Text = String.Format(time + " ms");
            }
            
            
            // Stack based on Array
            if (StackArrayCheckBox.Checked)
            {
                MyStackArray mySA = new MyStackArray();
                long time = mySA.StartArray();
                StackArrayLabel.Text = String.Format(time + " ms");
            }

            // Stack based on Dynamic Array
            if (StackDynamicArrayCheckBox.Checked)
            {
                MyStackDynamicArray mySDA = new MyStackDynamicArray();
                long time = mySDA.Start();
                StackDynamicArrayLabel.Text = String.Format(time + " ms");
            }

            // Stack based on List
            if (StackListCheckBox.Checked)
            {
                MyStackList mySL = new MyStackList();
                long time = mySL.Start();
                StackListLabel.Text = String.Format(time + " ms");
            }

            // Queue based on .Net
            if (QueueNetCheckBox.Checked)
            {
                MyQueueNet myQN = new MyQueueNet();
                long time = myQN.StartQueueNet();
                QueueNetLabel.Text = String.Format(time + " ms");
            }
            
            // Queue based on Array
            if (QueueArrayCheckBox.Checked)
            {
                MyQueueArray myQA = new MyQueueArray();
                long time = myQA.StartQueueArray();
                QueueArrayLabel.Text = String.Format(time + " ms");
            }

            // Queue based on Dynamic Array
            if (QueueDynamicArrayCheckBox.Checked)
            {
                MyQueueDynamicArray myQDA = new MyQueueDynamicArray();
                long time = myQDA.StartDynamicQueue();
                QueueDynamicArrayLabel.Text = String.Format(time + " ms");
            }

        }
    }
}
