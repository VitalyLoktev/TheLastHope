using System;

namespace Game
{
    internal class Scene18 : IScene
    {
        public string Id => "scene18";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Последнее, что я увидел, - это то, как он медленно приближается ко мне.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "Я был так близок к цели.. но судьба решила иначе...\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            sceneManager.GoTo("death", context);
            return;
        }
    }
}