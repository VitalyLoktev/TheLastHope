namespace Game
{
    /// <summary>
    /// Класс для учёта и изменения количества сердечек у персонажа.
    /// </summary>
    internal class Hearts
    {
        /// <summary>
        /// Максимальное количество сердечек.
        /// </summary>
        public int MaxHearts { get; }

        /// <summary>
        /// Текущее количество сердечек.
        /// </summary>
        public int CurrentHearts { get; private set; }

        /// <summary>
        /// Создаёт счётчик сердечек.
        /// По умолчанию используется заданное число сердечек.
        /// </summary>
        /// <param name="maxHearts">Максимальное количество сердечек (минимум 1).</param>
        public Hearts(int maxHearts = 4)
        {
            if (maxHearts <= 0)
            {
                maxHearts = 1;
            }

            MaxHearts = maxHearts;
            CurrentHearts = maxHearts;
        }

        /// <summary>
        /// Уменьшает количество сердечек.
        /// </summary>
        /// <param name="amount">Сколько сердечек потерять (по умолчанию 1).</param>
        public void LoseHeart(int amount = 1)
        {
            if (amount <= 0)
            {
                return;
            }

            CurrentHearts -= amount;

            if (CurrentHearts < 0)
            {
                CurrentHearts = 0;
            }
        }

        /// <summary>
        /// Увеличивает количество сердечек, но не выше максимума.
        /// </summary>
        /// <param name="amount">Сколько сердечек восстановить (по умолчанию 1).</param>
        public void GainHeart(int amount = 1)
        {
            if (amount <= 0)
            {
                return;
            }

            CurrentHearts += amount;

            if (CurrentHearts > MaxHearts)
            {
                CurrentHearts = MaxHearts;
            }
        }

        /// <summary>
        /// Восстанавливает здоровье полностью.
        /// </summary>
        public void HealToFull()
        {
            CurrentHearts = MaxHearts;
        }

        /// <summary>
        /// Показывает, полностью ли заполнено здоровье.
        /// </summary>
        public bool IsFull => CurrentHearts >= MaxHearts;

        /// <summary>
        /// Показывает, погиб ли персонаж (закончились ли сердечки).
        /// </summary>
        public bool IsDead => CurrentHearts <= 0;
    }
}