using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace Ashure_Library
{
    public class PlayListHandler : IPlayListHandler
    {
        IWMPPlaylist playList;
        IWMPMedia track;
        
        
        private List<string> tracksURLs = new List<string>();


        public void SaveCurrentPlayList(ListView lView) 
        {
            if (!IsPlayListEmpty(lView))
            {
                SaveMedia("PlayList.wpl", lView);
            }
        }

        public void SaveAsPlayList(ListView lView)
        {
            if (!IsPlayListEmpty(lView))
            {
                string playlistFileName = null;
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

                SaveFileDialog1.Title = "Save Windows Playlist As...";
                SaveFileDialog1.Filter = "wpl files (*.wpl)|*.wpl";
                SaveFileDialog1.DefaultExt = "wpl";
                SaveFileDialog1.CreatePrompt = false;
                SaveFileDialog1.OverwritePrompt = true;

                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(SaveFileDialog1.FileName) == false)
                    {
                        playlistFileName = SaveFileDialog1.FileName;
                    }
                }

                SaveFileDialog1.Dispose();

                SaveMedia(playlistFileName, lView);
            }
        }

        public void LoadPlayList(ListView lView, AxWMPLib.AxWindowsMediaPlayer mediaPlayer) 
        {
            ArrayList nowPlaylist = new ArrayList();

            lView.Items.Clear();
            OpenFileDialog openPlaylist = new OpenFileDialog();
            openPlaylist.Filter = "wpl files (*.wpl)|*.wpl";
            openPlaylist.ShowDialog();
            readPlaylist readList = new readPlaylist();
            readList.playListPath = openPlaylist.FileName;
            nowPlaylist = readList.PlayList;

            for (int i = 0; i < nowPlaylist.Count; i++)
            {
                string[] LoadedAudioList = new string[2];

                LoadedAudioList[0] = System.IO.Path.GetFileName(Convert.ToString(nowPlaylist[i]));
                LoadedAudioList[1] = Convert.ToString(nowPlaylist[i]);

                ListViewItem listViewI = new ListViewItem(LoadedAudioList);
                lView.Items.Add(listViewI);
            }
            RefreshCurrentPlayList(lView, mediaPlayer);
        }
               
        public void ClearPlayList(ListView lView) 
        {
            if (!IsPlayListEmpty(lView))
            {
                lView.Clear();
                MessageBox.Show("The Playlist was cleared", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        public void SaveMedia(string fileName, ListView lView)
        {
            FileStream fs = File.Create(fileName);
            
            if (String.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Please choose file!");
                return;
            }

            StreamWriter sw = new StreamWriter(fs);
            try
            {
                sw.WriteLine("<?wpl version=\"1.0\"?>");
                sw.WriteLine("<smil>");
                sw.WriteLine("\t<head>");
                sw.WriteLine("\t\t<meta name=\"Generator\" content=\"Microsoft Windows Media Player -- 12.0.7601.18840\"/>");
                sw.WriteLine("\t</head>");
                sw.WriteLine("\t<body>");
                sw.WriteLine("\t\t<seq>");

                // Record media URLs
                for (int i = 0; i < lView.Items.Count; i++)
                {
                    string filePath = lView.Items[i].SubItems[1].Text;
                    sw.WriteLine("\t\t\t<media src=\"" + filePath + "\"/>");
                }

                sw.WriteLine("\t\t</seq>");
                sw.WriteLine("\t</body>");
                sw.WriteLine("</smil>");

                MessageBox.Show("The playlist was successfully saved", "Create Playlis");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Create Playlist: Error");
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }

        public void RefreshCurrentPlayList(ListView lView, AxWMPLib.AxWindowsMediaPlayer mediaPlayer)
        {
            playList = mediaPlayer.playlistCollection.newPlaylist("PlayList");


            for (int i = 0; i < lView.Items.Count; i++)
            {
                int subItem = 1;
                string currentTrackSourceURL = lView.Items[i].SubItems[subItem].Text;
                track = mediaPlayer.newMedia(currentTrackSourceURL);
                tracksURLs.Add(currentTrackSourceURL);
                playList.appendItem(track);
                mediaPlayer.currentPlaylist.appendItem(track);
                

            }
        }

        public bool IsPlayListEmpty(ListView lVliew)
        {
            if (lVliew.Items.Count == 0)
            {
                MessageBox.Show("The playlist is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void ExportPlayList() { }


    }
}
