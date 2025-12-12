namespace Game
{
    /// <summary>
    /// Базовый интерфейс для любой сцены игры.
    /// </summary>
    internal interface IScene
    {
        /// <summary>
        /// Уникальный идентификатор сцены.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Выполняет логику сцены: вывод текста, обработку ввода и переходы.
        /// </summary>
        /// <param name="context">Общее состояние игры.</param>
        /// <param name="sceneManager">Менеджер сцен (для переходов).</param>
        void Run(GameContext context, SceneManager sceneManager);
    }
}