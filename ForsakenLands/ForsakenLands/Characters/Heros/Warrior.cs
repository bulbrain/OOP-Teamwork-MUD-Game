﻿namespace ForsakenLands.Characters.Heros
{
    using System.Collections.Generic;

    using ForsakenLands.Items;

    public class Warrior : Hero
    {
        public Warrior()
            : base(1, 100, 100, 100, 0, 0, 0, 0, null) // just for testing; to be changed later
        {
        }

        public Warrior(
            int id,
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int manaPoints,
            int accuracy,
            int evasion,
            int range,
            List<Item> itemInventory)
            : base(id, attackPoints, defencePoints, healthPoints, manaPoints, accuracy, evasion, range, itemInventory)
        {
        }
    }
}
