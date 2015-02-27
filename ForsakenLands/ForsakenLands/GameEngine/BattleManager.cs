using ForsakenLands.Characters;
using ForsakenLands.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForsakenLands.GameEngine
{
    public class BattleManager
    {
        public static void StartBattle(Hero hero, Monster monster, Item item) {
            int round = 1;

            while (hero.HealthPoints > 0 && monster.HealthPoints > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Round: {0}", round);
                PrintProperties(hero, monster);

                if (round % 2 == 1)
                {
                    AttackType attackType = ChooseHowToAttack();
                    Beat(hero, monster, attackType);
                }
                else
                {
                    Beat(monster, hero, AttackType.Strike);
                }

                round++;
            }

            if (monster.HealthPoints == 0)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("You kill the {0}!", monster.GetType().Name);
                Console.WriteLine("You win the {0}!", item);
                Console.WriteLine("-------------------------------------------");
                hero.AddItemToInventory(item);
                hero.UseItem(hero.ItemInventory.Count-1);
            }
            else
            {
                Console.WriteLine("The {0} kill you!", monster.GetType().Name);
            }
        }

        private static void Beat(Character attacker, Character defender , AttackType attackType)
        {
            if (attackType.Equals(AttackType.Strike))
            {
                Strike(attacker, defender);
            }
            else
            {
                Spell(attacker, defender);
            }
        }
        
        private static void Strike(Character straker, Character defender)
        {
            if (defender.DefencePoints < straker.AttackPoints)
            {
                if ((straker.AttackPoints - defender.DefencePoints) < defender.HealthPoints)
                {
                    defender.HealthPoints -= (straker.AttackPoints - defender.DefencePoints);
                }
                else
                {
                    defender.HealthPoints = 0;
                }
                
            }
        }
        
        private static void Spell(Character wizard, Character defender)
        {
            if (defender.DefencePoints < wizard.ManaPoints)
            {
                if ((wizard.ManaPoints - defender.DefencePoints) < defender.HealthPoints)
                {
                    defender.HealthPoints -= (wizard.ManaPoints - defender.DefencePoints);
                }
                else
                {
                    defender.HealthPoints = 0;
                }
                
            }
        }
 
        private static AttackType ChooseHowToAttack() {
            string answer;
            do
            {
                Console.WriteLine("How do you want to attack? (1 - Strike, 2 - Spell)");
                answer = Console.ReadLine();
            }
            while (answer != "1" && answer != "2");

            if (answer == "1")
            {
                return AttackType.Strike;
            }

            return AttackType.Spell;           
        }

        private static void PrintProperties(Hero hero, Monster monster)
        {
            Console.WriteLine("Hero Type: {0} Monster Type: {1}",hero.GetType().Name, monster.GetType().Name);
            Console.WriteLine("Mana Points: {0} Mana Points: {1}", hero.ManaPoints, monster.ManaPoints);
            Console.WriteLine("Attack Points: {0} Attack Points: {1}", hero.AttackPoints, monster.AttackPoints);
            Console.WriteLine("Defence Points: {0} Defence Points: {1}", hero.DefencePoints, monster.DefencePoints);
            Console.WriteLine("Health Points: {0} Health Points: {1}", hero.HealthPoints, monster.HealthPoints);
        }
    }
}
