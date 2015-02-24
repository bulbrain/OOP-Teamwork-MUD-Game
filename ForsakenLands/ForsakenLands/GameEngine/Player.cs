namespace ForsakenLands.GameEngine
{
    using System;
    using System.IO;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using ForsakenLands.Characters;
    using ForsakenLands.Characters.Heros;
    using System.Web;

    public class Player
    {
        private string name;
        private string password;
        private Hero hero;
        private const string DIRECTORY_PATH = @"..\Release\";

        public Player(string name, string password)
        {
            this.Name = name;
            this.Password = password;
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

        private void SetHashedPassword(string hash)
        {
            this.password = hash;
        }

        public Hero Hero
        {
            get
            {
                return this.hero;
            }

            set
            {
                this.hero = value;
            }
        }
        
        public static Player GetCorrectPlayer(string heroName, string heroPassword, PlayerType playerType)
        {
            Player player = null;
            if (playerType == PlayerType.New)
            {
                try
                {
                    player = new Player(heroName, heroPassword);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("The hero name must be at least 3 symbols and the password must be at least 6 symbols.");
                }
            }
            else
            {
                try
                {
                    player = Player.GetOldPlayer(heroName, heroPassword);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Player with these name and password is not found.");
                }
            }

            return player;
        }

        private static Player GetOldPlayer(string heroName, string heroPassword)
        {
            string[] fileNames = Directory.GetFiles(DIRECTORY_PATH);
            foreach (var fileName in fileNames)
            {
                string fileContent = File.ReadAllText(fileName);
                dynamic data = JObject.Parse(fileContent);                
                if (heroName.CompareTo((string)data.Name) == 0 && MD5Password.VerifyMd5Hash(heroPassword, (string)data.Password))
                {
                    Player player = JsonConvert.DeserializeObject<Player>(fileContent);
                    player.SetHashedPassword((string)data.Password); // to avoid double hash of the password       
                    return player;
                }
            }

            throw new ArgumentNullException("Not found");
        }

        public void CreatePlayerFile()
        {
            // get filecount to increase player numbers
            int fileCount = Directory.GetFiles(DIRECTORY_PATH).Length;
            string playerNumber = "player" + fileCount.ToString();
            File.WriteAllText(DIRECTORY_PATH + playerNumber + ".json", JsonConvert.SerializeObject(this));
        }
    }
}
