using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Map.Rooms
{
    internal class TrapRoom : IRoom
    {
        public int[,] Tiles { get; set; }
    }
}
