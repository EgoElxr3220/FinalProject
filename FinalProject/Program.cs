using FinalProject;
using FinalProject.Map.Rooms;

internal class Program
{
    private static void Main(string[] args)
    {
        EmptyRoom emptyRoom = new EmptyRoom();
        Character player = new Character(emptyRoom);

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
        Character player2 = new Character(trapRoom);

        lines = 0;
        while (true)
        {
            player2.Move();
            if (player2.IsDead)
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