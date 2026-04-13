using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Interfaces
{
    internal interface IEquipment
    {
        string Name { get; set; }
        string Description { get; set; }
        int DefBonus { get; set; }
        int AtkBonus { get; set; }

    }
}
