using FinalProject.Interfaces;
using FinalProject.Map;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Combat.Enemies
{
    internal class BossMonster : ILivingThings
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Damage { get; set; }
        public bool IsDead { get; set; } = false;
        public int Row { get; set; }
        public int Column { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public IRoom CurrentRoom { get; set; }
        public Floor CurrentFloor { get; set; }
        public int Position { get; set; }
    }
}
