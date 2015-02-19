namespace ForsakenLands.GameEngine
{
    using System;
    //using Newtonsoft.Json;
    using System.IO;

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

               
                    if (newPlayer == "yes")
                    {
                        string heroName = "";
                        string heroPassword = "";
                        string ansTolower = "";

                        Console.WriteLine("Enter your heroic name (min 3 symbols):");
                        heroName = Console.ReadLine();
                        Console.WriteLine("Enter your epic password (min 6 symbols):");
                        heroPassword = Console.ReadLine();
                        Console.WriteLine("Your desired name is: {0} and your password is: {1}.", heroName, heroPassword);
                        Console.WriteLine("Do you want to continue? (Yes/No)");
                        ans = Console.ReadLine();
                        ansTolower = ans.ToLower();

                        //get filecount to increase player numbers
                        int fileCount = Directory.GetFiles(@"\..\Git\ForsakenLands\ForsakenLands\bin\Release\").Length;
                        string playerNumber = "player" + fileCount.ToString();

                            while (true)
                            {

                                if (ansTolower == "yes")
                                {
                                        try
                                        { 
                                            Player player = new Player(heroName, heroPassword);
                                            File.WriteAllText(@"\..\Git\ForsakenLands\ForsakenLands\bin\Release\" + playerNumber + ".json", JsonConvert.SerializeObject(player));
                                            break;
                                        }
                                        catch (ArgumentNullException)
                                        {
                                            Console.WriteLine("The hero name must be at least 3 symbols and the password must be at least 6 symbols.");
                                            Console.WriteLine("Please enter correct ones.");
                                            Console.WriteLine("Enter your heroic name (min 3 symbols):");
                                            heroName = Console.ReadLine();
                                            Console.WriteLine("Enter your epic password (min 6 symbols):");
                                            heroPassword = Console.ReadLine();
                                            continue;
                                        }
                                }
                                else
                                {
                                    Console.WriteLine("Do you want to quit? (Yes/No)");
                                    ans = Console.ReadLine();
                                    ansTolower = ans.ToLower();

                                    if (ansTolower == "yes")
                                    {
                                        break;
                                    }

                                }
                                     
                            }

                        
                        
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
