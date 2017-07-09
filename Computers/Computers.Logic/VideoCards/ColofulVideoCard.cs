namespace Computers.Logic.VideoCards
{
    using System;

    public class ColofulVideoCard : VideoCard
    {
        protected override ConsoleColor GetColor()
        {
            return ConsoleColor.Green;
        }
    }
}
