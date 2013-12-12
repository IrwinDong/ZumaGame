
using System;

namespace Presentation
{
    [Serializable]
    public class Ball
    {
        public string Name { get; private set; }

        public BallState State { get; private set; }

        public Ball(string name)
        {
            Name = name;
        }

        public Ball(string name, BallState state)
        {
            Name = name;
            State = state;
        }

        public virtual void Display()
        {
            State = BallState.Display;
        }

        public virtual void Hide()
        {
            State = BallState.Hidden;
        }
    }
}
