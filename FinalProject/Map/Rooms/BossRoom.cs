using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Map.Rooms
{
    internal class BossRoom : IRoom
    {
        public int Rows { get; set; } = 7;
        public int Columns { get; set; } = 7;
        public int[,] Tiles { get; set; } = new int[7,7] 
        {
            { 0, 0, 0, 1, 0, 0, 0 },
            { 0, 4, 0, 4, 0, 4, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 1, 4, 0, 7, 0, 4, 1 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 4, 0, 4, 0, 4, 0 },
            { 0, 0, 0, 1, 0, 0, 0 }
        };
    }
}
