namespace ForsakenLands.GameEngine
{
    using ForsakenLands.Characters;
    using ForsakenLands.Characters.Heros;
    using ForsakenLands.Characters.Monsters;
    using ForsakenLands.GUI;
    using System;
    using System.Windows.Forms;

    public class Engine
    {
        private bool running = true;

        public void StartGame()
        {
            if (this.running)
            {
                ForsakenLands.GUI.MainMenu mainMenu = new ForsakenLands.GUI.MainMenu();
                Application.Run(mainMenu);
                Console.WriteLine("YOU ARE ENTERED THE BATTLEFIELD OF FORSAKEN LANDS");
                PlayerType playerType = this.GetPlayerType();

                bool wantsToContinue = true;
                Player player = null;

                // get/create player
                while (wantsToContinue && player == null)
                {
                    string[] inputs = this.EnterUserNameAndPassword();
                    player = Player.GetCorrectPlayer(inputs[0], inputs[1], playerType);
                    if (player == null)
                    {
                        wantsToContinue = this.WantsToContinue();
                    }
                    else
                    {
                        if (playerType == PlayerType.New)
                        {
                            Console.WriteLine("Your account with heroic name: {0} was created.", inputs[0]);
                        }
                        else
                        {
                            Console.WriteLine("Wellcome: {0}", inputs[0]);
                        }

                    }
                }

                if (!wantsToContinue)
                {
                    CloseGame(player);
                }

                // choose hero and add it to the player
                if (playerType == PlayerType.New)
                {
                    HeroType heroType = this.ChooseHeroType();
                    Hero hero = Hero.CreateHeroByType(heroType);
                    player.Hero = hero;
                    player.CreatePlayerFile();
                }

                Monster monster = new Wolf();
                BattleManager.StartBattle(player.Hero, monster);
                
                if (!WantsToContinue())
                {
                    CloseGame(player);
                }

                Console.ReadLine();
                // To do next steps
            }
        }

        private PlayerType GetPlayerType()
        {
            string answer;
            do
            {
                Console.WriteLine("Are you a new player? (Yes/No)");
                answer = Console.ReadLine();
            }
            while (answer.ToLower() != "no" && answer.ToLower() != "yes");

            if (answer.ToLower() == "no")
            {
                return PlayerType.Old;
            }

            return PlayerType.New;
        }

        private string[] EnterUserNameAndPassword()
        {
            Console.WriteLine("Enter your heroic name (min 3 symbols):");
            string heroName = Console.ReadLine();
            Console.WriteLine("Enter your epic password (min 6 symbols):");
            string heroPassword = Engine.ReadPassword();
            return new string[] { heroName, heroPassword };
        }

        private static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        // remove one character from the list of password characters
                        password = password.Substring(0, password.Length - 1);
                        // get the location of the cursor
                        int pos = Console.CursorLeft;
                        // move the cursor to the left by one character
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        // replace it with space
                        Console.Write(" ");
                        // move the cursor to the left by one character again
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }

            // add a new line because user pressed enter at the end of their password
            Console.WriteLine();
            return password;
        }

        private bool WantsToContinue()
        {
            string answer;
            do
            {
                Console.WriteLine("Do you want to continue? (Yes/No)");
                answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    return true;
                }
            }
            while (answer.ToLower() != "no");

            return false;
        }

        private HeroType ChooseHeroType()
        {
            string answer;
            do
            {
                Console.WriteLine("Please choose hero type:");
                Console.WriteLine("(1 for Assasin, 2 for Mage, 3 for Warrior)");
                answer = Console.ReadLine();
            }
            while (answer.ToLower() != "1" && answer.ToLower() != "2" && answer.ToLower() != "3");

            switch (answer)
            {
                case "1": return HeroType.Assassin;
                case "2": return HeroType.Mage;
                default:
                    return HeroType.Warrior;
            }
        }

        private void CloseGame(Player player)
        {
            if (player != null)
            {
                if (WantsToSave())
                {
                    Player.SavePlayer(player);
                }                
            }

            Console.WriteLine("Good bye!");
        }

        private bool WantsToSave()
        {
            string answer;
            do
            {
                Console.WriteLine("Do you want to save your state? (Yes/No)");
                answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    return true;
                }
            }
            while (answer.ToLower() != "no");

            return false;
        }
    }
}