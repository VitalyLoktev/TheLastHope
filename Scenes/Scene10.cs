using System;

namespace Game
{
    internal class Scene10 : IScene
    {
        public string Id => "scene10";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            if (!context.IsTextShownBeforeSelection)
            {
                context.Printer.Print(
                    "Я захлопнул двери и быстро подпер их столом, удачно оказавшимся рядом.\n" +
                    "Крики энигм становились всё громче. В ближайшее время выходить из здания будет слишком опасно...\n",
                    TextRole.InternalMonologue,
                    TextSpeed.Normal,
                    context.InstantText
                );

                context.Printer.Print(
                    "Где я? Регистратура? Куда я попал?\n",
                    TextRole.MainCharacter,
                    TextSpeed.Slow,
                    context.InstantText
                );

                context.Printer.Print(
                    "Решив осмотреться, я начал читать различные листочки, разбросанные на регистрационном столе.\n",
                    TextRole.InternalMonologue,
                    TextSpeed.Normal,
                    context.InstantText
                );

                context.Printer.Print(
                    "Морг...\nДа, похоже, я нашёл идеальное место для укрытия...\n",
                    TextRole.MainCharacter,
                    TextSpeed.Slow,
                    context.InstantText
                );

                context.Printer.Pause(3000, context.InstantText);

                context.Printer.Print(
                    "Нужно найти хорошее помещение, чтобы хотя бы немного отдохнуть.\n",
                    TextRole.MainCharacter,
                    TextSpeed.Slow,
                    context.InstantText
                );

                context.Printer.Print(
                    "Подниматься выше первого этажа я не решил. " +
                    "Обойдя все помещения и не встретив никаких признаков жизни, я подобрал для себя три возможных варианта для ночлега. " +
                    "Первый - лабораторная. Второй - кладовая. Третий - помещение с холодильными камерами.\n",
                    TextRole.InternalMonologue,
                    TextSpeed.Normal,
                    context.InstantText
                );

                context.IsTextShownBeforeSelection = true;
            }

            if (!context.TriedRoomWithRefrigeratingChambers)
            {
                context.Printer.Print(
                    "1) Переночевать в помещении с холодильными камерами\n",
                    TextRole.System,
                    TextSpeed.Slow,
                    context.InstantText
                );
            }

            if (!context.TriedLab)
            {
                context.Printer.Print(
                    "2) Переночевать в лабораторной\n",
                    TextRole.System,
                    TextSpeed.Slow,
                    context.InstantText
                );
            }

            if (!context.TriedStoreroom)
            {
                context.Printer.Print(
                    "3) Переночевать в кладовой\n",
                    TextRole.System,
                    TextSpeed.Slow,
                    context.InstantText
                );
            }

            context.Printer.Print(
                "> ",
                TextRole.System,
                TextSpeed.Slow,
                context.InstantText
            );

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == "1" && !context.TriedRoomWithRefrigeratingChambers)
                {
                    context.TriedRoomWithRefrigeratingChambers = true;
                    sceneManager.GoTo("scene13", context);
                    return;
                }

                else if (input == "2" && !context.TriedLab)
                {
                    context.TriedLab = true;
                    sceneManager.GoTo("scene11", context);
                    return;
                }

                else if (input == "3" && !context.TriedStoreroom)
                {
                    context.TriedStoreroom = true;
                    sceneManager.GoTo("scene12", context);
                    return;
                }

                else
                {
                    context.Printer.Print(
                        "Пожалуйста, введите корректную цифру\n> ",
                        TextRole.System,
                        TextSpeed.Normal,
                        context.InstantText
                    );
                }
            }
        }
    }
}