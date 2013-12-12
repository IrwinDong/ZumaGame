
namespace ZumaGame.Tests
{
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using MathSchema;
    using Xunit;

    public class TestPaytable
    {
        [Fact]
        public void TestLoadUpPaytable()
        {
            var paytable = PaytableLoader.LoadPaytable("Paytable.xml");
            Assert.Equal<int>(1, paytable.Strips.Count);
            Assert.Equal<string>("Strip1", paytable.Strips[0].Name);
            Assert.Equal<int>(52, paytable.Strips[0].BaseStrip.Stops.Count);
            Assert.Equal<int>(4, paytable.Strips[0].ShootStrip.Stops.Count);
            Assert.Equal<int>(4, paytable.Prizes.Count);
        }

        [Fact]
        public void TestPaytableStructure()
        {
            Paytable paytable = new Paytable();
            Strip strip = new Strip();
            strip.Name = "Strip1";
            strip.BaseStrip = new BaseStrip();
            var stop1 = new Stop
            {
                Id = "AA",
                Weight = 1,
            };
            strip.BaseStrip.Stops.Add(stop1);

            var stop2 = new Stop
            {
                Id = "AB",
                Weight = 1,
            };
            strip.BaseStrip.Stops.Add(stop2);

            var stop3 = new Stop
            {
                Id = "AC",
                Weight = 1,
            };
            strip.BaseStrip.Stops.Add(stop3);

            strip.ShootStrip = new PickStrip();
            strip.ShootStrip.Stops.Add(new Stop
            {
                Id = "AA",
                Weight = 1,
            });

            paytable.Strips.Add(strip);

            var prize = new PrizeDefinition();
            prize.Symbol = "AA";
            prize.RequiredCount = 3;
            prize.WinAmount = 10;
            prize.WinLevel = 1;
            prize.AwardStrategy = "TimesOnBetOnBall";
            paytable.Prizes.Add(prize);
            
            var serializer = new XmlSerializer(typeof(Paytable));
            var settings = new XmlWriterSettings();
            settings.NewLineChars = System.Environment.NewLine;
            settings.Indent = true;
            var outputStr = new StringBuilder();
            using(var writer = XmlWriter.Create(outputStr, settings))
            {
                serializer.Serialize(writer, paytable);
            }

            var expectedStr = System.IO.File.ReadAllText("ExpectedTestPaytable.xml");
            Assert.Equal<string>(expectedStr, outputStr.ToString());
        }
    }
}
