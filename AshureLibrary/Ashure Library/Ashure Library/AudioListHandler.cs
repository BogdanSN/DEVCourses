using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ashure_Library
{
    public class AudioListHandler : IAudioListHandler
    {
        public void SelectCurentItem(ListView lView, AxWMPLib.AxWindowsMediaPlayer mediaPlayer)
        {
            string selectedFile = lView.FocusedItem.SubItems[1].Text;
            mediaPlayer.URL = selectedFile;
        }

        public void RemoveSelectedItem(ListView lView )
        {
            PlayListHandler plh = new PlayListHandler();
            if (!plh.IsPlayListEmpty(lView))
            {
                if (lView.SelectedItems.Count > 0)
                {
                    for (int i = lView.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem itm = lView.SelectedItems[i];
                        lView.Items[itm.Index].Remove();
                    }

                }
            }
        }

        public void ContextMenuPossion(ListView lView, MouseEventArgs e, ContextMenuStrip conMenu)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lView.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    conMenu.Show(Cursor.Position);
                }
            } 
        }

        public void SearchSongInList(ListView lView, string songTitle)
        {
            if (String.IsNullOrEmpty(songTitle))
            {
                MessageBox.Show("Please specify song","Waring",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < lView.Items.Count; i++)
            {
                if (Regex.IsMatch(lView.Items[i].Text, songTitle, RegexOptions.IgnoreCase))
                {
                    lView.Select();
                    lView.Items[i].Selected = true;

                }
                else
                {
                    MessageBox.Show("The specified song isn't found", "Upset :(", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                }
            }
        }

    }
}
