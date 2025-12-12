using System;

namespace Game
{
    internal class Scene21 : IScene
    {
        public string Id => "scene21";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Страж поднял меня на вершину одного из зданий и отпустил. Я приземлился прямо в центр его гнезда.\n" +
                "Он начал парить надо мной, словно я - добыча. ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(400, context.InstantText);

            context.Printer.Print(
                "Нужно было действовать... Что-то предпринимать немедленно.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "1) Побежать к спуску с крыши\n" +
                "2) Начать стрелять в стража\n> ",
                TextRole.System,
                TextSpeed.VerySlow,
                context.InstantText
            );

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == "1")
                {
                    sceneManager.GoTo("scene22", context);
                    return;
                }
                else if (input == "2")
                {
                    sceneManager.GoTo("scene23", context);
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