using System;

namespace Game
{
    internal class Scene24 : IScene
    {
        public string Id => "scene24";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Прости",
                TextRole.MainCharacter,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "... ",
                TextRole.MainCharacter,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Print(
                "Я не могу тебе помочь. У меня миссия. Мне нужно идти",
                TextRole.MainCharacter,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "...\n",
                TextRole.MainCharacter,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Print(
                "Плохой дядя.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Его голос начал меняться.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Дядя не хочет помогать мне.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Он становился всё грубее и грубее.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Дядя считает себя важнее меня.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Его глаза вспыхнули синим светом, а голос перестал быть похожим на человеческий.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Дяде нужно умереть.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(400, context.InstantText);

            context.Printer.Print(
                "Он замолчал и замер.\nИ в этот момент я услышал за спиной медленные шаги.\nОбернувшись, я увидел усопшего, который начал",
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

            context.Printer.Print(
                "Мальчик всего лишь просил тебя о помощи.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "говорить...\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Жаль, что ты не захотел ему помогать.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Он поднял руку в мою сторону и сжал ладонь в кулак.\nЯ лишь успел почувствовать, как все мои кости ломаются и вырываются из тела.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            sceneManager.GoTo("death", context);
            return;
        }
    }
}