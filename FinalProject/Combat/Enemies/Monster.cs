using FinalProject.Interfaces;
using FinalProject.Map;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Combat.Enemies
{
    public class Monster : ILivingThings
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

        public Monster(Character player, IRoom room, int row, int column) 
        {
            Name = "Monster";
            Row = row;
            Column = column;
            Health = 10;
            Defense = 1;
            Damage = 5;
            CurrentRoom = room;
            Task move = Move(player);
            Task.WaitAll(move);
        }

        public async Task Attack(ILivingThings target)
        {
            while (target.Row == Row && target.Column == Column)
            {
                target.Health = Combat.Attack(target.Health, Damage, target.Defense);
                Console.WriteLine($"Monster deals {Damage - target.Defense} damage to {target.Name}");
                await Task.Delay(200);
                await Attack(target);
            }
        }

        public static async Task SpawnMonsters(Character player)
        {
            while (!player.IsDead)
            {
                for (int i = 0; i < player.CurrentRoom.Rows; i++)
                {
                    for (int j = 0; j < player.CurrentRoom.Columns; j++)
                    {
                        if (player.CurrentRoom.Tiles[i, j] == 3)
                        {
                            new Monster(player, player.CurrentRoom, i, j);
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
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
                else if (Row < player.Row)
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
                else if (player.Row == Row && player.Column == Column)
                {
                    Attack(player);
                }
                CurrentRoom.Tiles[PrevRow, PrevColumn] = 0;
                CurrentRoom.Tiles[Row, Column] = 3;
            }
        }
    }
}
