using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Map.Rooms
{
    internal class TreasureRoom : IRoom
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int[,] Tiles { get; set; } = new int[5, 5]
        {
            { 0, 0, 1, 0, 0 },
            { 0, 2, 0, 2, 0 },
            { 1, 0, 2, 0, 1 },
            { 0, 2, 0, 2, 0 },
            { 0, 0, 1, 0, 0 }
        };
    }
}
