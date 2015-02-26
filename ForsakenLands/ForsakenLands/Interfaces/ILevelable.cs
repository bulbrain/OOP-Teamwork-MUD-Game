using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForsakenLands.Interfaces
{
    public interface ILevelable
    {
        int Level { get; }

        int CalculateStatAccordingToLevel(int stat);
    }
}