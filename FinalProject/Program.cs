using FinalProject;
using FinalProject.Map;
using FinalProject.Map.Rooms;

internal class Program
{
    private static void Main(string[] args)
    {
        Floor floor1 = new Floor();
        Character player = new Character("Bob");
        player.GetPosition(floor1);
        Console.WriteLine(player.Name);

        int lines = 0;
        while (true)
        {
            player.Move();
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