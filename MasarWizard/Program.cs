using GigaPenterEngine;
using GigaPenterEngine.Core;
using GigaPenterEngine.Renderer.PentaKit;

namespace MasarWizard
{
    internal class Program
    {
        static Game game = new Game();
        static void Main(string[] args)
        {
            RendererSystem render = new RendererSystem(1280, 720, "Kokot", game);
            game.AddSystem(render);
            game.Run();
        }
    }
}
