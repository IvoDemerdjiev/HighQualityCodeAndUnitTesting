namespace IntergalacticTravel.Tests
{
    using NUnit.Framework;
    using System;
    using IntergalacticTravel;
    using IntergalacticTravel.Contracts;
    using Exceptions;

    [TestFixture]
    public class IntergalacticTravelUnitsFactoryTests
    {
        [Test]
        public void GetUnit_WhenAValidCorrespondingCommandIsPassed_ShoudCreateProcyon()
        {
            var factory = new UnitsFactory();

            var Unit = factory.GetUnit("create unit Procyon Gosho 1");

            Assert.IsInstanceOf<Procyon>(Unit);

            
        }

        [Test]
        public void GetUnit_WhenAValidCorrespondingCommandIsPassed_ShoudCreateLuyten()
        {
            var factory = new UnitsFactory();

            var Unit = factory.GetUnit("create unit Luyten Pesho 2");

            Assert.IsInstanceOf<Luyten>(Unit);


        }
        [Test]
        public void GetUnit_WhenAValidCorrespondingCommandIsPassed_ShoudCreateLacaillet()
        {
            var factory = new UnitsFactory();

            var Unit = factory.GetUnit("create unit Lacaille Tosho 3");

            Assert.IsInstanceOf<Lacaille>(Unit);


        }

        [TestCase("     create unit Lacaille Tosho 3")]
        [TestCase(null)]
        [TestCase(" create unit Lacaille Tosho 3")]
        public void GetUnit_WhenTheCommandPassedIsNotInTheValidFormat_ShouldThrowInvalidUnitCreationCommandException(string invalidInput)
        {
            // Arrange
            var factory = new UnitsFactory();

            // Act &&  // Assert
            Assert.Throws<InvalidUnitCreationCommandException>(() => factory.GetUnit(invalidInput));
        }
    }
}
