using System;

namespace Game
{
    internal class Scene12 : IScene
    {
        public string Id => "scene12";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Хоть я и понимал, что здесь безопаснее всего, уснуть я всё равно бы тут не смог.\n" +
                "Кладовая была слишком маленькой, поэтому я решил поискать другое место для ночлега.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            sceneManager.GoTo("scene10", context);
            return;
        }
    }
}