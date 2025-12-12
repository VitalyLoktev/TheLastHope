using System;
using System.Collections.Generic;

namespace Game
{
    /// <summary>
    /// Простой инвентарь игрока.
    /// Хранит предметы по имени и их количество.
    /// </summary>
    internal class Inventory
    {
        /// <summary>
        /// Внутреннее хранилище предметов:
        /// ключ - имя предмета, значение - количество.
        /// </summary>
        private readonly Dictionary<string, int> _items = new Dictionary<string, int>();

        /// <summary>
        /// Добавить предмет в инвентарь.
        /// </summary>
        /// <param name="name">Имя предмета.</param>
        /// <param name="amount">Количество (по умолчанию 1).</param>
        public void AddItem(string name, int amount = 1)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Имя предмета не может быть пустым.", nameof(name));
            }

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Количество должно быть положительным.");
            }

            if (_items.ContainsKey(name))
            {
                _items[name] += amount;
            }
            else
            {
                _items[name] = amount;
            }
        }

        /// <summary>
        /// Проверить, есть ли в инвентаре нужное количество предмета.
        /// </summary>
        public bool HasItem(string name, int amount = 1)
        {
            if (string.IsNullOrWhiteSpace(name) || amount <= 0)
            {
                return false;
            }

            return _items.TryGetValue(name, out int currentAmount) && currentAmount >= amount;
        }

        /// <summary>
        /// Использовать предмет (уменьшить его количество).
        /// Возвращает true, если предмет был успешно использован.
        /// </summary>
        public bool UseItem(string name, int amount = 1)
        {
            if (!HasItem(name, amount))
            {
                return false;
            }

            _items[name] -= amount;

            if (_items[name] <= 0)
            {
                _items.Remove(name);
            }

            return true;
        }

        /// <summary>
        /// Получить текущее количество предмета в инвентаре.
        /// Если предмета нет, вернёт 0.
        /// </summary>
        public int GetItemCount(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return 0;
            }

            return _items.TryGetValue(name, out int count) ? count : 0;
        }

        /// <summary>
        /// Полностью очищает инвентарь.
        /// </summary>
        public void ClearInventory()
        {
            _items.Clear();
        }

        /// <summary>
        /// Показывает, пуст ли инвентарь.
        /// </summary>
        public bool IsEmpty => _items.Count == 0;
    }
}