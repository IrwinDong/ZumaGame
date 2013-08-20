
namespace Math
{
    using System;

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
        /// The award of this shoot.
        /// </summary>
        public Award Award { get; private set; }

        /// <summary>
        /// Construct a shoot.
        /// </summary>
        /// <param name="ball">The ball to shoot.</param>
        /// <param name="position">The position shoot to in the strip.</param>
        /// <param name="award">The award of this shoot.</param>
        public Shoot(string ball, int position, Award award)
        {
            if(ball == null)
            {
                throw new ArgumentNullException("ball");
            }

            if(award == null)
            {
                throw new ArgumentNullException("award");
            }

            Ball = ball;
            Position = position;
            Award = award;
        }
    }
}
