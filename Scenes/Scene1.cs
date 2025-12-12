using System;

namespace Game
{
    internal class Scene1 : IScene
    {
        public string Id => "scene1";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "О, вы очнулись!\nРезко не открывайте глаза. Вы были в отключке несколько дней, так что постара..\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(2000, context.InstantText);

            context.Printer.Print(
                $"...тише, тише. Не нужно совершать резких движений.\n{context.PlayerName}, верно? " +
                "Хорошо. Не беспокойтесь, вы находитесь в Лечебной Опоре «Тихий Восток». Меня зовут доктор Эдстон Бриз, я ваш лечащий врач.\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Предполагаю, вы почти ничего не помните",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "... ",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Это нормально: у вас нарушена работа гиппокампа, из-за чего воспоминания о последних днях могли просто стереться из памяти.\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "К счастью, наш поясковый отряд вовремя вас нашел, так что мы успели загрузить некоторые частички вашей памяти в систему проекции сознания. " +
                "Проблема в том, что мы загрузили именно ",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "ЧАСТИЧКИ ",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "вашей памяти...\nВижу, вы все ещё растеряны. Позвольте кратко объяснить, что произошло.\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Как вы знаете, десять лет назад на Земле случился взрыв такой силы, что он начал искажать саму природу. " +
                "Мир менялся на глазах, и всё живое вокруг гибло одно за другим.\n" +
                "Небольшие группы людей успели укрыться в бункерах под землей, которые со временем стали нам настоящими домами.\n" +
                "Пять лет никто не решался выйти наружу. Но запасы таяли, и люди начали выходить из-под земли на свой страх и риск.\n" +
                "На удивление, воздух оказался чистым. Казалось, что появилась надежда на новую жизнь. ",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Надежда, которая продлилась всего несколько мгновений.\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Энигмы...\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Люди, которые не успели укрыться в бункерах, изменились под воздействием взрыва. Мутировали и животные.\n" +
                "К сожалению, все они были крайне враждебны, из-за чего нам пришлось снова укрыться в бункерах. " +
                "Шанс на спасение был утрачен в тот самый миг, когда он, наконец, появился.\n" +
                "Но некоторые не смирились с таким исходом. Так и появились сталкеры - люди, которые готовы были снова выйти в потерянный мир и попытаться найти путь к спасению.\n" +
                $"Вы, {context.PlayerName}, один из лучших среди них.. хотя, подозреваю, предпочитаете не думать об этом.\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Восемь дней назад недалеко от нашего форта произошёл выброс энергии такой же силы, как и взрыв, погубивший нашу планету. " +
                "Только вот взрыва, как ни странно, не было.\nРазумеется, необходимо было выяснить, что стало причиной этого выброса. " +
                "Такая информация могла бы пролить свет на события десятилетней давности и приблизить нас к спасению.\n" +
                "«Тихий Восток» никогда не славился сталкерами, поэтому было решено послать человека из Центрального Хаба «Южная Вершина», " +
                "самого ближайшего, не считая наш, форта к выбросу.\nРешено было отправить туда самого искусного сталкера. " +
                "К большому счастью, вы как раз остановились там во время вылазки из Опорного Пункта «Зерно».\n" +
                "О вас не было вестей несколько дней, хотя дорога до выброса и обратно занимает всего один день, из-за чего все потеряли надежду.\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Однако три дня назад наш поясковый отряд нашёл вас за два километра от выброса, без сознания. " +
                "Так вы оказались здесь, и теперь нам крайне необходимо узнать, чем же закончилась ваша миссия.\n" +
                "Мы хотим снова подключить вас к СПС, системе проекции сознания, благодаря которой вы сможете вновь пройти своё " +
                "путешествие и восстановить цепочку событий, чтобы мы смогли получить точную картину произошедшего.\n" +
                "Скажу сразу: это будет тяжело. Так как вы ничего не помните, вам придётся пройти путь с самого начала. " +
                "СПС была создана после взрыва, из-за чего она имеет сбои. В случае отклонения от пройденного ранее маршрута вы будете идти по совершенно иному пути. " +
                "Можно сказать, откроются врата в мультивселенную.\nК сожалению, путешествие вам придётся закончить, ведь никто не знает, какой путь будет истинным.\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Вы согласны помочь нам?\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "1) Да\n" +
                "2) Нет\n> ",
                TextRole.System,
                TextSpeed.VerySlow,
                context.InstantText
            );

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == "1")
                {
                    sceneManager.GoTo("scene2", context);
                    return;
                }
                else if (input == "2")
                {
                    sceneManager.GoTo("scene30", context);
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