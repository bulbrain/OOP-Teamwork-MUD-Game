﻿namespace ForsakenLands.GameEngine
 {
     using System;
     ﻿using System.Collections.Generic;

     using Items;

     public class Room : GameObject
     {
         private const byte ROOM_MAX_ITEMS = 4;
         private const byte ROOM_MAX_ENEMIES = 4;

         public Room(string name, RoomType roomType, uint southExit, uint northExit, uint westExit, uint eastExit)
             : base()
         {
             this.Name = name;
             this.RoomType = roomType;
             this.SouthExit = southExit;
             this.NorthExit = northExit;
             this.WestExit = westExit;
             this.EastExit = eastExit;
         }

         public string Name { get; private set; } 

         // It might be smarter to hold all the exits in a consolidated data structure
         public uint SouthExit { get; private set; }
         
         public uint NorthExit { get; private set; }
         
         public uint WestExit { get; private set; }
         
         public uint EastExit { get; private set; }
         
         public RoomType RoomType { get; private set; }
         
         public List<Item> RoomItems { get; private set; }

         public void AddItemToRoom(Item item)
         {
             if (this.RoomItems.Count < ROOM_MAX_ITEMS)
             {
                 this.RoomItems.Add(item);
             }
             else
             {
                 throw new NotImplementedException("Needs to be implemented");
             }
         }
     }
 }