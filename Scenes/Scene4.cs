using System;

namespace Game
{
    internal class Scene4 : IScene
    {
        public string Id => "scene4";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Чёрт... Здесь незрячий.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Подкравшись к нему со спины, я перерезал ему горло. Он упал, не издав ни звука.\n" +
                "В кабинете, куда я вошёл, царил хаос, однако в нём я сумел разглядеть аптечку!\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Inventory.AddItem("Аптечка");

            context.Printer.Print(
                "В инвентарь добавлен предмет \"Аптечка\"\n",
                TextRole.System,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Выйдя из кабинета, я направился дальше по коридору.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            sceneManager.GoTo("scene5", context);
            return;
        }
    }
}