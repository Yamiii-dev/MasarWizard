using GigaPenterEngine;
using GigaPenterEngine.Networking.Server;

namespace MasarWizardServer
{
    internal class Program
    {
        static Game game = new Game();
        static void Main(string[] args)
        {
            game.Run();
        }
    }
}
