using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Ashure_Library
{
    public interface IPlayListHandler
    {
        void SaveCurrentPlayList(ListView lView);
        void SaveAsPlayList(ListView lView);
        void LoadPlayList(ListView lView, AxWMPLib.AxWindowsMediaPlayer mediaPlayer);
        void ClearPlayList(ListView lView);
        void ExportPlayList();
    }
}
