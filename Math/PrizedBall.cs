
using System;
using System.Xml.Serialization;

namespace Math
{
    [Serializable]
    public class PrizedBall
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("requiredCount")]
        public uint RequiredCount { get; set; }
    }
}
