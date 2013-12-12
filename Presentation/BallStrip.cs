using System;
using System.Collections.Generic;

namespace Presentation
{
    [Serializable]
    public class BallStrip
    {
        public List<Ball> Balls { get; private set; }

        public BallStrip()
        {
            Balls = new List<Ball>();
        }

        public List<Ball> Update()
        {
            return null;
        }
    }
}