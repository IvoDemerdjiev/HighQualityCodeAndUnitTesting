using System;
using Computers.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class LaptopBatteryCharge
    {
        [TestMethod]
        public void ChargeShouldAddToPercentageWhenGivenPositiveNumber()
        {
            var battery = new LaptopBattery();
            battery.Percentage = 50;
            battery.Charge(10);
            Assert.AreEqual(60, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShouldSubstractPercentageWhenGivenNegativeNumber()
        {
            var battery = new LaptopBattery();
            battery.Percentage = 50;
            battery.Charge(-10);
            Assert.AreEqual(40, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShouldNotGoAboveOneHundred()
        {
            var battery = new LaptopBattery();
            battery.Percentage = 50;
            battery.Charge(80);
            Assert.AreEqual(100,battery.Percentage);
        }

        [TestMethod]
        public void ChargeShouldNotGoBelowZero()
        {
            var battery = new LaptopBattery();
            battery.Percentage = 50;
            battery.Charge(-80);
            Assert.AreEqual(0, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShouldNotChargeWhenNumberIsZero()
        {
            var battery = new LaptopBattery();
            battery.Percentage = 50;
            battery.Charge(0);
            Assert.AreEqual(50, battery.Percentage);
        }
    }
}
