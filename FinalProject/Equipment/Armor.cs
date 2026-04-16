using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Equipment
{
    internal abstract class Armor : IItem
    {
        public int Defense { get; set; }
    }
}
