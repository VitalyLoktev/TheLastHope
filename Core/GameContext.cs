namespace Game
{
    internal enum EndingType
    {
        None,       // служебное значение
        Good,       // хорошая концовка
        Bad,        // плохая концовка
        Secret      // секретная концовка
    }

    /// <summary>
    /// Хранит текущее состояние игры:
    /// имя игрока, настройки, инвентарь, здоровье и т.д.
    /// </summary>
    internal class GameContext
    {
        /// <summary>
        /// Имя игрока (главного героя).
        /// </summary>
        public string PlayerName { get; set; } = string.Empty;

        /// <summary>
        /// Режим вывода текста:
        /// true  - текст выводится сразу целиком;
        /// false - текст выводится "кинематографично".
        /// </summary>
        public bool InstantText { get; set; } = false;

        /// <summary>
        /// Был ли уже показан текст перед выбором.
        /// </summary>
        public bool IsTextShownBeforeSelection { get; set; } = false;

        /// <summary>
        /// Выбирал ли игрок помещение с холодильными камерами.
        /// </summary>
        public bool TriedRoomWithRefrigeratingChambers { get; set; } = false;

        /// <summary>
        /// Выбирал ли игрок лабораторию.
        /// </summary>
        public bool TriedLab { get; set; } = false;

        /// <summary>
        /// Выбирал ли игрок кладовую.
        /// </summary>
        public bool TriedStoreroom { get; set; } = false;

        /// <summary>
        /// Тип концовки, полученной игроком.
        /// </summary>
        public EndingType Ending { get; set; } = EndingType.None;

        /// <summary>
        /// Инвентарь игрока.
        /// </summary>
        public Inventory Inventory { get; }

        /// <summary>
        /// Здоровье игрока (сердечки).
        /// </summary>
        public Hearts Hearts { get; }

        /// <summary>
        /// Печать текста (цвет, скорость и т.п.).
        /// </summary>
        public TextPrinter Printer { get; }

        /// <summary>
        /// Создаёт новый контекст игры.
        /// </summary>
        public GameContext()
        {
            Inventory = new Inventory();
            Hearts = new Hearts();
            Printer = new TextPrinter();
        }
    }
}