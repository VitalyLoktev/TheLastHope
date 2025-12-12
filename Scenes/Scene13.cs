using System;

namespace Game
{
    internal class Scene13 : IScene
    {
        public string Id => "scene13";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Ненавижу это место. ",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "В детстве я был всего один раз в таком помещении, и даже этого хватило для бессонных ночей и жутких кошмаров...\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(2000, context.InstantText);

            context.Printer.Print(
                "А теперь мне надо было переночевать здесь, среди трупов. Но выбора нет: лучше поспать, чем продолжать путь без сил.\n" +
                "Я лёг подальше от холодильных камер и уснул.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(5000, context.InstantText);

            context.Printer.Print(
                "Резко проснувшись от внезапного шума, я открыл глаза и увидел в дверном проёме",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                ".. ",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(2000, context.InstantText);

            context.Printer.Print(
                "усопшего.",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Я схватил автомат, нацелился и приготовился к тому, что он снова попытается поглотить мою душу. " +
                "Но, к моему удивлению, он лишь поднял руку и лёгким движением провёл её вдоль стороны, " +
                "где стояли холодильные камеры - и тут же рассыпался в дым, исчезая.\nЯ посмотрел на камеры и заметил, что они.. ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "начали открываться.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Мертвецы...\n",
                TextRole.MainCharacter,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Да, они были самыми слабыми из всех видов энигм, но их было так много...\n" +
                "Оставаться здесь больше было нельзя. Я закрепил автомат за спиной и бросился к выходу. " +
                "Выбежав из помещения с холодильными камерами, я увидел, что мертвецы начали выходить и из других комнат морга.\n" +
                "Выход был заграждён, поэтому мне пришла в голову единственная мысль - подняться на второй этаж и попытаться отстрелять их сверху.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Но мертвецы были и там...\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Я начал отстреливать тех, кто находился на втором этаже, и тех, кто поднимался с первого.\n" +
                "Двое мертвецов всё-таки настигли меня и вцепились зубами в спину.\nМой крик был громче любой очереди, что вырывалась из ствола.\n",
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

            if (context.Hearts.IsDead)
            {
                context.Printer.WaitForKeyIfInstant(context.InstantText);
                sceneManager.GoTo("death", context);
                return;
            }

            context.Printer.Print(
                "Сквозь боль я вырвался, всадив нож обоим под челюсть. Они повалились, но я едва держался на ногах.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Что теперь?..\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "1) Выпрыгнуть через окно\n" +
                "2) Укрыться в помещении\n> ",
                TextRole.System,
                TextSpeed.VerySlow,
                context.InstantText
            );

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == "1")
                {
                    sceneManager.GoTo("scene14", context);
                    return;
                }
                else if (input == "2")
                {
                    sceneManager.GoTo("scene19", context);
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