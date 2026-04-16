using FinalProject.Interfaces;
using FinalProject.Map.Rooms;
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
        public IRoom CurrentRoom { get; set; }
        public int Position { get; set; }
        public bool IsDead { get; set; } = false;

        public Character(string name)
        {
            Name = name;
            Health = 10;
            Defense = 10;
            Damage = 2;
            Inventory = new List<IItem>();
        }
        public void GetPosition(IRoom room)
        {
            CurrentRoom = room;
            Position = CurrentRoom.Tiles[Row, Column];
        }

        public void Move()
        {
            // Ask user for a direction
            // if it is valid move to that return the new location
            // if not tell the user the move is invalid
            Console.WriteLine($"{Row}, {Column}");
            Console.WriteLine($"{Position}");
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
                Position = CurrentRoom.Tiles[Row, Column];
                Console.WriteLine($"{Row}, {Column}");
                Console.WriteLine($"{Position}");
            }
            if (keyPress.Key == ConsoleKey.S)
            {
                if (Row < CurrentRoom.Rows-1)
                {
                    Row += 1;
                }
                else
                {
                    Console.WriteLine("You can't go that way. There's a wall.");
                }
                Position = CurrentRoom.Tiles[Row, Column];
                Console.WriteLine($"{Row}, {Column}");
                Console.WriteLine($"{Position}");
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
                Position = CurrentRoom.Tiles[Row, Column];
                Console.WriteLine($"{Row}, {Column}");
                Console.WriteLine($"{Position}");
            }
            if (keyPress.Key == ConsoleKey.D)
            {
                if (Column < CurrentRoom.Columns-1)
                {
                    Column += 1;
                }
                else
                {
                    Console.WriteLine("You can't go that way. There's a wall.");
                }
                Position = CurrentRoom.Tiles[Row, Column];
                Console.WriteLine($"{Row}, {Column}");
                Console.WriteLine($"{Position}");
            }
            if (keyPress.Key == ConsoleKey.Enter)
            {
                IsDead = true;
            }
            
        }

    }
}
