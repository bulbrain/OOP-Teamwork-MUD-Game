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
                PlayerType playerType = this.GetPlayerType();

                bool wantsToContinue = true;
                bool isCorrectPlayer = false;

                while (wantsToContinue && !isCorrectPlayer)
                {
                    string[] inputs = this.EnterUserNameAndPassword();
                    isCorrectPlayer = Player.IsCorrectPlayer(inputs[0], inputs[1], playerType);
                    if (!isCorrectPlayer)
                    {
                        wantsToContinue = this.WantsToContinue();
                    }
                    else
                    {
                        Console.WriteLine("Your account with heroic name: {0} and epic password: {1} was created.", inputs[0], inputs[1]);
                    }
                }

                if (!wantsToContinue)
                {
                    Console.WriteLine("GoodBye");
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
            string heroPassword = Console.ReadLine();
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
    }
}
