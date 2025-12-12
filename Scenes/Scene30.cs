using System;

namespace Game
{
    internal class Scene30 : IScene
    {
        public string Id => "scene30";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                $"{context.PlayerName}, вы уверены?..\nПоймите.. это крайне важно.\nНам нужно узнать, что произошло во время вашего путешествия...\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "1) Согласиться подключиться\n" +
                "2) Отвергнуть предложение\n> ",
                TextRole.System,
                TextSpeed.Slow,
                context.InstantText
            );

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == "1")
                {
                    sceneManager.GoTo("scene2", context);
                    return;
                }
                else if (input == "2")
                {
                    sceneManager.GoTo("scene31", context);
                    return;
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
    }
}