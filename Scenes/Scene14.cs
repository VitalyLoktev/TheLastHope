using System;

namespace Game
{
    internal class Scene14 : IScene
    {
        public string Id => "scene14";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "К счастью, приземлился я очень удачно. " +
                "До цели моей миссии оставалось совсем немного, поэтому я рванул к центру города как можно быстрее.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Что это было?.. Как усопший сделал такое? Все усопшие на это способны?\n",
                TextRole.MainCharacter,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Я пытался убедить себя, что он просто разбудил всех тварей, которые были в морге, но",
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
                "но их было так много",
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
                "Я не верю, что в морге могло быть место для такого количества энигм.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Ладно... Сейчас меня не это должно волновать. Нужно как можно быстрее узнать, что повлияло на выброс энергии, а потом возвраща...\n",
                TextRole.MainCharacter,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(2000, context.InstantText);

            context.Printer.Print(
                "Мощный удар, откинувший меня вперёд, вдруг произошёл за моей спиной. " +
                "Я рухнул на землю и, резко обернувшись, увидел то, что означало мою смерть.\n" +
                "Передо мной стоял огромный монстр, похожий на бодибилдера... Только в несколько раз больше и с маской на лице. " +
                "В руке он держал топор - и он был, как минимум, в полтора раза больше самого монстра.\n" +
                "Я достал автомат и начал стрелять. Вот только пули его не пугали - он шёл ко мне медленной походкой, будто издеваясь.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "Патроны для автомата закончились, и я начал вертеться из стороны в сторону, чтобы избежать удара его топора.\n" +
                "В какой-то момент я споткнулся и оказался прямо перед громилой. " +
                "Он поднял топор, чтобы нанести удар, но я успел быстро среагировать: рванул прямо на него и сделал подкат под его ногами. " +
                "Оказавшись за ним, я заметил небольшое синее свечение на его спине. Не раздумывая, я взял пистолет и выстрелил из него три раза. " +
                "Крик громко вырвался из его груди, и стало понятно, что ему больно.\n" +
                "Он выронил топор, после чего мгновенно повернулся и ударил меня рукой. Меня отнесло в стену здания.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Hearts.LoseHeart();

            context.Printer.Print(
                "-1 сердце\n",
                TextRole.Death,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            if (context.Hearts.IsDead)
            {
                sceneManager.GoTo("scene18", context);
                return;
            }
            else
            {
                sceneManager.GoTo("scene15", context);
                return;
            }
        }
    }
}