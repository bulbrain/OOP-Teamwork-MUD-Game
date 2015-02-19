using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForsakenLands.Characters.Monsters
{
    public class Vampire : Monster
    {
        private const int VAMPIRE_DEFAULT_ATTACK_POINTS = 150;
        private const int VAMPIRE_DEFAULT_DEFENCE_POINTS = 150;
        private const int VAMPIRE_DEFAULT_HEALTH_POINTS = 200;
        private const int VAMPIRE_DEFAULT_ACCURACY = 8;
        private const int VAMPIRE_DEFAULT_EVASION = 2;
        private const int VAMPIRE_DEFAULT_RANGE = 2;
        private const int VAMPIRE_DEFAULT_LIVES = 2;

        public Vampire (int id) : base(id, VAMPIRE_DEFAULT_ATTACK_POINTS, 
                                           VAMPIRE_DEFAULT_DEFENCE_POINTS, 
                                           VAMPIRE_DEFAULT_HEALTH_POINTS, 
                                           VAMPIRE_DEFAULT_ACCURACY, 
                                           VAMPIRE_DEFAULT_EVASION, 
                                           VAMPIRE_DEFAULT_RANGE, 
                                           VAMPIRE_DEFAULT_LIVES)
        {
        }
    }
}
