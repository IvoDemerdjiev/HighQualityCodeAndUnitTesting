﻿namespace Computers.Logic.Computers
{
    using System.Collections.Generic;

    using Cpus;
    using HardDrives;
    using VideoCards;

    public class Laptop : Computer
    {
        private readonly LaptopBattery battery;

        public Laptop(Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, VideoCard videoCard, LaptopBattery battery)
            : base(cpu, ram, hardDrives, videoCard)
        {
            this.battery = battery;
        }

        public void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);

            this.VideoCard.Draw(string.Format("Battery status: {0}", this.battery.Percentage));
        }
    }
}
