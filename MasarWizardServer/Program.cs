using GigaPenterEngine;
using GigaPenterEngine.Networking.Server;

namespace MasarWizardServer
{
    internal class Program
    {
        static Game game = new Game();
        static void Main(string[] args)
        {
            ServerManager pepega = new ServerManager(4, 6969);
            pepega.ClientDisconnected += OnDisconnected;
            game.Run();
        }
    }
}
