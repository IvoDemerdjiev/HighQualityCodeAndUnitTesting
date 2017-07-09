namespace Computers.Logic.Cpus
{
    using System;
    using VideoCards;

    public abstract class Cpu
    {
        private static readonly Random Random = new Random();

        private Ram ram;

        private VideoCard videoCard;

       protected Cpu(byte numberOfCores, Ram ram, VideoCard videoCard)
        {
            this.ram = ram;
            this.NumberOfCores = numberOfCores;
            this.videoCard = videoCard;
        }

        public byte NumberOfCores { get; set; }

        public void GenerateRandomNum(int a, int b)
        {
            int randomNumber;
            do
            {
                randomNumber = Random.Next(0, 1000);
            }
            while (!(randomNumber >= a && randomNumber <= b));
            this.ram.SaveValue(randomNumber);
        }

        public abstract int GetMaxValue();

        public void GetSquareNumber()
        {
            var data = this.ram.LoadValue();

            if (data < 0)
            {
                this.videoCard.Draw("Number too low.");
            }
            else if (data > this.GetMaxValue())
            {
                this.videoCard.Draw("Number too high.");
            }
            else
            {
                var value = 0;
                for (var i = 0; i < data; i++)
                {
                    value += data;
                }

                this.videoCard.Draw(string.Format("Square of {0} is {1}.", data, value));
            }
        }
    }
}
