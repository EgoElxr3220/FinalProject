using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Interfaces
{
    internal interface IRoom
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int[,] Tiles { get; set; } 
    }

    public enum Tile
    {
        Empty = 0,
        Exit,
        Treasure,
        Monster,
        Trap,
        Shop,
        SpecialShop,
        Boss,
        FloorExit
    }
}
