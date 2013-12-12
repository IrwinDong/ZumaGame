
namespace Presentation
{
    using System;

    /// <summary>
    /// A metronome used to drive the presentation and logic moving on in a synchronized way.
    /// </summary>
    public interface IMetronome
    {
        event EventHandler Clicked;
    }
}
