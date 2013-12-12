
namespace MathSchema
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// This class defines the math model.
    /// </summary>
    [Serializable]
    [XmlRoot("Paytable")]
    public class Paytable
    {
        List<Strip> strips = new List<Strip>();
        List<PrizeDefinition> prizes = new List<PrizeDefinition>();

        [XmlArray("StripScale", IsNullable = false)]
        [XmlArrayItem("Strip", IsNullable = false)]
        public List<Strip> Strips
        {
            get
            {
                return strips;
            }
            set
            {
                strips = value;
            }
        }

        [XmlArray("PrizeScale", IsNullable = false)]
        [XmlArrayItem("Prize", IsNullable = false)]
        public List<PrizeDefinition> Prizes
        {
            get
            {
                return prizes;
            }
            set
            {
                prizes = value;
            }
        }
    }
}