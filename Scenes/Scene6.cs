using System;

namespace Game
{
    internal class Scene6 : IScene
    {
        public string Id => "scene6";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Остановившись, я снял рюкзак и открыл аптечку.\nРана жгла так, будто по коже прошлись раскалённым лезвием.\n" +
                "Я смочил бинт антисептиком и прижал его к груди.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Inventory.UseItem("Аптечка");
            context.Hearts.GainHeart();

            context.Printer.Pause(3000, context.InstantText);

            context.Printer.Print(
                "Теперь мне намного лучше.\nЧувствую, как силы постепенно возвращаются.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Из инвентаря убран предмет \"Аптечка\"\n",
                TextRole.System,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "+1 сердце\n",
                TextRole.Heal,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            sceneManager.GoTo("scene8", context);
            return;
        }
    }
}