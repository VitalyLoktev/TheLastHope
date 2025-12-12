using System;

namespace Game
{
    internal class Scene31 : IScene
    {
        public string Id => "scene31";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                $"Хорошо, {context.PlayerName}. Мы не может насильно заставить вас подключиться к СПС.\n" +
                $"Пока что лежите и отдыхайте. Через пару дней вы вернётесь к своей прежней работе.\n",
                TextRole.DoctorEdstonBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(5000, context.InstantText);

            context.Printer.Print(
                $"На протяжении нескольких дней я пытался вспомнить хоть что-то, но безрезультатно. " +
                $"Я не хотел подключаться к их системе, так как считал, что это может быть опасно.\n" +
                $"Я явно ощущал груз на душе перед докторами и остальным персоналом, но помочь им так, как хотели они, я не мог.\n" +
                $"По ночам мне снились кошмары, от которых я то и дело вскакивал. Однако после пробуждения всё стиралось из памяти, словно ничего и не снилось.\n" +
                $"Так произошло и на пятый день моего пребывания в \"Тихом Востоке\". На часах было 3:00, и я решил сходить в уборную.\n" +
                $"Пока я мыл руки, кто-то тихо вошёл в уборную. Я не обратил на это внимание, пытаясь вспомнить хотя бы кусочек сна, как вдруг.. " +
                $"мой рот зажали ладонью, а к горлу поднесли нож.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                $"Я надеялся, что ты поможешь. Поможешь мне разузнать о нём. Но ты оказался бесполезным.\n",
                TextRole.Somebody,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                $"Голос был очень знакомым, однако тот, кто говорил, явно пытался исказить его.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                $"Теперь мне придётся самому искать ответы на свои вопросы...\n",
                TextRole.Somebody,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                $"Одним лёгким движением он перерезал мне горло, и я упал. В глазах начало мутнеть.\nЯ попытался закричать, но голос не издавался.\n" +
                $"Он присел рядом со мной, и последнее, что я увидел, - докторский халат, надетый на убийце.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                $"Прощай, {context.PlayerName}. Ты был хорошим сталкером...\n",
                TextRole.Somebody,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            sceneManager.GoTo("death", context);
            return;
        }
    }
}