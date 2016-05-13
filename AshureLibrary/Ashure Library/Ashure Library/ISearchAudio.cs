using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ashure_Library
{
    public interface ISearchAudio
    {
        void SimpleSearch(ListView lView, AxWMPLib.AxWindowsMediaPlayer mediaPlayer);
    }
}
