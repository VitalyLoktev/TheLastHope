using System;

namespace Game
{
    internal class Scene28 : IScene
    {
        public string Id => "scene28";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Забежав в квартиру, я увидел двух мальчиков. Они стояли неподвижно и молча смотрели на меня.\n" +
                "И вдруг - они начали плакать.\nА затем",
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

            context.Printer.Pause(300, context.InstantText);

            context.Printer.Print(
                "меняться.",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(600, context.InstantText);

            context.Printer.Print(
                "Их кости с хрустом ломались, кожа темнела и словно обугливалась. " +
                "Детские тела искажались, вытягивались, превращались во что-то уродливое и нечеловеческое.\n" +
                "Через пару секунд передо мной уже стояли не двое маленьких мальчиков.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "Передо мной были двое бегунов.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Я не успел ничего сделать. Они накинулись на меня и начали рвать в клочья.\n" +
                "Перед тем как полностью закрыть глаза, я успел увидеть в глубине квартиры ещё одну фигуру.\n" +
                "Кто-то просто стоял позади монстров и смотрел на меня",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "...\n",
                TextRole.InternalMonologue,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Pause(700, context.InstantText);

            context.Printer.Print(
                "Смотрел на меня синими глазами...\n",
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