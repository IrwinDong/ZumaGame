
namespace Presentation
{
    /// <summary>
    /// This interface is used to motive the presentation and the state machine.
    /// </summary>
    public interface IPresentationEngine
    {
        /// <summary>
        /// Retrieve the updated ball strip.
        /// </summary>
        /// <returns>The updated ball strip.</returns>
        BallStrip Update();
    }
}
