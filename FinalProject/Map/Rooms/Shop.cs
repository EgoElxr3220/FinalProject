using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Map.Rooms
{
    internal class Shop : IRoom
    {
        public int Rows { get; set; } = 5;
        public int Columns { get; set; } = 5;
        public List<Dictionary<string, int>> Wares { get; set; }
        public int[,] Tiles { get; set; } = new int[5, 5]
            {
                { 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 1, 0, 5, 0, 1 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 1, 0, 0 }
            };

        public void DisplayWares()
        {

        }
    }
}
