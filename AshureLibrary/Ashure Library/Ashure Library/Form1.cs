using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using System.Runtime.InteropServices;


namespace Ashure_Library
{
    public partial class AshureLibraryForm : Form
    {
 
        PlayListHandler playListHandler1 = new PlayListHandler();
        SearchAudio searchAudio1 = new SearchAudio();
        AudioListHandler audioListHandler1 = new AudioListHandler();

        public AshureLibraryForm()
        {
            InitializeComponent();
            //Menu items events
            this.simpleSearchToolStripMenuItem.Click += FindAudioButton_Click;
            this.saveToCurrentPlaylistToolStripMenuItem.Click += SaveCurrentPlaylistButton_Click;
            this.loadPlToolStripMenuItem.Click += LoadPlaylistButton_Click;
            this.clearPlaylistToolStripMenuItem.Click += RemoveButton_Click;
            this.saveToNewPlaylistToolStripMenuItem.Click += SaveToNewPlaylistButton_Click;

            // Context Menu item events
            this.AddNewFileContextMenu.Click += FindAudioButton_Click;
            this.removeSelectedToolStripMenuItem.Click += RemoveButton_Click;
            this.clearPlaylistToolStripMenuItem1.Click += clearPlaylistToolStripMenuItem_Click;
                        
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FindAudioButton_Click(object sender, EventArgs e)
        {
            searchAudio1.SimpleSearch(CurrentListView, mediaPlayer);
        } 

       
        private void CurrentListView_DoubleClick(object sender, EventArgs e)
        {
            audioListHandler1.SelectCurentItem(CurrentListView, mediaPlayer);
        }

        private void CurrentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //RemoveButton.Enabled = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Ashure Library - v.0.1 - Demo Version","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void SaveCurrentPlaylistButton_Click(object sender, EventArgs e)
        {
            
            playListHandler1.SaveCurrentPlayList(CurrentListView);
        }

        private void LoadPlaylistButton_Click(object sender, EventArgs e)
        {
            playListHandler1.LoadPlayList(CurrentListView, mediaPlayer);
        }
            
        private void clearPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playListHandler1.ClearPlayList(CurrentListView);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            audioListHandler1.RemoveSelectedItem(CurrentListView);
        }
        
        private void SaveToNewPlaylistButton_Click(object sender, EventArgs e)
        {
            playListHandler1.SaveAsPlayList(CurrentListView);
        }


        private void extendedSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchAudio1.ExtendetSearch();
        }


        private void CurrentListView_MouseClick(object sender, MouseEventArgs e)
        {
            audioListHandler1.ContextMenuPossion(CurrentListView, e, conMenu);
        }

        private void FindSongButton_Click(object sender, EventArgs e)
        {
            audioListHandler1.SearchSongInList(CurrentListView, FindSongTextBox.Text);
        }
    }
}
