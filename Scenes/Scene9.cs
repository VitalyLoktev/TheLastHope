using System;

namespace Game
{
    internal class Scene9 : IScene
    {
        public string Id => "scene9";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "После небольшой очереди тварь отпустила меня, и я упал боком прямо на машину.\n" +
                "Поднять меня высоко она не успела, но удар всё равно оказался болезненным.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Hearts.LoseHeart();

            context.Printer.Print(
                "-1 сердце\n",
                TextRole.Death,
                TextSpeed.Slow,
                context.InstantText
            );

            if (context.Hearts.IsDead)
            {
                context.Printer.WaitForKeyIfInstant(context.InstantText);
                sceneManager.GoTo("death", context);
                return;
            }

            context.Printer.Print(
                "Однако настоящая проблема началась, когда сработала сигналка машины. " +
                "Звук был оглушительным, так что оставаться на месте было нельзя, тем более тогда, когда я уже находился недалеко от центра.\n" +
                "Вдруг я услышал крики энигм. Надо было что-то делать...\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "1) Забежать в ближайшее здание\n" +
                "2) Бежать по улице в сторону центра\n> ",
                TextRole.System,
                TextSpeed.Slow,
                context.InstantText
            );

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == "1")
                {
                    sceneManager.GoTo("scene10", context);
                    return;
                }
                else if (input == "2")
                {
                    sceneManager.GoTo("scene20", context);
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