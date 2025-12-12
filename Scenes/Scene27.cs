using System;

namespace Game
{
    internal class Scene27 : IScene
    {
        public string Id => "scene27";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Зайдя в здание и заперев двери на замок, я почувствовал холод. Но холод был не в самом здании ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(600, context.InstantText);

            context.Printer.Print(
                "- он был во мне.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Я включил фонарик, повернулся спиной к дверям и увидел перед собой двух мальчиков и одну девочку. " +
                "Все трое смотрели на меня и улыбались.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Эй.. привет. ",
                TextRole.MainCharacter,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(300, context.InstantText);

            context.Printer.Print(
                "Не бойтесь меня, я хороший. Я могу помочь вам. Отвести вас в безопасное место.\n",
                TextRole.MainCharacter,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Они ещё несколько секунд стояли неподвижно, а потом вдруг начали громко смеяться и разбегаться в разные стороны.\n" +
                "Один из мальчиков помчался на второй этаж. Я побежал за ним.\nСтоило мне ступить на второй этаж, как ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(800, context.InstantText);

            context.Printer.Print(
                "всё вокруг изменилось. ",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Я оказался в лесу, а рядом со мной появились двое охотников.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Здравствуйте.. где я?\n",
                TextRole.MainCharacter,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Они меня не слышали. Я попытался прикоснуться к одному из них, однако моя рука прошла сквозь его тело.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Сегодня нам прям везёт, скажи? Два зайца и целый олень. Моя семья будет в восторге.\n",
                TextRole.Hunter1,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Твоим пацанам нужно очень много мяса, так что да, повезло.\n",
                TextRole.Hunter2,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Что ты имеешь в виду?\n",
                TextRole.Hunter1,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Если они не вырастут сильными и здоровыми, ты думаешь, они смогут добиться внимания моей принцессы? ",
                TextRole.Hunter2,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(600, context.InstantText);

            context.Printer.Print(
                "Нет, конечно.\n",
                TextRole.Hunter2,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Опять ты за своё. " +
                "Каждый день только и говоришь мне про свою Алису - какая она у тебя самая красивая, умная и смышлёная.\n",
                TextRole.Hunter1,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "А разве это не так?\n",
                TextRole.Hunter2,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "С чего ты вообще взял, что Максим и Денис захотят добиваться её? В мире полно других девочек.\n",
                TextRole.Hunter1,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Но моя-то самая лучшая.\n",
                TextRole.Hunter2,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Они оба улыбнулись и засмеялись. И вдруг один из охотников заметил за спиной другого кого-то",
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
                "Пацан, у тебя всё хорошо? Ты зачем тут бродишь один?\n",
                TextRole.Hunter1,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Я обернулся и увидел мальчика. На вид ему было лет четырнадцать. Он стоял неподвижно и смотрел на охотников глазами, полными",
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
                "ненависти.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Вдруг из его спины вырвалось нечто.\n" +
                "Монстр был очень похож на бегуна, вот только что-то отличало его от тех энигм, которых мне приходилось видеть...\n" +
                "Словно эта тварь появилась не в результате мутации человека, а",
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

            context.Printer.Pause(700, context.InstantText);

            context.Printer.Print(
                "была создана.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Это что такое!?\n",
                TextRole.Hunter1,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Охотники потянулись к ружьям, но в тот же миг мальчик коротко свистнул - и бегун рванул в их сторону.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Через пятнадцать секунд оба охотника уже лежали на земле. Их лица.. их лица были разорваны укусами этой твари.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Мальчик подошёл к бегуну, опустился рядом с ним и начал медленно гладить его по голове.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Ты молодец. Скоро я дострою свой прибор, и нам больше не придётся самим отлавливать этих людишек.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Он поднялся, постоял пару секунд...\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(600, context.InstantText);

            context.Printer.Print(
                "И резко повернул голову в мою сторону.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(300, context.InstantText);

            context.Printer.Print(
                "Он прекрасен, не так ли? ",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "Они все прекрасны.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Он сделал шаг вперёд.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Но я хотел совсем иного исхода. Из-за глупой ошибки в расчётах люди не умерли...\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "Лишь превратились в таких созданий.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Он тихо усмехнулся.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Ну ничего. Все допускают ошибки, но.. не всем даётся второй шанс их исправить. А мне второй шанс дали.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1500, context.InstantText);

            context.Printer.Print(
                "И я им воспользуюсь.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(600, context.InstantText);

            context.Printer.Print(
                "Я закончу то, что начал. Даже ценой жизни этих прекрасных созданий.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "В тот же миг всё вокруг снова исказилось.\nОбстановка поменялась - и я вернулся в жилое здание.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(600, context.InstantText);

            context.Printer.Print(
                "Я увидел, как мальчик, за которым я гнался в самом начале, забежал в одну из квартир.\n" +
                "А посмотрев на лестницу, я заметил девочку, которая, поймав мой взгляд, быстро побежала куда-то вниз, на первый этаж.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "1) Побежать за мальчиком\n" +
                "2) Побежать за девочкой\n> ",
                TextRole.System,
                TextSpeed.VerySlow,
                context.InstantText
            );

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == "1")
                {
                    sceneManager.GoTo("scene28", context);
                    return;
                }
                else if (input == "2")
                {
                    sceneManager.GoTo("scene29", context);
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