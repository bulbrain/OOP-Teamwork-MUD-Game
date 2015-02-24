namespace ForsakenLands.GameEngine
{
    using System;
    using System.IO;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Player
    {
        private string name;
        private string password;
        private const string DIRECTORY_PATH = @"..\Release\";

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
                    throw new ArgumentNullException("Invalid name");
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

                this.password = MD5Password.GetMd5Hash(value);
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
            string[] fileNames = Directory.GetFiles(DIRECTORY_PATH);
            bool isOldPlayerFound = false;

            foreach (var fileName in fileNames)
            {
                string fileContent = File.ReadAllText(fileName);
                dynamic data = JObject.Parse(fileContent);
                if (heroName.CompareTo((string)data.Name) == 0 && MD5Password.VerifyMd5Hash(heroPassword, (string)data.Password))
                {
                    isOldPlayerFound = true;
                    break;
                }
            }

            if (!isOldPlayerFound)
            {
                Console.WriteLine("Invalid hero name and/or password!");
            }

            return isOldPlayerFound;
        }

        private void CreatePlayerFile()
        {
            // get filecount to increase player numbers
            int fileCount = Directory.GetFiles(DIRECTORY_PATH).Length;
            string playerNumber = "player" + fileCount.ToString();
            File.WriteAllText(DIRECTORY_PATH + playerNumber + ".json", JsonConvert.SerializeObject(this));
        }
    }
}
