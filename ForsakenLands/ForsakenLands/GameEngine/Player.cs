namespace ForsakenLands
{
    using System;
    public class Player
    {
        private string name;
        private string password;

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
		            throw new ArgumentNullException("asd"); //it's not finished!!! 
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
		            throw new ArgumentNullException("not enough symbols");
	            }
                // MD5Password hashedPassword = new MD5Password(value); Don't know how to use it. The class should work fine.
                this.name = value;
            }   
                   
        }
            


    }
}
