using System;

namespace Game
{
    internal class Scene19 : IScene
    {
        public string Id => "scene19";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Несколько минут я ещё отстреливал мертвецов, цепляясь за надежду, что смогу перебить их всех.\n" +
                "Но они всё шли и шли, тянувшись ко мне на звук выстрелов.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "И вдруг - щелчок.\nПатроны закончились...\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Это был конец..\n",
                TextRole.InternalMonologue,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            sceneManager.GoTo("death", context);
            return;
        }
    }
}