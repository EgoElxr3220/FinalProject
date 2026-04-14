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
        public int Row { get; set; }
        public int Column { get; set; }



        public void Move()
        {
            // Ask user for a direction
            // if it is valid move to that return the new location
            // if not tell the user the move is invalid
            Console.WriteLine("What direction do you want to go? (use wasd)");
            ConsoleKeyInfo keyPress = Console.ReadKey(true);
            if (keyPress.Key == ConsoleKey.W)
            {
                if (Row > 0)
                {
                    Row -= 1;
                }
                else
                {
                    Console.WriteLine("You can't go that way. There's a wall.");
                }
                Console.WriteLine($"{Row}, {Column}");
            }
            if (keyPress.Key == ConsoleKey.S)
            {
                if (Row < 3)
                {
                    Row += 1;
                }
                else
                {
                    Console.WriteLine("You can't go that way. There's a wall.");
                }
                Console.WriteLine($"{Row}, {Column}");
            }
            if (keyPress.Key == ConsoleKey.A)
            {
                if (Column > 0)
                {
                    Column -= 1;
                }
                else
                {
                    Console.WriteLine("You can't go that way. There's a wall.");
                }
                Console.WriteLine($"{Row}, {Column}");
            }
            if (keyPress.Key == ConsoleKey.D)
            {
                if (Column < 3)
                {
                    Column += 1;
                }
                else
                {
                    Console.WriteLine("You can't go that way. There's a wall.");
                }
                Console.WriteLine($"{Row}, {Column}");
            }
        }

    }
}
