using System;

namespace Game
{
    internal class Scene29 : IScene
    {
        public string Id => "scene29";

        public void Run(GameContext context, SceneManager sceneManager)
        {
            context.Printer.Print(
                "Быстро спустившись на первый этаж, я бросился за девочкой.\nМы бежали по коридору, который казался бесконечным.\n" +
                "Сколько бы я ни бежал - конец коридора лишь отдалялся.\nВ какой-то момент свет на моём фонарике начал мигать.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Раз.\nЕщё раз.\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "И вдруг - он окончательно погас.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Я остановился и судорожно начал пытаться включить его.\nИ в тот же миг вокруг вспыхнул свет, а я сам очутился в ",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Pause(800, context.InstantText);

            context.Printer.Print(
                "больнице...\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Вокруг меня было много людей. Каждый из них бился в конвульсиях, выгибался, хрипел.\n" +
                "Я сразу понял, что происходит.\nОни",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                ".. \n",
                TextRole.InternalMonologue,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Pause(1000, context.InstantText);

            context.Printer.Print(
                "мутируют...\n",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Pause(500, context.InstantText);

            context.Printer.Print(
                "Моё сердце забилось так сильно, будто вот-вот разорвётся. Грудь пронзила острая боль.\n" +
                "Я опустился на колени и с ужасом смотрел, как мои руки начинают краснеть, как ногти с неестественной скоростью вытягиваются, " +
                "а кости - смещаются под кожей.\n",
                TextRole.InternalMonologue,
                TextSpeed.Normal,
                context.InstantText
            );

            context.Printer.Print(
                "Это всё означало только одно",
                TextRole.InternalMonologue,
                TextSpeed.Slow,
                context.InstantText
            );

            context.Printer.Print(
                "...\n",
                TextRole.InternalMonologue,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Printer.Pause(850, context.InstantText);

            context.Printer.Print(
                "Я обращаюсь.\n",
                TextRole.InternalMonologue,
                TextSpeed.VerySlow,
                context.InstantText
            );

            context.Ending = EndingType.Secret;

            context.Printer.WaitForKeyIfInstant(context.InstantText);
            sceneManager.GoTo("ending", context);
            return;
        }
    }
}