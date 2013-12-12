
namespace MathSchema
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Stop
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("weight")]
        public uint Weight { get; set; }
    }
}
