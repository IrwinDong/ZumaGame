
namespace MathSchema
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Strip
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("BaseStrip", IsNullable = false)]
        public BaseStrip BaseStrip { get; set; }

        [XmlElement("ShootStrip", IsNullable=false)]
        public PickStrip ShootStrip { get; set; }
    }
}
