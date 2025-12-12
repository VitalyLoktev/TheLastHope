using System;

namespace Game
{
    internal class Scene3 : IScene
    {
        public string Id => "scene3";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Через окно было видно огромное количество бегунов - энигм второго уровня. " +
                "Если бы остался на улице, меня бы растерзали на мелкие клочки.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Нужно осмотреться...\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Больница была в ужасном состоянии. Света нигде не было, так что пришлось включить фонарик.\n" +
                "Я шёл по длинному коридору, попутно пытаясь открывать двери, однако все они были закрыты.\n" +
                "Вдруг одна дверь подалась. Стоит ли мне войти?\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "1) Войти\n" +
                "2) Не входить\n> ",
                TextRole.System,
                TextSpeed.VerySlow,
                context.InstantText
            );

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == "1")
                {
                    sceneManager.GoTo("scene4", context);
                    return;
                }
                else if (input == "2")
                {
                    sceneManager.GoTo("scene5", context);
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