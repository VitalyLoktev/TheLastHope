using System;

namespace Game
{
    internal class Scene11 : IScene
    {
        public string Id => "scene11";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "В лабораторной было как-то слишком спокойно. Помещение было самым обычным, но тут я чувствовал себя крайне",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                ".. ",
                TextRole.InternalMonologue,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Print(
                "тревожно.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Я понимал, что оставаться здесь небезопасно, поэтому решил выбрать другое место для ночлега.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            sceneManager.GoTo("scene10", context);
            return;
        }
    }
}