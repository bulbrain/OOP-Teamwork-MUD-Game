using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ForsakenLands
{
    public abstract class GameObject
    {
        private static List<int> IDs = new List<int>(0);
        private int id;

        public GameObject()
        {
            this.Id = 0;
        }

        public int Id { 
            get { return this.id; }
            protected set 
            {
                if (value != 0)
                {
                    this.id = value;
                }
                else
                {
                    this.id = CreateId();
                }
            } 
        }

        private int CreateId()
        {
            string fileName = @"ids.txt";
            if (!File.Exists(fileName))
            {
                using (FileStream fs = File.Create(fileName))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("0");
                    fs.Write(info, 0, info.Length);
                }

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true))
                {
                    file.WriteLine("0");
                }
                return 1;
            }

            string fileContent = File.ReadAllText(fileName);

            int id;

            bool result = Int32.TryParse(fileContent, out id);

            if (result)
            {
                File.WriteAllText(fileName, id+1+"");
                return id+1;
            }

            throw new FileLoadException("Invalid file format!");
        }
    }
}
