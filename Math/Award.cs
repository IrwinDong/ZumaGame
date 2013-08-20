
namespace Math
{
    using System;

    /// <summary>
    /// This class represents an award, including the empty award.
    /// </summary>
    public class Award
    {
        /// <summary>
        /// The empty award.
        /// </summary>
        public static readonly Award Empyt = new Award();

        /// <summary>
        /// The win amount.
        /// </summary>
        public uint WinAmount { get; set; }

        /// <summary>
        /// The constructor of the empty award.
        /// </summary>
        private Award()
        {
        }

        /// <summary>
        /// Construct the award with the specified win amount.
        /// </summary>
        /// <param name="amount">The win amount.</param>
        public Award(uint amount)
        {
            if(amount == 0)
            {
                throw new ArgumentException("Win amount must be greater than zero.", "amount");
            }

            WinAmount = amount;
        }
    }
}
