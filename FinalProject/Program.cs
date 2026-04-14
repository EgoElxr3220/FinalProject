using FinalProject;

internal class Program
{
    private static void Main(string[] args)
    {
        Character player = new Character();

        for (int i = 0; i < 10; i++)
        {
            player.Move();
        }
    }
}