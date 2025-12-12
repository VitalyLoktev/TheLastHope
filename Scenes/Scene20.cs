using System;

namespace Game
{
    internal class Scene20 : IScene
    {
        public string Id => "scene20";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Я бежал изо всех сил, не думая ни о чём. Звуки криков становились всё громче и громче, но я не осмеливался оборачиваться.\n" +
                "Добежав до одной из местных больниц, я захлопнул двери и спрятался за ними.\n" +
                "Минуты две я стоял неподвижно, надеясь, что никакая энигма не заметила, как я проник в здание. " +
                "Затем осторожно выглянул в окно, чтобы оценить обстановку.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Как ни странно, на улице никого не было. Но ещё страннее было то, что я перестал слышать какие-либо звуки. ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(600, context.InstantText);

            context.Printer.Print(
                "Неужели я от них оторвался?\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Развернувшись, я чуть не упал от удивления. Я находился всё в той же больнице, но только",
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
                "живой?\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(300, context.InstantText);

            context.Printer.Print(
                "Вокруг ходили люди: пациенты, врачи и остальной персонал. Кто-то что-то обсуждал, кто-то что-то изучал. " +
                "Однако разобрать их слова я не мог.\nВдруг из одной двери выбежал мальчик. " +
                "Ему было около десяти лет, и он был так поразительно похож на меня...\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(300, context.InstantText);

            context.Printer.Print(
                "Папа, папа. Когда мы поедем домой? Я не хочу здесь находиться. Тут слишком много людей...\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(400, context.InstantText);

            context.Printer.Print(
                "Скоро поедем, сынок. Я же не могу просто взять и бросить тех, кто ждёт моей помощи, верно?\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Доктор опустился перед ним на одно колено.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Я никогда не понимал, почему ты помогаешь абсолютно всем. Ведь здесь есть люди, которые очень плохие.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(300, context.InstantText);

            context.Printer.Print(
                "Очень плохих людей не существует, Сайленс. Каждый человек сам выбирает дорогу, по которой идти. " +
                "Да, в мире есть убийцы, насильники, террорис...\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Я не про них говорю.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Что, прости?\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Таких людей совсем немного. Наш мир почти полностью наполнен убийцами природы.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(800, context.InstantText);

            context.Printer.Print(
                "Убийцами природы?..\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(200, context.InstantText);

            context.Printer.Print(
                "Да. Теми, кто считает, что Земля - его игрушка.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Доктор на секунду замолчал.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Прости, сынок... ",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Я тебя не понимаю. ",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Мне нужно идти, но мы продолжим этот разговор дома, хорошо?\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Доктор поднялся с колена и вместе с помощником направился в кабинет.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(700, context.InstantText);

            context.Printer.Print(
                "Ты тоже плохой человек. ",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(400, context.InstantText);

            context.Printer.Print(
                "Ты тоже не ценишь природу...\n",
                TextRole.SilenceBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(600, context.InstantText);

            context.Printer.Print(
                "В глазах всё начало мутнеть, и я рухнул на пол. Больница снова изменила свой облик.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(800, context.InstantText);

            context.Printer.Print(
                "Веки наливались тяжестью, сознание ускользало, и мне оставалось лишь смотреть, как ко мне кто-то подходит медленными шагами.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Я узнал его.\nЭто был он. ",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Усопший...\n",
                TextRole.InternalMonologue,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Pause(400, context.InstantText);

            context.Printer.Print(
                $"Прости, {context.PlayerName}. Ты пришёл слишком рано. Но ничего.. я знаю, как ты сможешь мне помочь.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(600, context.InstantText);

            context.Printer.Print(
                "Не волнуйся, это будет не больно.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "Как минимум - для меня.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            sceneManager.GoTo("death", context);
            return;
        }
    }
}