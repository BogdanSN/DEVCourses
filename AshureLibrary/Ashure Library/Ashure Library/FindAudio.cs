using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ashure_Library
{
    public partial class FindAudioForm : Form
    {
        
        public FindAudioForm()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fBD = new FolderBrowserDialog();
            DialogResult result = fBD.ShowDialog();

            if (result == DialogResult.OK)
            {
                BrowseTextBox.Text = fBD.SelectedPath;
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string SearchFileName = null;
            string SearchFileFormat = FileFormatCheckBox.Text;

            if (string.IsNullOrEmpty(FileNameText.Text) == null)
            {
                SearchFileName = "";
            }
            else
            {
                SearchFileName = FileNameText.Text;
            }

            string[] filePaths = Directory.GetFiles(BrowseTextBox.Text+SearchFileName, SearchFileFormat,SearchOption.AllDirectories);

            for (int i = 0; i < filePaths.Count(); i++)
            {
                ResultListBox.Items.Add(filePaths[i]+"\n");
            }
            
        }
    }
}
