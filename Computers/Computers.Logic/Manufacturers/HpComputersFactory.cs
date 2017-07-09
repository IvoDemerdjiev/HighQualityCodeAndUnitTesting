namespace Computers.Logic.Manufacturers
{
    using System.Collections.Generic;

    using Computers;
    using Cpus;
    using HardDrives;
    using VideoCards;

    public class HpComputersFactory : IComputersFactory
    {
        public PersonalComputer CreatePersonalComputer()
        {
            var ram = new Ram(2);
            var videoCard = new ColofulVideoCard();
            var pc = new PersonalComputer(new Cpu32(2, ram, videoCard), ram, new[] { new SingleHardDrive(500),  }, videoCard);

            return pc;
        }

        public Laptop CreteLaptop()
        {
            var card = new ColofulVideoCard();
            var ram = new Ram(4);
            var laptop = new Laptop(new Cpu64(2, ram, card), ram, new[] { new SingleHardDrive(500) }, card, new LaptopBattery());
            return laptop;
        }

        public Server CreateServer()
        {
            var serverRam = new Ram(32);
            var serverVideo = new MonochromeVideoCard();
            var server = new Server(new Cpu32(4, serverRam, serverVideo), serverRam, new List<HardDrive> { new RaidArray(0, new List<HardDrive> { new SingleHardDrive(1000), new SingleHardDrive(1000) }) }, serverVideo);

            return server;
        }
    }
}
