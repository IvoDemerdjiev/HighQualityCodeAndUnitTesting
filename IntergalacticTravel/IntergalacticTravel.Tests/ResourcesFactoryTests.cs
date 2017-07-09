namespace IntergalacticTravel.Tests
{
    using NUnit.Framework;
    using System;
    using IntergalacticTravel;
    using IntergalacticTravel.Contracts;
    using Exceptions;
    using Moq;
    using System.Collections.Generic;

    [TestFixture]
    public class ResourcesFactoryTests
    {
       [TestCase("create resources gold(20) silver(30) bronze(40)")]
       [TestCase("create resources gold(20) bronze(40) silver(30)")]
       [TestCase("create resources silver(30) bronze(40) gold(20)")]
       [TestCase("create resources silver(30) gold(20) bronze(40)")]
       [TestCase("create resources bronze(40) gold(20) silver(30))")]
       [TestCase("create resources bronze(40) silver(30) gold(20)")]
        public void GetResources_WhenCorrectlySetUpProperties_ShouldReturnANewlyCreatedResources(String message)
        {
            var resourcesFactory = new ResourcesFactory();

            var recorses = resourcesFactory.GetResources(message);

            var bronze = 40;
            var gold = 20;
            var silver = 30;

            Assert.AreEqual(bronze, recorses.BronzeCoins);
            Assert.AreEqual(gold, recorses.GoldCoins);
            Assert.AreEqual(silver, recorses.SilverCoins);
        }

        [TestCase(null)]
        [TestCase(" ")]
        [TestCase("AbsolutelyRandomStringThatMustNotBeAValidCommand")]
        public void GetResources_WhenInCorrectlySetUpProperties_ShouldThrowInvalidOperationException(String str)
        {
            var resourcesFactory = new ResourcesFactory();

            //Assert.Throws<InvalidOperationException>(() => resourcesFactory.GetResources(str));

             Assert.That(() => resourcesFactory.GetResources(str), Throws.InvalidOperationException.With.Message.Contains("command"));

        }

        [TestCase("create resources silver(10) gold(97853252356623523532) bronze(20)")]
        [TestCase("create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)")]
        [TestCase("create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)")]
        public void GetResources_WhenInCorrectlySetUpProperties_ShouldThrowOverflowException(String str)
        {
            var resourcesFactory = new ResourcesFactory();


            Assert.Throws<OverflowException>(() => resourcesFactory.GetResources(str));
        }
    }
}
