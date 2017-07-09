namespace Computers.Logic.Manufacturers
{
    using System.Collections.Generic;

    using Computers;
    using Cpus;
    using HardDrives;
    using VideoCards;

    public class DellComputersFactory : IComputersFactory
    {
        public PersonalComputer CreatePersonalComputer()
        {
            var ram = new Ram(8);
            var videoCard = new ColofulVideoCard();
            var pc = new PersonalComputer(new Cpu64(4, ram, videoCard), ram, new[] { new SingleHardDrive(1000) }, videoCard);
            return pc;
        }

        public Laptop CreteLaptop()
        {
            var ram = new Ram(8);
            var videoCard = new ColofulVideoCard();
            var laptop = new Laptop(new Cpu32(4, ram, videoCard), ram, new[] { new SingleHardDrive(1000) }, videoCard, new LaptopBattery());
            return laptop;
        }

        public Server CreateServer()
        {
            var ram1 = new Ram(64);
            var card = new MonochromeVideoCard();
            var server = new Server(new Cpu64(8, ram1, card), ram1, new List<HardDrive> { new RaidArray(0, new List<HardDrive> { new SingleHardDrive(2000), new SingleHardDrive(2000) }) }, card);
            return server;
        }
    }
}
