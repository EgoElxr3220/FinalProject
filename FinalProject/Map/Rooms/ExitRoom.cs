using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Map.Rooms
{
    internal class ExitRoom : IRoom
    {
        public int Rows { get; set; } = 3;
        public int Columns { get; set; } = 3;
        public int[,] Tiles { get; set; } = new int[3, 3]
        {
            {0, 0, 0 },
            {0, 1, 0 },
            {0, 0, 0 }
        };
        
    }
}
