using System;
using System.Collections.Generic;
using System.Linq;
namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            List<ICard> uniques = new List<ICard>();
            var flag = false;
            uniques.Add(hand.Cards[0]);

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = 0; j < uniques.Count; j++)
                {
                    if (uniques[j].Face != hand.Cards[i].Face)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }

                }

                if (flag)
                {
                    uniques.Add(hand.Cards[i]);
                }

            }

            bool allDifferent = uniques.Count == hand.Cards.Count;
            return allDifferent;
        }

        public bool IsStraightFlush(IHand hand)
        {
            var orderedHand = hand.Cards.OrderBy(c => c.Face).ToList();
            int counter = 0;
            for (int i = 0; i < orderedHand.Count - 1; i++)
            {
                if (orderedHand[i].Suit == orderedHand[i + 1].Suit &&
                    orderedHand[i].Face == orderedHand[i + 1].Face + 1)
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                }
            }
            if (counter == 4)
            {
                return true;
            }
            return false;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            int counter = 0;
            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Face == hand.Cards[i + 1].Face)
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                }
            }
            if (counter == 3)
            {
                return true;
            }
            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            var orderedHand = hand.Cards.OrderBy(c => c.Face).ToList();
            int counter = 1;
            bool anotherFlag = false;
            var i = 0;

            for (i = 0; i < orderedHand.Count - 1; i++)
            {
                if (orderedHand[i].Face == orderedHand[i + 1].Face)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            for (int j = i + 1; j < hand.Cards.Count - 1; j++)
            {
                if (orderedHand[j].Face == orderedHand[j + 1].Face)
                {
                    anotherFlag = true;
                }
                else
                {
                    anotherFlag = false;
                    break;
                }
            }

            if ((counter >= 2) && anotherFlag)
            {
                return true;
            }

            return false;

        }

        public bool IsFlush(IHand hand)
        {
            int counter = 0;
            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Suit == hand.Cards[i + 1].Suit)
                {
                    counter++;
                }
            }
            if (counter == 4)
            {
                return true;
            }
            return false;
        }

        public bool IsStraight(IHand hand)
        {
            var orderedHand = hand.Cards.OrderBy(c => c.Face).ToList();
            var counter = 0;
            for (int i = 0; i < orderedHand.Count - 1; i++)
            {
                if (orderedHand[i].Face == orderedHand[i + 1].Face + 1)
                {
                    counter++;
                }
            }
            if (counter == 4)
            {
                return true;
            }
            return false;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            var orderedHand = hand.Cards.OrderBy(c => c.Face).ToList();
            var counter = 1;
            for (int i = 0; i < orderedHand.Count - 1; i++)
            {
                if (orderedHand[i].Face == orderedHand[i + 1].Face)
                {
                    counter++;
                }
                else
                {
                    if (counter == 3)
                    {
                        break;
                    }

                    counter = 1;
                }
            }

            if (counter == 3)
            {
                return true;
            }

            return false;
        }

        public bool IsTwoPair(IHand hand)
        {
            var orderedHand = hand.Cards.OrderBy(c => c.Face).ToList();
            var counter = 1;
            var anotherCounter = 0;

            for (int i = 0; i < orderedHand.Count - 1; i++)
            {
                if (orderedHand[i].Face == orderedHand[i + 1].Face)
                {
                    counter++;
                }
                if (counter == 2)
                {
                    anotherCounter++;
                    counter = 1;
                }
            }

            if (anotherCounter == 2)
            {
                return true;
            }

            return false;
        }

        public bool IsOnePair(IHand hand)
        {
            var orderedHand = hand.Cards.OrderBy(c => c.Face).ToList();
            var counter = 1;
            for (int i = 0; i < orderedHand.Count - 1; i++)
            {
                if (orderedHand[i].Face == orderedHand[i + 1].Face)
                {
                    counter++;
                }
                if (counter == 2)
                {
                    return true; ;
                }
            }

            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            return true;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            int result = 0;
            for (int i = 0; i < firstHand.Cards.Count; i++)
            {
                if (firstHand.Cards[i].Face > secondHand.Cards[i].Face)
                {
                    result = 1;
                }

                if (firstHand.Cards[i].Face < secondHand.Cards[i].Face)
                {
                    result = -1;
                }
            }

            return result;
        }
    }
}
