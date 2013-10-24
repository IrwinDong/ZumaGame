using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Math
{
    [Serializable]
    public class PrizePattern
    {
        [XmlElement("PrizedBall")]
        public List<PrizedBall> PrizedSymbols { get; set; }

        [XmlElement("AwardDefinition")]
        public List<AwardDefinition> AwardDefinitions { get; set; }
    }
}
