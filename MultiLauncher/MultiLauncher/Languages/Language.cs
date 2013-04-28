using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MultiLauncher.Languages
{
    public class Language
    {
        [XmlAttribute("Language")]
        public string language;

    }
}
