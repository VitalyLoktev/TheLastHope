using System;

namespace Game
{
    internal class DeathScene : IScene
    {
        public string Id => "death";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "\nВы погибли...\n",
                TextRole.Death,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Pause(5000, context.InstantText);

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            Console.Clear();

            context.Printer.Print(
                "Желаете начать игру заново?\n",
                TextRole.System,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "1) Начать игру заново\n2) Выйти из игры\n> ",
                TextRole.System,
                TextSpeed.Normal,
                context.InstantText
            );

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == "1")
                {
                    RestartGame();
                    return;
                }
                else if (input == "2")
                {
                    Environment.Exit(0);
                }
                else
                {
                    context.Printer.Print(
                        "Пожалуйста, введите 1 или 2:\n> ",
                        TextRole.System,
                        TextSpeed.Normal,
                        context.InstantText
                    );
                }
            }
        }

        private void RestartGame()
        {
            Console.Clear();

            var newContext = new GameContext();
            var newSceneManager = new SceneManager();

            newSceneManager.Register(new WelcomeScene());
            newSceneManager.Register(new Scene1());
            newSceneManager.Register(new Scene2());
            newSceneManager.Register(new Scene3());
            newSceneManager.Register(new Scene4());
            newSceneManager.Register(new Scene5());
            newSceneManager.Register(new Scene6());
            newSceneManager.Register(new Scene7());
            newSceneManager.Register(new Scene8());
            newSceneManager.Register(new Scene9());
            newSceneManager.Register(new Scene10());
            newSceneManager.Register(new Scene11());
            newSceneManager.Register(new Scene12());
            newSceneManager.Register(new Scene13());
            newSceneManager.Register(new Scene14());
            newSceneManager.Register(new Scene15());
            newSceneManager.Register(new Scene16());
            newSceneManager.Register(new Scene17());
            newSceneManager.Register(new Scene18());
            newSceneManager.Register(new Scene19());
            newSceneManager.Register(new Scene20());
            newSceneManager.Register(new Scene21());
            newSceneManager.Register(new Scene22());
            newSceneManager.Register(new Scene23());
            newSceneManager.Register(new Scene24());
            newSceneManager.Register(new Scene25());
            newSceneManager.Register(new Scene26());
            newSceneManager.Register(new Scene27());
            newSceneManager.Register(new Scene28());
            newSceneManager.Register(new Scene29());
            newSceneManager.Register(new Scene30());
            newSceneManager.Register(new Scene31());
            newSceneManager.Register(new DeathScene());
            newSceneManager.Register(new EndingScene());

            newSceneManager.GoTo("welcome", newContext);
        }
    }
}
