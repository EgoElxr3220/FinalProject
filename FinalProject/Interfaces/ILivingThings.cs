using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Interfaces
{
    internal interface ILivingThings
    {
        string Name { get; set; }
        int Health { get; set; }
        int Defense { get; set; }
        int Damage { get; set; }
    }
}
