using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections;

namespace Ashure_Library
{
    public class readPlaylist
    {
        private ArrayList name = new ArrayList();
        private string m_xmlFile;

        public string playListPath
        {
            get
            {
                return m_xmlFile;
            }
            set
            {
                m_xmlFile = value;
                Makeplaylist();
            }
        }
                
        public ArrayList PlayList
        {
            get
            {
                return name;
            }
        }
                
        private void Makeplaylist()
        {
            XmlTextReader readList = new XmlTextReader(m_xmlFile);
            while (readList.Read())
            {
                if (readList.NodeType == XmlNodeType.Element)
                {
                    if (readList.LocalName.Equals("media"))
                    {
                        name.Add(readList.GetAttribute(0).ToString());
                    }
                }
            }
        }
    }
    }
