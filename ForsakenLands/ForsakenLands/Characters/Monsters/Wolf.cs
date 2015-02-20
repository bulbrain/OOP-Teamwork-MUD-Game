using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForsakenLands.Characters.Monsters
{
    public class Wolf : Monster
    {
        private const int WOLF_DEFAULT_ATTACK_POINTS = 200;
        private const int WOLF_DEFAULT_DEFENCE_POINTS = 200;
        private const int WOLF_DEFAULT_HEALTH_POINTS = 150;
        private const int WOLF_DEFAULT_MANA_POINTS = 100;
        private const int WOLF_DEFAULT_ACCURACY = 9;
        private const int WOLF_DEFAULT_EVASION = 2;
        private const int WOLF_DEFAULT_RANGE = 2;
        private const int WOLF_DEFAULT_LIVES = 1;

        public Wolf (int id) : base(id, WOLF_DEFAULT_ATTACK_POINTS, 
                                        WOLF_DEFAULT_DEFENCE_POINTS, 
                                        WOLF_DEFAULT_HEALTH_POINTS,
                                        WOLF_DEFAULT_MANA_POINTS,
                                        WOLF_DEFAULT_ACCURACY, 
                                        WOLF_DEFAULT_EVASION, 
                                        WOLF_DEFAULT_RANGE, 
                                        WOLF_DEFAULT_LIVES)
        {
        }
    }
}
