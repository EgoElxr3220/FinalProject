using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Map
{
    internal class Floor
    {
        public IRoom[,] Rooms { get; set; } = new IRoom[,] { };
    }

    
}
