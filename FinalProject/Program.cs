using FinalProject;
using FinalProject.Map.Rooms;

internal class Program
{
    private static void Main(string[] args)
    {
        EmptyRoom emptyRoom = new EmptyRoom();
        Character player = new Character("Bob");
        player.GetPosition(emptyRoom);
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
            if (lines == 10)
            {
                Console.Clear();
                lines = 0;
            }
        }
        Console.Clear();

        TrapRoom trapRoom = new TrapRoom();
        player.GetPosition(trapRoom);

        lines = 0;
        while (true)
        {
            player.Move();
            if (player.IsDead)
            {
                break;
            }
            lines++;
            if (lines == 10)
            {
                Console.Clear();
                lines = 0;
            }
        }
    }
}