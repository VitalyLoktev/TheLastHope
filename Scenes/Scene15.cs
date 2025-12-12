using System;

namespace Game
{
    internal class Scene15 : IScene
    {
        public string Id => "scene15";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Стало ужасно больно, но я всё же нашёл в себе силы подняться.\nЕго слабое место - спина.\n" +
                "Мне нужно лишь снова оказаться за этим громилой.\nОн шёл на меня, и я, собрав всю волю в кулаки, рванул ему навстречу.\n" +
                "Увернувшись от его ударов, я скользнул за спину и всадил почти всю обойму пистолета прямо в синее свечение.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(2000, context.InstantText);

            context.Printer.Print(
                "Громила рухнул.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(2000, context.InstantText);

            context.Printer.Print(
                "Я сел на дорогу и начал глубоко дышать.\nТакого монстра я не видел никогда в своей жизни. " +
                "Он был куда сильнее и умнее остальных энигм, с которыми мне приходилось сталкиваться.\n" +
                "Проверив магазин пистолета, я понял, что у меня остался только один патрон...\n" +
                "Все обоймы автомата были пусты. Мне оставалось лишь надеяться, что по пути к центру я больше никого не встречу...\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(2000, context.InstantText);

            context.Printer.Print(
                "Я поднялся, посмотрел на небо, выдохнул и пошёл дальше.\n" +
                "Всю оставшуюся дорогу я думал об огромной энигме. Почему я раньше не встречал ничего подобного? " +
                "Как он вообще смог мутировать до таких размеров?\n" +
                "В какой-то момент в голове мелькнула мысль, что громила мог быть кем-то вроде охранника. " +
                "Но охранника чего? Неужели я приближаюсь к чему-то важному?\n" +
                "И тут я понял, что всю свою миссию я даже не задумывался о том, куда именно иду. Да, в центр города. Да, к какому-то зданию. ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Но к какому именно?\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Остановившись и раскрыв карту, я увидел крест в центре города, который указывал на",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                ".. больницу? Обычную городскую больницу?\nВыброс энергии действительно произошёл отсюда? Но.. почему?\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "Через десять минут я уже стоял перед больницей. К моему удивлению, она выглядела почти нетронутой, но.. как? " +
                "Да, выброс энергии не повлёк за собой взрыв, но разве здание всё равно не должно было пострадать?\n" +
                "И тут из крыши больницы резким рывком взмыл в небо мощный синий луч. " +
                "Я не ожидал этого настолько, что даже не удержал равновесия и упал.\n" +
                "Луч явно не предвещал ничего хорошего, так что я быстро поднялся, отряхнулся и поспешил к парадным дверям больницы, " +
                "после чего вошёл в неё.",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(2000, context.InstantText);

            context.Printer.Print(
                "Пока я шёл по коридору, мысли лезли в голову одна за другой - и каждая была страннее предыдущей.\n" +
                "Планировка больницы была стандартной: квадратное здание, в центре - больничный двор, " +
                "куда пациенты могли выходить подышать воздухом. Таких больниц в городе было полно.. но что же делало именно эту такой особенной?\n" +
                "Дойдя до конца коридора, я глубоко вдохнул, закрыл глаза, коротко помолился и вышел во двор.\n" +
                "Передо мной встала странная картина. У огромного аппарата, из которого бил синий луч, стоял",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                ".. человек? ",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Подходя ближе, я начинал различать в нём силуэт",
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
                "О боже.. это...\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                $"Здравствуй, {context.PlayerName}. Я ждал тебя.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Это был усопший...\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                $"Помню нашу первую встречу. Я хотел убить тебя, так как видел в тебе угрозу, но воздержался. Как ты думаешь, почему?\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Он отступил от аппарата и медленно повернулся ко мне лицом.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                $"Я увидел в тебе себя. Такого же сильного человека, который способен, если захочет, полностью изменить Землю. Сделать её лучше.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Он шагнул ближе.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                $"Наш мир уже давно утопает в крови. Войны. Разрушение природы. Человек решил, что он властвует над планетой.. " +
                $"но на самом деле он всего лишь обычный турист. Временный гость.\n" +
                $"Понять он, конечно же, этого не сможет. Он уже так сильно надышался собственным величием, что забыл, кем на самом деле является.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Он замолчал на секунду - будто переживая что-то далёкое.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                $"Я понял это ещё в детстве, когда увидел, как мой отец срубает дерево ради получения брёвен. Он был врачом, одним из лучших... " +
                $"Человеком, который спасал жизни.\nИ этот же человек решил вдруг оборвать жизнь дереву. Части природы. Зачем? " +
                $"Ради получения каких-то обычных досок?\nС годами я всё яснее видел: человека уже не исправить. " +
                $"Он продолжит уничтожать всё живое, пока Земля окончательно не умрёт.\n" +
                $"Тогда я решил взять всё в свои руки. Вернуть планете её былое величие.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Кто ты такой?\n",
                TextRole.MainCharacter,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                $"Меня зовут Сайленс Бриз. Именно я устроил первый взрыв, который почти полностью стёр всё живое. " +
                $"Я - тот, кто спасёт эту планету от вымирания.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Спасёт?.. ",
                TextRole.MainCharacter,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Print(
                "Спасёт, истребив всё, что создал человек? Истребив самого человека?..\n",
                TextRole.MainCharacter,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                $"Да. ",
                TextRole.SilenceBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                $"К сожалению, пришлось пойти на жертву и немного разрушить планету. " +
                $"Сейчас Земля в ужасном состоянии, но это - временно. " +
                $"Мне осталось лишь покончить с оставшимися людьми, которые сумели выжить. " +
                $"А после этого я начну процесс терраформирования, который восстановит планету и, в конечном итоге, спасёт её.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Всё это время я думал, что видел новый вид энигм. Но на самом деле это был ты?.. Ты следил за мной почти каждый день. ",
                TextRole.MainCharacter,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(2000, context.InstantText);

            context.Printer.Print(
                "Зачем?\n",
                TextRole.MainCharacter,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                $"Я надеялся, что взрыв уничтожит всех людей. Но я просчитался. Просчитался во многих вещах. " +
                $"Помимо того, что он навредил самой Земле, он ещё и не убил всех людей. А тех, кого настиг, лишь.. изменил. " +
                $"Превратил в чудовищ.\nЯ был в эпицентре взрыва, так что сильнее всего он повлиял на меня. Но я не стал тварью, как другие... ",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                $"Я стал Богом. ",
                TextRole.SilenceBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                $"Получил такие способности, о которых обычные люди могут только мечтать.\n" +
                $"Тогда я понял, что это судьба. Что мне дарован второй шанс, чтобы спасти Землю. " +
                $"Исправить все те ошибки, которые допустил в первый раз.\n" +
                $"Но каждый день.. год за годом.. в моей голове возникал образ человека... " +
                $"Человека, достаточно сильного, чтобы помешать мне. И этим человеком был ты.\n" +
                $"Я долго искал тебя, и, когда нашёл, увидел в тебе не врага, а потенциального союзника.\n" +
                $"Поэтому ты выжил в первый день нашей встречи. Поэтому я начал наблюдать за тобой.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "В морге ты тоже просто наблюдал?\n",
                TextRole.MainCharacter,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                $"Мне нужно было убедиться, что ты и вправду очень сильный. Что ты выдержишь мои испытания.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Он протянул ко мне руку - уверенно, без тени сомнения.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                $"Сейчас, {context.PlayerName}, ты стоишь на пороге перемен, которые навсегда изменят судьбу мира.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Готов ли ты помочь мне?.. Помочь мне в спасении мира?\n",
                TextRole.SilenceBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "1) Помочь Сайленсу\n" +
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
                    sceneManager.GoTo("scene17", context);
                    return;
                }
                else if (input == "2")
                {
                    sceneManager.GoTo("scene16", context);
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