

namespace Lottery
{
    /// <summary>
    /// The class draws award from the pool.
    /// </summary>
    public interface ILotteryPool
    {
        LotteryTicket DrawTicket();
    }
}
