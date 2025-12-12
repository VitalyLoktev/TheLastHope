using System;

namespace Game
{
    internal class Scene25 : IScene
    {
        public string Id => "scene25";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Да",
                TextRole.MainCharacter,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                ".. ",
                TextRole.MainCharacter,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Pause(600, context.InstantText);

            context.Printer.Print(
                "хорошо. ",
                TextRole.MainCharacter,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Я помогу тебе. ",
                TextRole.MainCharacter,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Что нужно делать?\n",
                TextRole.MainCharacter,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Пойдёмте. Пойдёмте со мной.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Он взял меня за руку и повёл к выходу из квартиры.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Плохие люди. Плохие люди делают больно.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Плохие люди?..\n",
                TextRole.MainCharacter,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Они хотят убить всё живое. Всё живое, что есть в нашем мире.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Я не понимаю...\n",
                TextRole.MainCharacter,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Вы всё поймёте. Нужно уничтожить их. Нужно спасти Землю.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Он подвёл меня к выходу и открыл дверь.\nЗа ней не было ничего - лишь пустота. " +
                "Будто кто-то возвёл стену за дверью и просто разукрасил её белой краской.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Входите. Не бойтесь. Я буду рядом.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Он слегка подтолкнул меня к выходу и я очутился в абсолютно белом помещении.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Я уже давно рядом.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Я повернулся к нему и последнее, что увидел, - как он закрывает дверь.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "...\n...\n...\n",
                TextRole.System,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "Я проснулся в каком-то помещении рядом со странным аппаратом. " +
                "Вокруг меня было много врачей, которые что-то говорили, но я их не понимал.\n" +
                "Я не помнил ничего. Лишь то, что я должен помочь. Помочь спасти Землю.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(700, context.InstantText);

            context.Printer.Print(
                "Я взял ножницы, которые лежали недалеко от меня, и приступил к делу.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(3000, context.InstantText);

            context.Printer.Print(
                "Через час я сидел посередине огромного зала. В моих руках были окровавленные ножницы, а вокруг лежали трупы людей.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(700, context.InstantText);

            context.Printer.Print(
                "Я убил всех. ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Всех, кто находился в этом странном месте.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(800, context.InstantText);

            context.Printer.Print(
                "Я пытался вспомнить хоть что-то, но в голове была только одна мысль: убить плохих людей, чтобы спасти Землю.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Ещё не всё.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Я резко повернул голову направо и увидел мальчика.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
               "Осталось ещё много плохих людей. Они все прячутся. Прячутся в разных уголках Земли.\n",
               TextRole.SilenceBreeze,
               TextSpeed.Normal,
               context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
               "Тебе нужно закончить нашу миссию. А они тебе помогут.\n",
               TextRole.SilenceBreeze,
               TextSpeed.Normal,
               context.InstantText
            );

            context.Printer.Print(
                "Он показал пальцем в сторону напротив меня.\nПередо мной стояли разные монстры. Почему-то в голову сразу пришло только одно слово",
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

            context.Printer.Pause(400, context.InstantText);

            context.Printer.Print(
                "энигмы.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
               "Не бойся, они мои друзья. Они помогут тебе закончить миссию.\n",
               TextRole.SilenceBreeze,
               TextSpeed.Normal,
               context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Я встал, глубоко вздохнул и пошёл в сторону выхода. Все монстры направились за мной.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(700, context.InstantText);

            context.Printer.Print(
                "Нужно было закончить то, что я начал. ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(600, context.InstantText);

            context.Printer.Print(
                "Нужно было спасти планету.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Ending = EndingType.Secret;

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            sceneManager.GoTo("ending", context);
            return;
        }
    }
}