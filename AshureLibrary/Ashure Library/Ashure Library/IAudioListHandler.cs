using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ashure_Library
{
    public interface IAudioListHandler
    {
        void SelectCurentItem(ListView lView, AxWMPLib.AxWindowsMediaPlayer mediaPlayer);
        void RemoveSelectedItem(ListView lView );
        void ContextMenuPossion(ListView lView, MouseEventArgs e, ContextMenuStrip conMenu);
        void SearchSongInList(ListView lView, string songTitle);
    }
}
