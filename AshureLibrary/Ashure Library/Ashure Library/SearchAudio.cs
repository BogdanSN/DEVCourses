using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Ashure_Library
{
    public class SearchAudio : ISearchAudio
    {
        PlayListHandler plh = new PlayListHandler();

        public void SimpleSearch(ListView lView, AxWMPLib.AxWindowsMediaPlayer mediaPlayer) 
        {
            Stream audioStream = null;
            OpenFileDialog openFileDial = new OpenFileDialog();

            openFileDial.Filter = "MP3 Audio File (*.mp3)|*.mp3|Windows Media Audio (*.WMA)|*.WMA|Waveform Audio Format (*.WAV)|*.wav";
            openFileDial.FilterIndex = 1;
            openFileDial.RestoreDirectory = true;
            openFileDial.Multiselect = true;

            if (openFileDial.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                        using (audioStream)
                        {
                            string[] fileNameAndPath = openFileDial.FileNames;
                            string[] fileName = openFileDial.SafeFileNames;

                            for (int i = 0; i < openFileDial.SafeFileNames.Count(); i++)
                            {
                                string[] currentAudioList = new string[2];

                                currentAudioList[0] = fileName[i];
                                currentAudioList[1] = fileNameAndPath[i];

                                ListViewItem listViewI = new ListViewItem(currentAudioList);
                                lView.Items.Add(listViewI);

                            }

                        }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read files from Disk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         plh.RefreshCurrentPlayList(lView, mediaPlayer);

        }

        public void ExtendetSearch() 
        {
            FindAudioForm extendSearch = new FindAudioForm();
            extendSearch.Show();

        }
    }
}
