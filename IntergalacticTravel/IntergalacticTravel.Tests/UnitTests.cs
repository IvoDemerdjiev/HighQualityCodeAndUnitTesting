namespace IntergalacticTravel.Tests
{
    using NUnit.Framework;
    using System;
    using IntergalacticTravel;
    using IntergalacticTravel.Contracts;
    using Exceptions;

    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void Pay_IfNullIsPassed_ShoudThrowNullReferenceException()
        {
            var Unit = new Unit(1,"Pesho");

            Assert.Throws<NullReferenceException>(() => Unit.Pay(null));
        }


        [Test]
        public void Pay_ShouldDecreaseTheOwnersAmount()
        {
          
        }

    }
}
