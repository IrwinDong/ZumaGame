using System;
using System.Collections.Generic;

namespace Outcome
{
    [Serializable]
    public class BallStrip
    {
        public List<Ball> Balls { get; private set; }

        public BallStrip()
        {
            Balls = new List<Ball>();
        }
    }
}
