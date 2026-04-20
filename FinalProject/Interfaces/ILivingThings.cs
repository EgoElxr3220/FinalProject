using FinalProject.Map;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Interfaces
{
    public interface ILivingThings
    {
        string Name { get; set; }
        int Health { get; set; }
        int Defense { get; set; }
        int Damage { get; set; }
        bool IsDead { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public IRoom CurrentRoom { get; set; }
        public int Position { get; set; }
    }
}
