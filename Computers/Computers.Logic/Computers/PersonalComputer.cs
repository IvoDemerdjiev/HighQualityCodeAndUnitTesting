namespace Computers.Logic.Computers
{
    using System.Collections.Generic;

    using Cpus;
    using HardDrives;
    using VideoCards;

    public class PersonalComputer : Computer
    {
        public PersonalComputer(Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, VideoCard videoCard)
            : base(cpu, ram, hardDrives, videoCard)
        {
        }

        public void Play(int guessNumber)
        {
            Cpu.GenerateRandomNum(1, 10);
            var number = this.Ram.LoadValue();
            if (number + 1 != guessNumber + 1)
            {
                this.VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                this.VideoCard.Draw("You win!");
            }
        }
    }
}
