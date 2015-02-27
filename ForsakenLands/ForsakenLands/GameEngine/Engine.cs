namespace ForsakenLands.GameEngine
{
    using System;
    using System.Windows.Forms;

    using ForsakenLands.Characters;
    using ForsakenLands.Characters.Heros;

    public class Engine
    {
        private bool running = true;

        public void StartGame()
        {
            if (this.running)
            {
                GUI.MainMenu mainMenu = new GUI.MainMenu();
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

                if (playerType == PlayerType.New)
                {
                    this.CreatePlayerHero(player);
                    player.CreatePlayerFile();
                }

                this.PlayGame(player);

                this.CloseGame(player);
            }
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

        private void CreatePlayerHero(Player player)
        {
            HeroType heroType = this.ChooseHeroType();
            Hero hero = Hero.CreateHeroByType(heroType);
            hero.HealthChanged += (sender, eventArgs) =>
                {
                    Console.WriteLine(
                        "Be carafull you have only {0} health points!!!!!!!!!!!!!!!!",
                        eventArgs.NewHealthPoints);
                };
            player.Hero = hero;
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
                case "1":
                    return HeroType.Assassin;
                case "2":
                    return HeroType.Mage;
                default:
                    return HeroType.Warrior;
            }
        }

        private void PlayGame(Player player)
        {
            bool wantsToContinue = true;

            while (wantsToContinue && player.Hero.CurrentHealthPoints > 0)
            {
                Room currentRoom = new
                    Room();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Welcome to Room number: {0}", currentRoom.RoomNumber);
                currentRoom.Monster = GameObjectGenerator.GenerateMonster();
                currentRoom.Item = GameObjectGenerator.GenerateItem();
                Console.WriteLine("You will attack {0} in this room!", currentRoom.Monster.GetType().Name);
                Console.WriteLine("If you kill him, you will get {0}", currentRoom.Item);
                BattleManager.StartBattle(player.Hero, currentRoom.Monster, currentRoom.Item);

                if (player.Hero.CurrentHealthPoints > 0)
                {
                    wantsToContinue = this.WantsToContinue();
                }
            }
        }

        private void CloseGame(Player player)
        {
            if (player != null)
            {
                if (player.Hero.CurrentHealthPoints > 0)
                {
                    if (this.WantsToSave())
                    {
                        Player.SavePlayer(player);
                    }
                }
                else
                {
                    Console.WriteLine("You can log in again to try to kill some monsters with your last saved state.");
                }
            }

            Console.WriteLine("Good bye!");
            Console.ReadLine();
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