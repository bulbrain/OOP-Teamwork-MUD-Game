﻿namespace ForsakenLands.GameEngine
 {
     public class Room
     {
         public Room()
         {
             // todo
         }

         public uint Id { get; private set; }
         public string Name { get; private set; } // This will be later on derived from base class

         public uint SouthExit { get; private set; }
         public uint NorthExit { get; private set; }
         public uint WestExit { get; private set; }
         public uint EastExit { get; private set; }

     }
 }