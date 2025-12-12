using System;

namespace Game
{
    internal class Scene5 : IScene
    {
        public string Id => "scene5";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "В конце коридора находилась двустворчатая дверь. Стоило мне приоткрыть её, как на меня тут же набросились трое незрячих. " +
                "Скрип петель сыграл со мной плохую шутку. Они услышали шум мгновенно.\nОдин из них ударил меня по груди когтями. " +
                "Острая и рвущая боль пронзила тело.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Hearts.LoseHeart();

            context.Printer.Print(
                "-1 сердце\n",
                TextRole.Death,
                TextSpeed.Slow,
                context.InstantText
            );

            if (context.Hearts.IsDead)
            {
                context.Printer.WaitForKeyIfInstant(context.InstantText);
                sceneManager.GoTo("death", context);
                return;
            }

            context.Printer.Print(
                "Падая назад, я успел перехватить автомат одной рукой и дать короткую очередь прямо им в головы.\n" +
                "Твари рухнули разом - и я вместе с ними.\n" +
                "Оставаться в больнице больше было нельзя. Звук выстрелов разнёсся слишком далеко.\n" +
                "Выйдя на улицу, я как можно быстрее направился в центр.\nТопота бегунов я больше не слышал. Видимо, убежали они далеко.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "Смотреть на полуразрушенный город было неприятно. Раньше я мечтал жить здесь. " +
                "В детстве мы с мамой каждые две недели приезжали сюда за покупками. " +
                "Большое количество разнообразных людей, магазины на каждом углу, суета и нескончаемый городской шум - всё это создавало ощущение чего-то особенного. " +
                "Кому-то такое не нравится. ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Кому-то.. но не мне. ",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Особенно сейчас, когда всё утихло.\n" +
                "Почти всё детство я провёл в маленькой деревушке, где, повзрослев, должен был бы остаться и продолжить дело отца по овощеводству.\n" +
                "Даже не знаю, может, апокалипсис спас меня от этого?..\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(3000, context.InstantText);

            context.Printer.Print(
                "Я несу бред. Наверное, это из-за раны, которую мне нанёс незрячий.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(3000, context.InstantText);

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            if (context.Inventory.HasItem("Аптечка"))
            {
                sceneManager.GoTo("scene6", context);
                return;
            }
            else
            {
                sceneManager.GoTo("scene7", context);
                return;
            }
        }
    }
}