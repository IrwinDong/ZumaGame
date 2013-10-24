
using System.Xml.Serialization;

namespace Math
{
    using System;

    /// <summary>
    /// This class represents an award, including the empty award.
    /// </summary>
    [Serializable]
    public class AwardDefinition
    {
        /// <summary>
        /// The win amount.
        /// </summary>
        [XmlAttribute("winAmount")]
        public uint WinAmount { get; set; }

        [XmlAttribute("count")]
        public uint Count { get; set; }

        [XmlAttribute("winLevel")]
        public uint WinLevel { get; set; }
    }
}
