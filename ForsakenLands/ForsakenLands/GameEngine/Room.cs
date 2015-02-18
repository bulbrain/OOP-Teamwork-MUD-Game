namespace ForsakenLands.GameEngine
 {
     using System;
     ﻿using System.Collections.Generic;

     using Items;
     public class Room
     {
         private const byte ROOM_MAX_ITEMS = 4;
         public Room(uint id, string name, RoomType roomType, uint southExit, uint northExit, uint westExit, uint eastExit)
         {
             this.Id = id;
             this.Name = name;
             this.RoomType = roomType;
             this.SouthExit = southExit;
             this.NorthExit = northExit;
             this.WestExit = westExit;
             this.EastExit = eastExit;
         }

         public uint Id { get; private set; }
         public string Name { get; private set; } // This will be later on derived from base class

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