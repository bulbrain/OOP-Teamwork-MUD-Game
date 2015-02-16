using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace ForsakenLands
{
    public class Player
    {
        private String name;
        private String password;

        public Player(String name, String password)
        {
            this.Name = name;
            this.Password = password;
        }

        public String Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 3)
	            {
		            throw new ArgumentNullException("asd"); //it's not finished!!! 
	            }
                this.name = value;
            }
        }
        public String Password
        {
            get
            {
                return this.password;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 6)
	            {
		            throw new ArgumentNullException("not enought symbols");
	            }
                // MD5Password hashedPassword = new MD5Password(value); Don't know how to use it. The class should work fine.
                this.name = value;
            }   
                   
        }
            


    }
}
