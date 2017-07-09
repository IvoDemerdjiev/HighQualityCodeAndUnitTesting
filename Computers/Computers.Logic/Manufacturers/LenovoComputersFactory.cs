namespace Computers.Logic.Manufacturers
{
    using System.Collections.Generic;

    using Computers;
    using Cpus;
    using HardDrives;
    using VideoCards;

    public class LenovoComputersFactory : IComputersFactory
    {
        public PersonalComputer CreatePersonalComputer()
        {
            var ram = new Ram(4);
            var videoCard = new MonochromeVideoCard();
            var pc = new PersonalComputer(new Cpu64(2, ram, videoCard), ram, new[] { new SingleHardDrive(2000),  }, videoCard);
            return pc;
        }

        public Laptop CreteLaptop()
        {
            var card = new ColofulVideoCard();

            var ram = new Ram(16);
            var laptop = new Laptop(new Cpu64(2, ram, card), ram, new[] { new SingleHardDrive(1000) }, card, new LaptopBattery());
            return laptop;
        }

        public Server CreateServer()
        {
            var serverRam = new Ram(8);
            var serverVideo = new MonochromeVideoCard();
            var server = new Server(new Cpu128(2, serverRam, serverVideo), serverRam, new List<HardDrive> { new RaidArray(0, new List<HardDrive> { new SingleHardDrive(500), new SingleHardDrive(1000) }) }, serverVideo);

            return server;
        }
    }
}
