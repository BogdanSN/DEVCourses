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
            try
            {
                for (int i = 0; i < filePaths.Count(); i++)
                {
                    ListViewItem lVItemp = GetFileInfo(filePaths[i]);
                    ResultListView.Items.Add(lVItemp);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not read file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private ListViewItem GetFileInfo(string fileName)
        {
            ListViewItem fileInfoList;
            byte[] b = new byte[128];
            
            FileStream fs = new FileStream(fileName, FileMode.Open);
            fs.Seek(-128, SeekOrigin.End);
            fs.Read(b, 0, 128);
//            bool isSet = false;
            string sFlag = System.Text.Encoding.Default.GetString(b, 0, 3);
            if (sFlag.CompareTo("TAG") == 0)
            {
                System.Console.WriteLine("Tag   is   setted! ");
//                isSet = true;

                //if (isSet)
                //{
                
                    string[] fileInfo = new string[7];
                    fileInfo[0] = Path.GetFileName(fileName);                           //FileName
                    fileInfo[1] = System.Text.Encoding.Default.GetString(b, 3, 30);     //sTitle
                    fileInfo[2] = System.Text.Encoding.Default.GetString(b, 33, 30);    //sSinger
                    fileInfo[3] = System.Text.Encoding.Default.GetString(b, 63, 30);    //sAlbum
                    fileInfo[4] = System.Text.Encoding.Default.GetString(b, 93, 4);     //sYear 
                    fileInfo[5] = System.Text.Encoding.Default.GetString(b, 97, 30);    //sComments
                    fileInfo[6] = fileName;                                             //sLocation

                    return fileInfoList = new ListViewItem(fileInfo);
                }
                else
                {
                    string[] fileInfo = new string[7];
                    fileInfo[0] = Path.GetFileName(fileName);                           //FileName
                    fileInfo[1] = "Unknown";                                            //sTitle
                    fileInfo[2] = "Unknown";                                            //sSinger
                    fileInfo[3] = "Unknown";                                            //sAlbum
                    fileInfo[4] = "Unknown";                                            //sYear 
                    fileInfo[5] = "Unknown";                                            //sComments
                    fileInfo[6] = fileName;                                             //sLocation

                    return fileInfoList = new ListViewItem(fileInfo);
                }
            }
        }
    }
