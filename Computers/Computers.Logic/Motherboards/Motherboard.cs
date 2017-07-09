namespace Computers.Logic.Motherboards
{
    using VideoCards;

    public class Motherboard : IMotherboard
    {
        public Motherboard(Ram ram,VideoCard videoCard)
        {
            this.Ram = ram;
            this.VideoCard = videoCard;
        }

        public Ram  Ram{ get; set; }

        public VideoCard VideoCard{ get; set; }

        public int LoadRamValue()
        {
            return this.Ram.LoadValue();
        }

        public void SaveRamValue(int value)
        {
            this.Ram.SaveValue(value);
        }

        public void DrawOnVideoCard(string data)
        {
           this.VideoCard.Draw(data);
        }
    }
}
