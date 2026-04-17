using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Map.Rooms
{
    internal class EmptyRoom : IRoom
    {
        public int Rows { get; set; } = 5;
        public int Columns { get; set; } = 5;
        public static Random rand = new Random();
        public int[,] Tiles { get; set; } = new int[5, 5]
            {
                { 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 1, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 1, 0, 0 }
            };
    }
}
