using FinalProject.Interfaces;
using FinalProject.Map;
using FinalProject.Map.Rooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Combat
{
    public class Character : ILivingThings
    {
        private static Character _instance;
        public string Name { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Damage { get; set; }
        public List<IItem> Inventory { get; set; }
        public int Row { get; set; } = 4;
        public int Column { get; set; } = 2;
        public int X { get; set; } = 4;
        public int Y { get; set; } = 2;
        public IRoom CurrentRoom { get; set; }
        public Floor CurrentFloor { get; set; }
        public int Position { get; set; }
        public bool IsDead { get; set; } = false;

        private Character(string name)
        {
            Name = name;
            Health = 10;
            Defense = 2;
            Damage = 2;
            Inventory = new List<IItem>();
        }

        public static Character Instance
        {
            get {
                if (_instance == null)
                {
                    _instance = new Character("Bob");
                }
                return _instance;
            }
        }
        public async void GetPosition(Floor floor)
        {
            CurrentFloor = floor;
            CurrentRoom = CurrentFloor.GetRoom(X, Y);
            Position = CurrentRoom.Tiles[Row, Column];
        }

        public void Die()
        {
            if (Health <= 0)
            {
                IsDead = true;
            }
        }

        public async Task Move()
        {
            
            Console.WriteLine(CurrentRoom.ToString());
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
                else if (Row <= 0 && Position == 1)
                {
                    Row = CurrentRoom.Rows - 1;
                    X--;
                    GetPosition(CurrentFloor);
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
                if (Row < CurrentRoom.Rows - 1)
                {
                    Row += 1;
                }
                else if (Row == CurrentRoom.Rows - 1 && Position == 1)
                {
                    Row = 0;
                    X++;
                    GetPosition(CurrentFloor);
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
                else if (Column <= 0 && Position == 1)
                {
                    Column = CurrentRoom.Columns - 1;
                    Y--;
                    GetPosition(CurrentFloor);
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
                if (Column < CurrentRoom.Columns - 1)
                {
                    Column += 1;
                }
                else if (Column == CurrentRoom.Columns - 1 && Position == 1)
                {
                    Column = 0;
                    Y++;
                    GetPosition(CurrentFloor);
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

        public async Task Attack(ILivingThings target)
        {
            while ((target.Row == Row + 1
                || target.Row == Row
                || target.Row == Row - 1)
                && (target.Column == Column + 1
                || target.Column == Column
                || target.Column == Column - 1))
            {
                Combat.Attack(target.Health, Damage, target.Defense);
            }
        }


    }
}
