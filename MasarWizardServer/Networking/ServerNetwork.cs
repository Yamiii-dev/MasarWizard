using GigaPenterEngine;
using GigaPenterEngine.Networking.Server;
using System;

namespace MasarWizardServer
{
    public class ServerNetwork
    {
        const int playerCount = 4;
        const int port = 6969;

        public void Init(Game game)
        {
            ServerManager serverManager = new ServerManager(playerCount, port);
            serverManager.ClientConnected += OnConnect;
            serverManager.ClientDisconnected += OnDisconnect;

            game.AddSystem(serverManager);

        }

        private static void OnConnect(ClientConnectArgs args)
        {

        }
    }
}
