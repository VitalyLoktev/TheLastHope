using System;

namespace Game
{
    internal class Scene8 : IScene
    {
        public string Id => "scene8";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Я шёл по правой стороне дороги. Поднимая глаза вверх и смотря в окна зданий, я не раз ловил взгляды, направленные на меня. " +
                "Иногда это были бегуны или мертвецы. Но чаще всего я замечал взгляды усопших...\n" +
                "Помню, как впервые столкнулся с таким видом противников. " +
                "Тогда я доставлял груз из одного форта в другой и по пути решил заглянуть в одинокий дом рядом с большим озером. " +
                "К моему удивлению, он был в отличном состоянии. Зайдя внутрь, я начал искать припасы, но ничего значимого найти не сумел. " +
                "Уже направляясь к выходу, я услышал шум позади себя. Повернувшись, я увидел ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "его...\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Он был похож на обычного человека с очень бледной кожей, ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "но его глаза... ",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Глаза святились ярко тёмно-синим светом. Картина была жуткой - ничего подобного мне раньше не доводилось видеть.\n" +
                "Усопший стоял и смотрел на меня. Он не двигался и даже не подавал признаков агрессии. " +
                "Однако от его взгляда что-то происходило со мной. Голова кружилась, боль разливалась по всему телу, и",
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
                "становилось страшно.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "В какой-то момент мне показалось, что часть моей души уходит, будто эта тварь пытается поглотить её.\n" +
                "Стоять и раздумывать было некогда. Я достал пистолет Макарова и всадил в него всю обойму.\nОн не упал.\n" +
                "Даже не подал признаков того, что я его ранил.\n" +
                "Но он дезориентировался, и это дало мне шанс убежать из дома и от него как можно дальше.\n" +
                "После того случая я начал видеть усопших чуть ли не каждый день. " +
                "Они преследовали меня на каждой миссии, но никогда не приближались так близко, как тогда, в одиноком доме.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "Так и сейчас. Каждые двести - триста метров, поднимая голову вверх, я замечал взгляд одного из усопших. " +
                "Почему они перестали нападать на меня? И почему они не похожи на других энигм?\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(3000, context.InstantText);

            context.Printer.Print(
                "Что это за звук? ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "О нет...\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Небесный страж, энигма второго уровня. Летающая бестия с крыльями почти семь метров в размахе...\n" +
                "Он схватил меня своими когтями и впился в плечи. Через пять секунд я уже поднялся на высоту восьми метров. " +
                "Я схватил ружьё и направил его в стража.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "1) Выстрелить\n" +
                "2) Не стрелять\n> ",
                TextRole.System,
                TextSpeed.Slow,
                context.InstantText
            );

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == "1")
                {
                    sceneManager.GoTo("scene9", context);
                    return;
                }
                else if (input == "2")
                {
                    sceneManager.GoTo("scene21", context);
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