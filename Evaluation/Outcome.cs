
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evaluation
{
    public class Outcome
    {
        public List<string> Strip { get; private set; }
        public List<Shoot> Shoots { get; private set; }

        public Outcome(List<string> strip, List<Shoot> shoots)
        {
            if(strip == null)
            {
                throw new ArgumentNullException("strip");
            }
            if(shoots == null)
            {
                throw new ArgumentNullException("shoots");
            }

            var invalidHits = shoots.Where((t, index) => t.Position >= Strip.Count + index).Any();

            if(invalidHits)
            {
                throw new ArgumentException(string.Format("Invalid shoots({0})", BuildShootString(shoots)));
            }

            Strip = strip;
            Shoots = shoots;
        }

        private string BuildShootString(List<Shoot> shoots)
        {
            var shootString = new StringBuilder();
            foreach(var shoot in shoots)
            {
                shootString.Append(shoot);
                shootString.Append(",");
            }

            if(shootString.Length > 0)
            {
                shootString.Remove(shootString.Length - 1, 1);
            }
            return shootString.ToString();
        }
    }
}
