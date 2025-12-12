using System;

namespace Game
{
    internal class Scene17 : IScene
    {
        public string Id => "scene17";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Ты прав... Во всём прав.\n",
                TextRole.MainCharacter,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                $"Я знаю, {context.PlayerName}.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Я протянул ему руку. Он сжал её в ответ. \nИ в тот же миг со мной начало происходить нечто странное",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "... ",
                TextRole.InternalMonologue,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Print(
                "Я начал меняться.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                $"Чтобы помочь мне, ты должен стать таким же, как я.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "По телу пробежал жар. Кожа начала бледнеть, будто из неё уходила сама жизнь. Я ощущал, как внутри меня рождается сила. " +
                "Сила, с помощью которой я мог.. взять и перевернуть весь мир.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(2000, context.InstantText);

            context.Printer.Print(
                "Я превращался в Бога.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "...\n...\n...\n",
                TextRole.System,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Print(
                "Доктор, что-то не так! Система проекции сознания сбоит, мы не понимаем, что происходит!\n",
                TextRole.DoctorsAssistant,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Он пошёл не по той дороге... Изменил свой выбор... Теперь реальность меняется...\n",
                TextRole.Doctor1,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Что нам делать?! Доктор, скажите, что нам делать?!\n",
                TextRole.DoctorsAssistant,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Это конец.. ",
                TextRole.Doctor1,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "конец всему...\n",
                TextRole.Doctor1,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Pause(5000, context.InstantText);

            context.Printer.Print(
                $"Ты сделал правильный выбор, {context.PlayerName}. Ты спас Землю от высокомерных созданий, которые считали, что она принадлежит им.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                $"Ты молодец.\n",
                TextRole.SilenceBreeze,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(3000, context.InstantText);

            context.Printer.Print(
                "Я резко открыл глаза.\nЯ находился в кабинете, где меня подключали к СПС. " +
                "Света в здании не было - но я почему-то видел всё идеально чётко. Вокруг стояла мёртвая тишина, а на полу.. ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "на полу лежали тела врачей.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "У всех отсутствовали глаза, а их кости.. были вывернуты, словно их сломали изнутри.\n" +
                "Я медленно поднялся и начал осматриваться - и вдруг увидел зеркало, а в нём.. ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "усопшего...\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "Подойдя к зеркалу ближе, я вдруг понял, что в зеркале не усопший",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "...\n",
                TextRole.InternalMonologue,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Pause(2000, context.InstantText);

            context.Printer.Print(
                "В зеркале был я.\n",
                TextRole.InternalMonologue,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Ending = EndingType.Bad;

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            sceneManager.GoTo("ending", context);
            return;
        }
    }
}