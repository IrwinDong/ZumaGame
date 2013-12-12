
namespace MathSchema
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class PrizeDefinition
    {
        [XmlAttribute("symbol")]
        public string Symbol { get; set; }

        [XmlAttribute("requiredCount")]
        public uint RequiredCount { get; set; }

        [XmlAttribute("winAmount")]
        public uint WinAmount { get; set; }

        [XmlAttribute("awardStrategy")]
        public string AwardStrategy { get; set; }

        [XmlAttribute("winLevel")]
        public uint WinLevel { get; set; }
    }
}
