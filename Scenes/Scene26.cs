using System;

namespace Game
{
    internal class Scene26 : IScene
    {
        public string Id => "scene26";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Это была толпа бегунов.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "Я узнал их по ногам - десятки и десятки искажённых конечностей без остановки проносились совсем рядом со мной. " +
                "Машину трясло от тяжёлых шагов, металл над головой дрожал, а я боялся даже дышать.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(600, context.InstantText);

            context.Printer.Print(
                "И вдруг.. всё стихло.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Я медленно, почти не чувствуя тела, выполз из-под машины.\nИ тогда увидел их.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(600, context.InstantText);

            context.Printer.Print(
                "Около двадцати энигм сидели и смотрели прямо на меня.\nОни не бросались, не кричали.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(300, context.InstantText);

            context.Printer.Print(
                "Они ждали...\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(550, context.InstantText);

            context.Printer.Print(
                "Я сразу тогда понял...\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(200, context.InstantText);

            context.Printer.Print(
                "Исход был предрешён.\n",
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