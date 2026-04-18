using FinalProject.Combat;
using FinalProject.Combat.Enemies;
using FinalProject.Map;
using FinalProject.Map.Rooms;

internal class Program
{
    private static void Main(string[] args)
    {
        Floor floor1 = new Floor();
        Character player = Character.Instance;
        player.GetPosition(floor1);
        Console.WriteLine(player.Name);

        bool playing = true;

        int lines = 0;
        while (playing)
        {
            player.Move();
            while (!player.IsDead)
            {
                for (int i = 0; i < player.CurrentRoom.Rows; i++)
                {
                    for (int j = 0; j < player.CurrentRoom.Columns; j++)
                    {
                        if (player.CurrentRoom.Tiles[i,j] == 3)
                        {
                            Monster.SpawnMonster(player.CurrentRoom);
                        }
                    }
                }
            }
            if (player.IsDead)
            {
                break;
            }
            lines++;
            if (lines%10 == 0)
            {
                Console.Clear();
            }
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