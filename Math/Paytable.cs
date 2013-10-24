
using System;
using System.Xml.Serialization;

namespace Math
{
    using System.Collections.Generic;

    /// <summary>
    /// This class defines the math model.
    /// </summary>
    [Serializable]
    [XmlRoot("Paytable")]
    public class Paytable
    {
        [XmlArray("StripDefinition")]
        [XmlArrayItem("Strip")]
        public List<Strip> Strips { get; set; }

        [XmlArray("PrizeDefinition")]
        [XmlArrayItem("PrizePattern")]
        public List<PrizePattern> PrizePatterns { get; set; }
    }
}
