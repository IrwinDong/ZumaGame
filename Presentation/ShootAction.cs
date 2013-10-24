using System;
using System.Collections.Generic;

namespace Outcome
{
    [Serializable]
    public struct ShootAction
    {
        public List<int> Targets;
        public string Action;
        public uint WinAmount;
    }
}
