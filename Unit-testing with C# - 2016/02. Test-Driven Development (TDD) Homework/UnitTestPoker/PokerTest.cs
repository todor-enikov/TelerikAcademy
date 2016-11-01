using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Poker;
using System.Collections.Generic;

namespace UnitTestPoker
{
    [TestFixture]
    public class PokerTest
    {
        [Test]
        public void ToStringMethodInClassCard_ShouldReturCorrectString()
        {
            // Arrange
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
            var expected = "The Face of the card is: Ace and the suit of the card is: Clubs\n";

            // Act and Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, card.ToString());
        }

        [Test]
        public void ToStringMethodInClassHand_ShouldReturCorrectString()
        {
            // Arrange
            var hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            });
            var expected = "The Face of the card is: Ace and the suit of the card is: Clubs\nThe Face of the card is: Ace and the suit of the card is: Diamonds\n";

            // Act and Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, hand.ToString());
        }

        [Test]
        public void IsValidHand_ShouldReturnTrue_IfTheHandIsValid()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Diamonds),
            });
            var expected = true;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsValidHand(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsStraightFlush_ShouldReturnTrue_IfPlayerHasStraightFlushInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
            });
            var expected = true;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsStraightFlush(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsStraightFlush_ShouldReturnFalse_IfPlayerDoesNotHaveStraightFlushInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Diamonds),
            });
            var expected = false;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsStraightFlush(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFourOfAKind_ShouldReturnTrue_IfPlayerHasFourOfAKindInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });
            var expected = true;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsFourOfAKind(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFourOfAKind_ShouldReturnFalse_IfPlayerDoesNotHaveFourOfAKindInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Diamonds),
            });
            var expected = false;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsFourOfAKind(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFullHouse_ShoulReturnTrue_IfPlayerHasFullHouseInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Diamonds),
            });
            var expected = true;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsFullHouse(hand);

           // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFullHouse_ShoulReturnFalse_IfPlayerDoesNotHasFullHouseInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Diamonds),
            });
            var expected = false;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsFullHouse(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFlush_ShouldReturnTrue_IfPlayerDoesNotHaveFlushInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds),
            });
            var expected = true;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsFlush(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFlush_ShouldReturnFalse_IfPlayerDoesNotHaveFlushInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Diamonds),
            });
            var expected = false;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsFlush(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsStraight_ShouldReturnTrue_IfPlayerHasStraightInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            var expected = true;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsStraight(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsStraight_ShouldReturnFalse_IfPlayerDoesNotHaveStraightInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Diamonds),
            });
            var expected = false;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsStraight(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsThreeOfAKind_ShouldReturnTrue_IfPlayerHasThreeOfAKindInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });
            var expected = true;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsThreeOfAKind(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsThreeOfAKind_ShouldReturnFalse_IfPlayerDoesNotHasThreeOfAKindInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });
            var expected = false;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsThreeOfAKind(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsTwoPair_ShouldReturnTrue_IfPlayerHasTwoPairInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });
            var expected = true;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsTwoPair(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsTwoPair_ShouldReturnFalse_IfPlayerDoesNotHasTwoPairInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });
            var expected = false;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsTwoPair(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsOnePair_ShouldReturnTrue_IfPlayerHasOnePairInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });
            var expected = true;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsOnePair(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsOnePair_ShouldReturnFalse_IfPlayerDoesNotHasOnePairInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
            });
            var expected = false;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsOnePair(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsHighCard_ShouldReturnTrue_IfPlayerHasFiveCardsInHisHand()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });
            var expected = true;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.IsHighCard(hand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void CompareHands_ShouldReturnZero_IfTheBothOfTheHandsAreEqual()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });

            IHand anotherHand = new Hand(new List<ICard>() { 
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });
            var expected = 0;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.CompareHands(hand, anotherHand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void CompareHands_ShouldReturnOne_IfTheFirstHandsIsBiggerThanTheSecondOne()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });

            IHand anotherHand = new Hand(new List<ICard>() { 
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });
            var expected = 1;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.CompareHands(hand, anotherHand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void CompareHands_ShouldReturnMinusOne_IfTheSecondHandsIsBiggerThanTheFirstOne()
        {
            // Arrange
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });

            IHand anotherHand = new Hand(new List<ICard>() { 
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });
            var expected = -1;

            // Act
            var checker = new PokerHandsChecker();
            var result = checker.CompareHands(hand, anotherHand);

            // Assert
            NUnit.Core.NUnitFramework.Assert.AreEqual(expected, result);
        }
    }
}
