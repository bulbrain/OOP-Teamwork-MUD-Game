namespace ForsakenLands.GameEngine
 {
     using System;
     ﻿using System.Collections.Generic;

     using Items;
     using ForsakenLands.Characters;

     public class Room : GameObject
     {
         private static List<int> roomNumbers = new List<int>();
         private int roomNumber;

         public Room()
             : base()
         {
             this.RoomNumber = 0;
         }

         public int RoomNumber 
         { 
             get 
             { 
                 return this.roomNumber; 
             }
             set {
                 this.roomNumber = roomNumbers.Count;
                 Room.roomNumbers.Add(this.roomNumber);
             }
         }

         public Item Item { get; set; }

         public Monster Monster { get; set; } 
     }
 }