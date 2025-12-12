using System;

namespace Game
{
    internal class Scene23 : IScene
    {
        public string Id => "scene23";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "После нескольких попаданий он начал спускаться прямо в мою сторону. Я выстрелил всю обойму в него, но он не упал.\n" +
                "Он снова вцепился в меня когтями и продолжил спускаться вниз уже вместе со мной.\n" +
                "Оружие я обронил, так что стрелять мне было в него просто не из чего.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(2000, context.InstantText);

            context.Printer.Print(
                "Мы плавно падали ещё минуты две, пролетая над городом. И вдруг он резко направился прямо в здание.\n" +
                "Перед тем, как врезаться, он отпустил меня, и я приземлился прямо в одну из квартир через окно.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "Страж разбился и рухнул вниз.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(400, context.InstantText);

            context.Printer.Print(
                "Что это было? Зачем он так сделал? Неужели я действительно смог сбить его концентрацию во время стрельбы?\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(400, context.InstantText);

            context.Printer.Print(
                "Я поднялся и начал осматривать квартиру.\nРаньше я всегда думал, что квартиру может позволить себе только богатый человек. " +
                "Сам я жил в очень маленьком доме, где одно большое помещение служило всем целям жизни.\n" +
                "О собственной комнате мне приходилось лишь мечтать, ведь с делом отца такое было недостижимо.\n" +
                "Идя по квартире, я вдруг заметил небольшую фотографию, стоявшую на столе в одной из комнат.\n" +
                "На ней был изображён мужчина в белом халате и совсем маленький мальчик.\nПод снимком была надпись: ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "\"Любимый сын\".\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Я долго стоял и рассматривал фотографию, как вдруг кто-то осторожно потянул меня за брюки.\nЯ резко обернулся и увидел ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(700, context.InstantText);

            context.Printer.Print(
                "мальчика.. ",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(300, context.InstantText);

            context.Printer.Print(
                "того самого мальчика, который был запечатлён на снимке.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Дядя.. дядя, помогите мне, пожалуйста. У меня не получилось... Мне нужна ваша помощь.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Что случилось? Чем тебе помочь?\n",
                TextRole.MainCharacter,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Прошу вас.. помогите. Мне нужно довести дело до конца. Прошу, помогите мне.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "1) Помочь\n" +
                "2) Не помогать\n> ",
                TextRole.System,
                TextSpeed.VerySlow,
                context.InstantText
            );

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == "1")
                {
                    sceneManager.GoTo("scene25", context);
                    return;
                }
                else if (input == "2")
                {
                    sceneManager.GoTo("scene24", context);
                    return;
                }
                else
                {
                    context.Printer.Print(
                        "Пожалуйста, введите 1 или 2:\n> ",
                        TextRole.System,
                        TextSpeed.Normal,
                        context.InstantText
                    );
                }
            }
        }
    }
}