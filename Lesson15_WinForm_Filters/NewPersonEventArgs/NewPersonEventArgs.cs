using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_WinForm_Filters
{
    public class NewPersonEventArgs : EventArgs
    {
        public string person { set; get; }
        public DateTime genTime { set; get; }
    }
}
