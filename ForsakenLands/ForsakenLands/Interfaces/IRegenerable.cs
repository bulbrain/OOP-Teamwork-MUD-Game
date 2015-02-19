using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForsakenLands.Interfaces
{
    interface IRegenerable
    {
        int Lives { get; set; }

        void AddLive();

        void RemoveLive();

        void Regenerate();
    }
}
