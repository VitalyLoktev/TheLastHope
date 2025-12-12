using System;
using System.Collections.Generic;

namespace Game
{
    /// <summary>
    /// Управляет всеми сценами игры: регистрирует их и выполняет переходы.
    /// </summary>
    internal class SceneManager
    {
        private readonly Dictionary<string, IScene> _scenes = new Dictionary<string, IScene>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Регистрирует сцену по её идентификатору.
        /// Если сцена с таким Id уже существует, она будет заменена.
        /// </summary>
        /// <param name="scene">Сцена для регистрации.</param>
        public void Register(IScene scene)
        {
            if (scene == null)
            {
                throw new ArgumentNullException(nameof(scene));
            }

            if (string.IsNullOrWhiteSpace(scene.Id))
            {
                throw new ArgumentException("Id сцены не может быть пустым.", nameof(scene));
            }

            _scenes[scene.Id] = scene;
        }

        /// <summary>
        /// Выполняет переход к сцене с указанным идентификатором.
        /// </summary>
        /// <param name="id">Id нужной сцены.</param>
        /// <param name="context">Текущее состояние игры.</param>
        public void GoTo(string id, GameContext context)
        {
            if (!_scenes.TryGetValue(id, out IScene? scene))
            {
                context.Printer.Print(
                    $"Ошибка: сцена с Id \"{id}\" не найдена.",
                    TextRole.System,
                    TextSpeed.Instant,
                    instantMode: true
                );
                return;
            }

            scene.Run(context, this);
        }
    }
}