using System;
using System.Text;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Текстовая игра";

            GameContext context = new GameContext();

            SceneManager sceneManager = new SceneManager();
            sceneManager.Register(new WelcomeScene());
            sceneManager.Register(new Scene1());
            sceneManager.Register(new Scene2());
            sceneManager.Register(new Scene3());
            sceneManager.Register(new Scene4());
            sceneManager.Register(new Scene5());
            sceneManager.Register(new Scene6());
            sceneManager.Register(new Scene7());
            sceneManager.Register(new Scene8());
            sceneManager.Register(new Scene9());
            sceneManager.Register(new Scene10());
            sceneManager.Register(new Scene11());
            sceneManager.Register(new Scene12());
            sceneManager.Register(new Scene13());
            sceneManager.Register(new Scene14());
            sceneManager.Register(new Scene15());
            sceneManager.Register(new Scene16());
            sceneManager.Register(new Scene17());
            sceneManager.Register(new Scene18());
            sceneManager.Register(new Scene19());
            sceneManager.Register(new Scene20());
            sceneManager.Register(new Scene21());
            sceneManager.Register(new Scene22());
            sceneManager.Register(new Scene23());
            sceneManager.Register(new Scene24());
            sceneManager.Register(new Scene25());
            sceneManager.Register(new Scene26());
            sceneManager.Register(new Scene27());
            sceneManager.Register(new Scene28());
            sceneManager.Register(new Scene29());
            sceneManager.Register(new Scene30());
            sceneManager.Register(new Scene31());
            sceneManager.Register(new EndingScene());
            sceneManager.Register(new DeathScene());

            sceneManager.GoTo("welcome", context);
        }
    }
}