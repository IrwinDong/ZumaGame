
using System;
using System.Xml.Serialization;

namespace Math
{
    using System.Collections.Generic;

    [Serializable]
    public class Strip
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("Ball")]
        public List<string> Balls { get; set; }
    }
}
