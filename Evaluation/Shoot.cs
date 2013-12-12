
using System;
using MathSchema;

namespace Evaluation
{
    /// <summary>
    /// This class represent a ball shoot.
    /// </summary>
    public class Shoot
    {
        /// <summary>
        /// The ball name.
        /// </summary>
        public string Ball { get; private set; }
        
        /// <summary>
        /// The position shoot to the strip.
        /// </summary>
        public int Position { get; private set; }

        /// <summary>
        /// The award this shoot is hitting.
        /// </summary>
        public AwardDefinition AwardDefinition { get; private set; }

        /// <summary>
        /// Construct a shoot.
        /// </summary>
        /// <param name="ball">The ball to shoot.</param>
        /// <param name="position">The position shoot to in the strip.</param>
        /// <param name="awardDefinition">The award of this shoot.</param>
        public Shoot(string ball, int position, AwardDefinition awardDefinition)
        {
            if(ball == null)
            {
                throw new ArgumentNullException("ball");
            }

            if(awardDefinition == null)
            {
                throw new ArgumentNullException("awardDefinition");
            }

            Ball = ball;
            Position = position;
            AwardDefinition = awardDefinition;
        }
    }
}
