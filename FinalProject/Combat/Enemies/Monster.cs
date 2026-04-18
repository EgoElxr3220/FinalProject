using FinalProject.Interfaces;
using FinalProject.Map;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Combat.Enemies
{
    internal class Monster : ILivingThings
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Damage { get; set; }
        public bool IsDead { get; set; } = false;
        public int Row { get; set; }
        public int Column { get; set; }
        public int PrevRow { get; set; }
        public int PrevColumn { get; set; }
        public IRoom CurrentRoom { get; set; }
        public int Position { get; set; }

        public Monster(IRoom room) 
        {
            Health = 10;
            Defense = 1;
            Damage = 5;
            CurrentRoom = room;
        }

        public async Task Attack(ILivingThings target)
        {
            while (target.Row == Row && target.Column == Column)
            {
                Combat.Attack(target.Health, Damage, target.Defense);
                Task.Delay(200);
                Attack(target);
            }
        }


        public async Task Move(Character player)
        {
            while (!player.IsDead)
            {
                PrevColumn = Column;
                PrevRow = Row;
                if (Row > player.Row)
                {
                    if (Row > 0)
                    {
                        Row -= 1;
                    }
                }
                else if (Column > player.Column)
                {
                    if (Column > 0)
                    {
                        Column -= 1;
                    }
                }
                if (Row < player.Row)
                {
                    if (Row < CurrentRoom.Rows - 1)
                    {
                        Row += 1;
                    }
                }
                else if (Column < player.Column)
                {
                    if (Column < CurrentRoom.Columns - 1)
                    {
                        Column += 1;
                    }
                }
                CurrentRoom.Tiles[PrevRow, PrevColumn] = 0;
                CurrentRoom.Tiles[Row, Column] = 3;
            }
        }

    }
}
