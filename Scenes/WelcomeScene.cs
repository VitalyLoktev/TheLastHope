using System;

namespace Game
{
    internal class WelcomeScene : IScene
    {
        public string Id => "welcome";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            Console.Clear();

            context.Printer.Print(
                "Добро пожаловать в игру \"Последняя надежда\"!\n",
                TextRole.System,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Пожалуйста, введите ваше имя:\n> ",
                TextRole.System,
                TextSpeed.Normal,
                context.InstantText
            );

            string? name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                context.Printer.Print(
                    "Пожалуйста, введите ваше имя:\n> ",
                    TextRole.System,
                    TextSpeed.Normal,
                    context.InstantText
                );

                name = Console.ReadLine();
            }

            context.PlayerName = name.Trim();

            Console.Clear();

            context.Printer.Print(
                "Выберите режим вывода текста:\n" +
                "1) Мгновенный вывод\n" +
                "2) Кинематографичный вывод\n> ",
                TextRole.System,
                TextSpeed.Normal,
                context.InstantText
            );

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == "1")
                {
                    context.InstantText = true;
                    break;
                }
                else if (input == "2")
                {
                    context.InstantText = false;
                    break;
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

            context.Printer.Print(
                "Запуск игры...\n...\n..\n.\n",
                TextRole.System,
                TextSpeed.VerySlow,
                context.InstantText
            );

            Console.Clear();

            sceneManager.GoTo("scene1", context);
            return;
        }
    }
}