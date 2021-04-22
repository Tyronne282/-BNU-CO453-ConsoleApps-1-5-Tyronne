using System;

namespace MonoGamePlatformer
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Platformer_Game())
                game.Run();
        }
    }
}
