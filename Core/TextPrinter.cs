using System;
using System.Threading;

namespace Game
{
    /// <summary>
    /// Роль текста — кто "говорит".
    /// </summary>
    internal enum TextRole
    {
        MainCharacter,            // главный герой (игрок)
        InternalMonologue,        // внутренний монолог
        DoctorEdstonBreeze,       // доктор Эдстон Бриз
        Doctor1,                  // первый доктор
        DoctorsAssistant,         // помощник доктора
        System,                   // системные сообщения
        Somebody,                 // кто-то
        Death,                    // смерть или потеря сердца
        Heal,                     // восполнение сердца
        SilenceBreeze,            // Сайленс Бриз
        Hunter1,                  // первый охотник
        Hunter2,                  // второй охотник
        GoodEnding,               // хорошая концовка
        BadEnding,                // плохая концовка
        SecretEnding              // секретная концовка
    }

    /// <summary>
    /// Скорость печати текста.
    /// </summary>
    internal enum TextSpeed
    {
        Instant,     // сразу весь текст
        Fast,        // быстро
        Normal,      // средне
        Slow,        // медленно
        VerySlow     // очень медленно
    }

    /// <summary>
    /// Отвечает за вывод текста:
    /// - выбор цвета по роли,
    /// - посимвольный вывод,
    /// - поддержка мгновенного режима,
    /// - обработка пауз.
    /// </summary>
    internal class TextPrinter
    {
        /// <summary>
        /// Печатает текст с учётом роли, скорости и мгновенного режима.
        /// </summary>
        public void Print(string text,
                          TextRole role = TextRole.System,
                          TextSpeed speed = TextSpeed.Normal,
                          bool instantMode = false,
                          bool addNewLine = false)
        {
            if (string.IsNullOrEmpty(text))
            {
                if (addNewLine)
                {
                    Console.WriteLine();
                }    
                return;
            }

            Console.ForegroundColor = GetColorForRole(role);

            // Выбор задержки между символами
            int delay = instantMode || speed == TextSpeed.Instant
                ? 0
                : GetDelayForSpeed(speed);

            // Нормализуем переводы строк: \r\n -> \n
            string normalized = text.Replace("\r\n", "\n");

            // Основной вывод текста
            foreach (char c in normalized)
            {
                if (c == '\n')
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(c);

                    if (delay > 0)
                    {
                        Thread.Sleep(delay);
                    }
                }
            }

            // Добавить пустую строку, если нужно
            if (addNewLine)
            {
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Выполняет паузу, но в мгновенном режиме она пропускается.
        /// </summary>
        public void Pause(int milliseconds, bool instantMode = false)
        {
            if (instantMode)
            {
                return;
            }

            if (milliseconds > 0)
            {
                Thread.Sleep(milliseconds);
            }
        }

        /// <summary>
        /// В режиме мгновенного вывода текста просит игрока нажать клавишу и ждёт ввода.
        /// В кинематографичном режиме ничего не делает.
        /// </summary>
        public void WaitForKeyIfInstant(bool instantMode, string message = "Пожалуйста, нажмите любую клавишу для продолжения...")
        {
            if (!instantMode)
            {
                return;
            }

            Print(message + "\n", TextRole.System, TextSpeed.Instant, instantMode: true);

            Console.ReadKey(true);
        }

        /// <summary>
        /// Определяет цвет текста в зависимости от роли.
        /// </summary>
        private ConsoleColor GetColorForRole(TextRole role)
        {
            return role switch
            {
                TextRole.MainCharacter => ConsoleColor.Yellow,
                TextRole.InternalMonologue => ConsoleColor.White,
                TextRole.DoctorEdstonBreeze => ConsoleColor.Blue,
                TextRole.Doctor1 => ConsoleColor.DarkBlue,
                TextRole.DoctorsAssistant => ConsoleColor.DarkGreen,
                TextRole.System => ConsoleColor.Gray,
                TextRole.Somebody => ConsoleColor.DarkRed,
                TextRole.Death => ConsoleColor.Red,
                TextRole.Heal => ConsoleColor.Green,
                TextRole.SilenceBreeze => ConsoleColor.Magenta,
                TextRole.Hunter1 => ConsoleColor.DarkYellow,
                TextRole.Hunter2 => ConsoleColor.DarkMagenta,
                TextRole.GoodEnding => ConsoleColor.Green,
                TextRole.BadEnding => ConsoleColor.Red,
                TextRole.SecretEnding => ConsoleColor.Magenta,
                _ => ConsoleColor.Gray
            };
        }

        /// <summary>
        /// Возвращает задержку между символами для указанной скорости.
        /// </summary>
        private int GetDelayForSpeed(TextSpeed speed)
        {
            return speed switch
            {
                TextSpeed.Instant => 0,
                TextSpeed.Fast => 25,
                TextSpeed.Normal => 75,
                TextSpeed.Slow => 140,
                TextSpeed.VerySlow => 300,
                _ => 0
            };
        }
    }
}