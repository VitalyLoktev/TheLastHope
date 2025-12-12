using System;

namespace Game
{
    internal class Scene22 : IScene
    {
        public string Id => "scene22";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Я резко вскочил и бросился вперёд, сломя голову.\nВдруг раздался пронзительный крик твари. " +
                "Обернувшись, я увидел, как она с высокой скоростью пикирует прямо на меня.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "Ничего больше сделать я не успел. Она вцепилась в меня и одним движением разорвала на две части.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            sceneManager.GoTo("death", context);
            return;
        }
    }
}