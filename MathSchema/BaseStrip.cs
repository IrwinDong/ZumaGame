
namespace MathSchema
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [Serializable]
    public class BaseStrip
    {
        private List<Stop> stops = new List<Stop>();

        [XmlElement("Stop")]
        public List<Stop> Stops
        {
            get { return stops; }
            set { stops = value; }
        }
    }
}
