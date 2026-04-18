using FinalProject.Interfaces;
using FinalProject.Map.Rooms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace FinalProject.Map
{
    internal class Floor
    {
        public string SavePath { get; set; }
        public IRoom[,] Rooms { get; set; } = new IRoom[5,5] 
        {
            { new SpecialShop(), new TrapRoom(), new ExitRoom(), new MonsterRoom(), new EmptyRoom() },
            { new MonsterRoom(), new MonsterRoom(), new TreasureRoom(), new TrapRoom(), new EmptyRoom() },
            { new EmptyRoom(), new TrapRoom(), new BossRoom(), new TrapRoom(), new TreasureRoom()},
            { new EmptyRoom(), new MonsterRoom(), new MonsterRoom(), new EmptyRoom(), new Shop() },
            { new TreasureRoom(), new TrapRoom(), new EmptyRoom(), new MonsterRoom(), new MonsterRoom() }
        };

        public Floor(/*string savePath, IRoom[,] rooms*/)
        {
            //SavePath = savePath;
            //Rooms = rooms;
        }

        public IRoom GetRoom(int row, int column)
        {
            return Rooms[row, column];
        }

        
        public void SaveFloorMap()
        {
            JsonSerializer.Serialize(this);
        }
    }

    
}
