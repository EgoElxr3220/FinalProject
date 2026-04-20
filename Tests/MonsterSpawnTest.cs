using System.Numerics;
using FinalProject.Interfaces;
using FinalProject.Map;
using FinalProject.Map.Rooms;
using FinalProject.Combat;
using FinalProject.Combat.Enemies;

namespace Tests
{
    public class MonsterSpawnTest
    {
        [Fact]
        public async Task Test1()
        {
            Character player = Character.Instance;
            player.Y = 3;
            player.Row = 0;
            player.Column = 0;
            Task monsterSpawn = Monster.SpawnMonsters(player);

            await monsterSpawn;
            Assert.True(player.IsDead);
        }
    }
}
