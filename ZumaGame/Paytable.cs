
namespace ZumaGame
{
    using System.Collections.Generic;
    using Math;

    /// <summary>
    /// This class defines the math model.
    /// </summary>
    public class Paytable
    {
        public List<Strip> Strips { get; set; }
        public List<PrizePattern> PrizePatterns { get; set; }
    }
}
