using ForsakenLands.Characters;
using ForsakenLands.Characters.Monsters;
using ForsakenLands.Items;
using ForsakenLands.Items.Armor;
using ForsakenLands.Items.Potion;
using ForsakenLands.Items.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForsakenLands.GameEngine
{
    public static class GameObjectGenerator
    {
        private static Random rnd = new Random();

        public static Monster GenerateMonster()
        {
            int monsterNumber = rnd.Next(0, 3);

            string monsterName = Enum.GetName(typeof(MonsterType), monsterNumber);

            switch (monsterName)
            {
                case "Dragon": return new Dragon();
                case "Vampire": return new Vampire();
                case "Wolf": return new Wolf();
                default:
                    break;
            }

            return null;
        }

        public static Item GenerateItem()
        {
            Random rnd = new Random();
            int itemNumber = rnd.Next(0, 8);
            string itemName = Enum.GetName(typeof(ItemType), itemNumber);

            switch (itemName)
            {
                case "Boots": return new Boots("Boots", false);
                case "Chest": return new Chest("Chest", false);
                case "Helmet": return new Helmet("Helmet", false);
                case "HealthPotion": return new HealthPotion("HealthPotion");
                case "ManaPotion": return new ManaPotion("ManaPotion");
                case "Dagger": return new Dagger("Dagger", false);
                case "Staff": return new Staff("Staff", false);
                case "Sword": return new Sword("Sword", false);  
            default:
                    break;
            }

            return null;
        }
    
    }
}
