using System;

namespace GamePads
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new PadsGraphique())
                game.Run();
        }
    }
}
