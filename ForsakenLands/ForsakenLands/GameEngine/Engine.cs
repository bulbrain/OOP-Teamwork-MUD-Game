namespace ForsakenLands.GameEngine
{
    using System;

    public class Engine
    {
        private bool running = true;

        public void StartGame()
        {
            if (this.running)
            {
                Console.WriteLine("YOU ARE ENTERED THE BATTLEFIELD OF FORSAKEN LANDS");
                Console.WriteLine("Are you a new player? (Yes/No)");
                string ans = Console.ReadLine();
                string newPlayer = ans.ToLower();

                while (true)
                {
                    if (newPlayer == "yes")
                    {
                        Console.WriteLine("Enter your heroic name (min 3 symbols):");
                        string heroName = Console.ReadLine();
                        Console.WriteLine("Enter your epic password (min 6 symbols):");

                        string heroPassword = string.Empty;
                        ConsoleKeyInfo info = Console.ReadKey(true);
                        while (info.Key != ConsoleKey.Enter)
                        {
                            if (info.Key != ConsoleKey.Backspace)
                            {
                                heroPassword += info.KeyChar;
                                info = Console.ReadKey(true);
                            }
                            else if (info.Key == ConsoleKey.Backspace)
                            {
                                if (!string.IsNullOrEmpty(heroPassword))
                                {
                                    heroPassword =
                                        heroPassword.Substring(0, heroPassword.Length - 1);
                                }

                                info = Console.ReadKey(true);
                            }
                        }

                        for (int i = 0; i < heroPassword.Length; i++)
                        {
                            Console.Write("*");
                        }

                        Console.Write(" Your password is with " + heroPassword.Length + " symbols.");
                        Console.WriteLine(" Do you want to continue? (Yes/No)");
                        ans = Console.ReadLine();
                        string createUser = ans.ToLower();

                        // String heroPassword = Console.ReadLine();
                        if (createUser == "yes")
                        {
                            Player player = new Player(heroName, heroPassword);
                        }
                        else
                        {
                            // unfinished loop!!!
                            Console.WriteLine("Do you want to exit?");
                        }

                        break;
                    }
                    else if (newPlayer == "no")
                    {
                        Console.WriteLine("Enter your hero's name:");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Enter your epic password:");
                        string password = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You entered undefined symbols. Please enter yes or no!");

                        ans = Console.ReadLine();
                        newPlayer = ans.ToLower();
                    }
                        

                    

                }
            }
        }
    }
}
