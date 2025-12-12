using System;

namespace Game
{
    internal class Scene16 : IScene
    {
        public string Id => "scene16";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "В пистолете оставался один патрон. ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Патрон, которого мне будет достаточно.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Я быстро вынул пистолет и прицельным взглядом выстрелил Сайленсу в глаз. В тот самый глаз, что светился ослепляющим синими светом. " +
                "Глаз, который должен был быть его слабым местом.\nОн пронзительно закричал. Его ноги подломились. " +
                "Он облокотился на свой аппарат и нажал на какую-то кнопку.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Я думал, что ты будешь умнее... Тем не менее, процесс уже начался. Скоро все люди погибнут. Скоро Земля.. восстановится.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "И, сказав это, он рассыпался на тысячи маленьких частиц и исчез. ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(2000, context.InstantText);

            context.Printer.Print(
                "Я.. убил его? Правда убил?\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "Что-то начинало происходить. Луч становился ярче, выше, шире. Я принялся лихорадочно нажимать на разные кнопки - ничего. " +
                "Никакого отклика.\nСхватив кусок трубы с земли, я начал колотить по аппарату изо всех сил.\n" +
                "Удары звенели, металл прогибался, искры сыпались изнутри. Ещё. Ещё. Ещё!\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "И вдруг...\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Взрыв.\n",
                TextRole.InternalMonologue,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Print(
                "...\n...\n...\n",
                TextRole.System,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Print(
                $"Быстрее, зовите всех врачей! {context.PlayerName}, вы меня слышите, {context.PlayerName}...\n",
                TextRole.Doctor1,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(2000, context.InstantText);

            context.Printer.Print(
                "Успокойтесь, успокойтесь... Всё хорошо. Вы большой молодец!\n",
                TextRole.Doctor1,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Где я?\n",
                TextRole.MainCharacter,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "В «Тихом Востоке». Вы всё это время были здесь.\n",
                TextRole.Doctor1,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Что произошло?\n",
                TextRole.MainCharacter,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                $"Вы смогли предотвратить глобальный взрыв. Вы спасли всех нас, {context.PlayerName}!\nОднако взрыв всё же произошёл... " +
                $"Он отбросил вас очень далеко. Вот почему мы смогли обнаружить вас.\n",
                TextRole.Doctor1,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Доктор... Доктор Эдстон Бриз... Где он?..\n",
                TextRole.MainCharacter,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "В помещении повисло неловкое молчание.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Он.. сбежал. ",
                TextRole.Doctor1,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "После того, как услышал имя существа через проектор, он сказал, что ему нужно отлучиться. " +
                "А в итоге выбрался на поверхность с помощью аварийного выхода и.. скрылся.\n",
                TextRole.Doctor1,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Что?..\n",
                TextRole.MainCharacter,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Мы думаем, он отправился искать своего сына. Не знаем, заче..\n",
                TextRole.Doctor1,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Все голоса вдруг стали для меня беззвучными.\nОни больше не имели смысла, ведь",
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

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "ведь я увидел его.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Он снова стоял в дверном проёме и просто смотрел.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(300, context.InstantText);

            context.Printer.Print(
                "Никто не замечал его. Как будто его здесь и не было.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(300, context.InstantText);

            context.Printer.Print(
                "Но я понимал, что он здесь.\nПришёл посмотреть на меня.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(800, context.InstantText);

            context.Printer.Print(
                "Посмотреть на меня своими",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                ".. ",
                TextRole.InternalMonologue,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Print(
                "своими",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                ".. ",
                TextRole.InternalMonologue,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "красными глазами...\n",
                TextRole.InternalMonologue,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Ending = EndingType.Good;

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            sceneManager.GoTo("ending", context);
            return;
        }
    }
}