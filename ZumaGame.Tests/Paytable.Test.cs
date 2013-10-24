using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using Math;

namespace ZumaGame.Tests
{
    using NUnit.Framework;

    [TestFixture]
    class TestPaytable
    {
        [Test]
        public void TestLoadUpPaytable()
        {
            var paytable = PaytableLoader.LoadPaytable("Paytable.xml");
            
        }

        [Test]
        public void TestPaytableStructure()
        {
            Paytable paytable = new Paytable();
            Strip strip = new Strip();
            strip.Name = "Strip1";
            strip.Balls = new List<string>{"AA", "AB", "AC"};
            paytable.Strips = new List<Strip>{strip};
            PrizePattern prize = new PrizePattern();
            PrizedBall ball = new PrizedBall();
            ball.Name = "AA";
            ball.RequiredCount = 3;
            prize.PrizedSymbols = new List<PrizedBall> {ball};
            AwardDefinition award = new AwardDefinition();
            award.Count = 3;
            award.WinAmount = 10;
            award.WinLevel = 1;
            prize.AwardDefinitions = new List<AwardDefinition> { award };

            paytable.PrizePatterns = new List<PrizePattern>{prize};
            
            var serializer = new XmlSerializer(typeof(Paytable));
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = System.Text.Encoding.UTF8;
            settings.NewLineChars = System.Environment.NewLine;
            settings.Indent = true;
            using(var writer = XmlWriter.Create("TestPaytable.xml", settings))
            {
                serializer.Serialize(writer, paytable);
            }
        }
    }
}
