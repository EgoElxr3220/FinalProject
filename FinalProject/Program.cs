using FinalProject.Combat;
using FinalProject.Combat.Enemies;
using FinalProject.Map;
using FinalProject.Map.Rooms;

internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"";
        Floor floor1 = new Floor(path);
        Character player = Character.Instance;
        bool spawnMonster = false;
        player.GetPosition(floor1);

        bool playing = true;

        int lines = 0;
        while (playing)
        {
            Task playerMovement = player.Move();
            Task monsterSpawn = Monster.SpawnMonsters(player);
            
            if (player.IsDead)
            {
                playing = false;
            }
            lines++;
            if (lines%10 == 0)
            {
                Console.Clear();
            }
            Task.WaitAll(playerMovement,monsterSpawn);
        }
        //Console.Clear();

        //TrapRoom trapRoom = new TrapRoom();
        //player.GetPosition(trapRoom);

        //lines = 0;
        //while (true)
        //{
        //    player.Move();
        //    if (player.IsDead)
        //    {
        //        break;
        //    }
        //    lines++;
        //    if (lines == 10)
        //    {
        //        Console.Clear();
        //        lines = 0;
        //    }
        //}
    }
}