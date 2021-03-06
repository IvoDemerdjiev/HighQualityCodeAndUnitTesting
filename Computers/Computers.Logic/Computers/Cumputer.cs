﻿namespace Computers.Logic.Computers
{
    using System.Collections.Generic;

    using Cpus;
    using HardDrives;
    using Motherboards;
    using VideoCards;

    public abstract class Computer
    {
        private Motherboard motherboard;

        public Computer(Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, VideoCard videoCard)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
            this.motherboard = new Motherboard(this.Ram,this.VideoCard);
        }

        protected IEnumerable<HardDrive> HardDrives { get; set; }

        protected VideoCard VideoCard { get; set; }

        protected Cpu Cpu { get; set; }

        protected Ram Ram { get; set; }
    }
}
