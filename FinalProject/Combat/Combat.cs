using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Combat
{
    internal abstract class Combat
    {
        public static int Attack(int health, int damage, int defense) => health - (damage - defense);


    }
}
