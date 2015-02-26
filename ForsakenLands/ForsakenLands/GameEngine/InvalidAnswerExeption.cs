using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForsakenLands.GameEngine
{
    public class InvalidAnswerExeption : Exception
    {
        public InvalidAnswerExeption()
        {
        }
        public InvalidAnswerExeption(string message)
            : base(message)
        {
        }

    }
}
