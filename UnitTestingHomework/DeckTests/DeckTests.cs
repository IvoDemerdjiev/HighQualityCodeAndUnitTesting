namespace DeckTests
{
    using System;

    using NUnit.Framework;

    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void NewDeckShouldContain24Cards()
        {
            Deck testDeck = new Deck();
            Assert.AreEqual(24, testDeck.CardsLeft);
        }

        [Test]
        public void GetNextCardShouldReturnAValidCard()
        {
            Deck testDeck = new Deck();
            Assert.IsTrue(Enum.IsDefined(typeof(CardSuit), testDeck.GetNextCard().Suit));
            Assert.IsTrue(Enum.IsDefined(typeof(CardType), testDeck.GetNextCard().Type));
        }


        [Test]
        public void TestDeck_CheckIfGetNextCardReturnsValidCard_ShouldReturnTrue()
        {
            var deck = new Deck();
            Assert.IsTrue(typeof(Card) == deck.GetNextCard().GetType());
        }


        [Test]
        public void GetNextCardShouldRemoveTheCardFromTheDeck()
        {
            Deck testDeck = new Deck();
            int initialNumberOfCards = testDeck.CardsLeft;
            testDeck.GetNextCard();
            Assert.AreEqual((initialNumberOfCards - 1), testDeck.CardsLeft, "GetNextCard() should remove 1 card from the deck");
        }
    }
}
