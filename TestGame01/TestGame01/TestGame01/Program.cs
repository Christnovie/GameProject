﻿using System;

namespace TestGame01
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new PacmanTest())
                game.Run();
        }
    }
}
