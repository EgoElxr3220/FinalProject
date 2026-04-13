using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    internal class Character : ILivingThings
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Damage { get; set; }
        public List<IItem> Inventory { get; set; }
    }
}
