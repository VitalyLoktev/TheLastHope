using System;

namespace Game
{
    internal class Scene2 : IScene
    {
        public string Id => "scene2";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Тогда приступаем к подключению СПС. Не волнуйтесь, вы никак не пострадаете",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "... Я надеюсь.\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Через десять минут\n",
                TextRole.System,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Запуск системы произойдёт через пять, четыре, три, два, один... ",
                TextRole.Doctor1,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                $"Удачи вам, {context.PlayerName}...\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "...\n...\n...\n",
                TextRole.System,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Print(
                $"Страшно. Место выброса помечено мной как самое опасное. Я никогда не приближался туда ближе, чем на три километра, так как рядом всегда бродят толпы энигм. " +
                $"Хватит. Нужно перестать бояться и начать идти. Только от меня зависит возможный шаг к спасению мира...\n" +
                $"Через десять минут я уже был далеко от бункера. Мне надо было в центр, до взрыва прекрасного, города. Задача стояла непростая... " +
                $"В городах всегда много энигм разного уровня опасности. Но именно здесь они почему-то ходят толпами, словно что-то охраняют...\n" +
                $"Чёрт, что это за звук? Нужно где-то укрыться. Вопрос только - где?\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "1) Зайти в больницу, стоящую справа\n" +
                "2) Зайти в жилое здание, стоящее слева\n" +
                "3) Укрыться под машиной\n> ",
                TextRole.System,
                TextSpeed.VerySlow,
                context.InstantText
            );

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == "1")
                {
                    sceneManager.GoTo("scene3", context);
                    return;
                }
                else if (input == "2")
                {
                    sceneManager.GoTo("scene27", context);
                    return;
                }
                else if (input == "3")
                {
                    sceneManager.GoTo("scene26", context);
                    return;
                }
                else
                {
                    context.Printer.Print(
                        "Пожалуйста, введите 1, 2 или 3:\n> ",
                        TextRole.System,
                        TextSpeed.Normal,
                        context.InstantText
                    );
                }
            }
        }
    }
}