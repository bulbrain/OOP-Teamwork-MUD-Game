﻿namespace ForsakenLands
 {
     public class Room
     {
         public Room()
         {
             // todo
         }

         public uint Id { get; private set; }
         public string RoomDescription { get; private set; }

         public uint SouthExit { get; private set; }
         public uint NorthExit { get; private set; }
         public uint WestExit { get; private set; }
         public uint EastExit { get; private set; }

     }
 }