using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Map.Rooms
{
    internal class EmptyRoom : IRoom
    {
        public int[,] Tiles { get; set; }

        public EmptyRoom()
        {
            Random rand = new Random();
            Tiles = new int[3,3]
            {
                { 0, rand.Next(0,1), 0, },
                { rand.Next(0,1), 0, rand.Next(0,1), },
                { 0, rand.Next(0,1), 0, }
            };
        }
    }
}
