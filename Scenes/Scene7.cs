using System;

namespace Game
{
    internal class Scene7 : IScene
    {
        public string Id => "scene7";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Придётся терпеть. Аптечки у меня нет.\nИдти осталось не так много. Главное - не встретить кого-то ещё по дороге.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Не встретить кого-то ещё...\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            sceneManager.GoTo("scene8", context);
            return;
        }
    }
}