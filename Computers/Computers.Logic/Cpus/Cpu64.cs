namespace Computers.Logic.Cpus
{
    using VideoCards;

    public class Cpu64 : Cpu
    {
        public Cpu64(byte numberOfCores, Ram ram, VideoCard videoCard) 
            : base(numberOfCores, ram, videoCard)
        {
        }

        public override int GetMaxValue()
        {
            return 1000;
        }
    }
}
