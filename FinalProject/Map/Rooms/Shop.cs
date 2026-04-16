using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Map.Rooms
{
    internal class Shop : IRoom
    {
        public int Rows { get; set; } = 3;
        public int Columns { get; set; } = 3;
        public List<Dictionary<string, int>> Wares { get; set; }
        public int[,] Tiles { get; set; } = new int[3, 3]
            {
                { 0, 1, 0 },
                { 1, 5, 1 },
                { 0, 1, 0 }
            };

        public void DisplayWares()
        {

        }
    }
}
