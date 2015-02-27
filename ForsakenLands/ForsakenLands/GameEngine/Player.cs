﻿namespace ForsakenLands.GameEngine
{
    using System;
    using System.IO;

    using ForsakenLands.Characters;
    using ForsakenLands.CustomException;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Player : GameObject
    {
        private const string DirectoryPath = @"..\Release\";
        private string name;
        private string password;
        private Hero hero;

        public Player(string name, string password)
            : base()
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
                    throw new InvalidUserInputException("Invalid name");
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
                    throw new InvalidUserInputException("Password should be non-empty and at least 6 symbols");
                }

                this.password = MD5Password.GetMd5Hash(value);
            }
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

        public void CreatePlayerFile()
        {
            // get filecount to increase player numbers
            if (!Directory.Exists(DirectoryPath))
            {
                Directory.CreateDirectory(DirectoryPath);
            }

            int fileCount = Directory.GetFiles(DirectoryPath).Length;
            File.WriteAllText(DirectoryPath + "player_" + this.Id + ".json", JsonConvert.SerializeObject(this));
        }

        private void SetHashedPassword(string hash)
        {
            this.password = hash;
        }

        public static Player GetCorrectPlayer(string heroName, string heroPassword, PlayerType playerType)
        {
            Player player = null;
            if (playerType == PlayerType.New)
            {
                try
                {
                    if (Player.CheckForUsedUserName(heroName))
                    {
                        throw new InvalidUserInputException("User name is already use. Please try another one.");
                    }

                    player = new Player(heroName, heroPassword);
                }
                catch (InvalidUserInputException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                try
                {
                    player = Player.GetOldPlayer(heroName, heroPassword);
                }
                catch (InvalidUserInputException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return player;
        }

        public static void SavePlayer(Player player)
        {
            if (File.Exists(DirectoryPath + "player_" + player.Id + ".json"))
            {
                File.WriteAllText(DirectoryPath + "player_" + player.Id + ".json", JsonConvert.SerializeObject(player));
            }
            else
            {
                player.CreatePlayerFile();
            }

            Console.WriteLine("The information for your hero is saved.");
        }

        private static Player GetOldPlayer(string heroName, string heroPassword)
        {
            if (Directory.Exists(DirectoryPath))
            {
                string[] fileNames = Directory.GetFiles(DirectoryPath);
                foreach (var fileName in fileNames)
                {
                    string fileContent = File.ReadAllText(fileName);
                    dynamic data = JObject.Parse(fileContent);
                    if (heroName.CompareTo((string)data.Name) == 0 && MD5Password.VerifyMd5Hash(heroPassword, (string)data.Password))
                    {
                        Player player = JsonConvert.DeserializeObject<Player>(fileContent);
                        player.SetHashedPassword((string)data.Password); // to avoid double hash of the password
                        player.Id = data.Id;
                        return player;
                    }
                }
            }

            throw new InvalidUserInputException("Player with these name and password is not found.");
        }

        private static bool CheckForUsedUserName(string heroName)
        {
            if (Directory.Exists(DirectoryPath))
            {
                string[] fileNames = Directory.GetFiles(DirectoryPath);
                foreach (var fileName in fileNames)
                {
                    string fileContent = File.ReadAllText(fileName);
                    dynamic data = JObject.Parse(fileContent);
                    if (heroName.CompareTo((string)data.Name) == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
