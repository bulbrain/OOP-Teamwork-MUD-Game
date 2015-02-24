namespace ForsakenLands.GameEngine
{
    using System;
    using System.IO;

    using Newtonsoft.Json;

    public class Player
    {
        private string name;
        private string password;

        public Player(string name, string password)
        {
            this.Name = name;
            this.Password = password;
            this.CreatePlayerFile();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 6)
                {
                    throw new ArgumentNullException("value", "Password should be non-empty and at least 6 symbols");
                }

                // MD5Password hashedPassword = new MD5Password(value); Don't know how to use it. The class should work fine.
                this.password = value;
            }
        }
        
        public static bool IsCorrectPlayer(string heroName, string heroPassword, PlayerType playerType)
        {
            if (playerType == PlayerType.New)
            {
                return Player.IsNewPlayerCreated(heroName, heroPassword);
            }

            return Player.IsOldPlayerFound(heroName, heroPassword);
        }

        private static bool IsNewPlayerCreated(string heroName, string heroPassword)
        {
            try
            {
                Player player = new Player(heroName, heroPassword);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The hero name must be at least 3 symbols and the password must be at least 6 symbols.");
                return false;
            }

            return true;
        }

        private static bool IsOldPlayerFound(string heroName, string heroPassword)
        {
            // To do - check in the file
            return false;
        }

        private void CreatePlayerFile()
        {
            // get filecount to increase player numbers
            int fileCount = Directory.GetFiles(@"..\Release\").Length;
            string playerNumber = "player" + fileCount.ToString();
            File.WriteAllText(@"..\Release\" + playerNumber + ".json", JsonConvert.SerializeObject(this));
        }
    }
}
