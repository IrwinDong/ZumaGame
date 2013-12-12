
namespace ZumaGame
{
    using System.Xml;
    using System.Xml.Serialization;
    using MathSchema;

    public class PaytableLoader
    {
        public static Paytable LoadPaytable(string paytablePath)
        {
            var serializer = new XmlSerializer(typeof(Paytable));
            Paytable paytable;
            using(var xmlReader = new XmlTextReader(paytablePath))
            {
                paytable = serializer.Deserialize(xmlReader) as Paytable;
            }
            return paytable;
        }
    }
}