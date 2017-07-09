namespace Computers.Logic.Cpus
{
    using VideoCards;

    public class Cpu128 : Cpu
    {
        public Cpu128(byte numberOfCores, Ram ram, VideoCard videoCard) 
            : base(numberOfCores, ram, videoCard)
        {
        }

        public override int GetMaxValue()
        {
            return 2000;
        }
    }
}
