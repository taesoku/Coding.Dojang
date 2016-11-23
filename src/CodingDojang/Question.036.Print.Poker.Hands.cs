using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang
{

    public static class Question036PrintPokerHands
    {

        public enum Number
        {
            A = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            T = 10,
            J = 11,
            Q = 12,
            K = 13
        }

        public enum Suit
        {
            C = 0,
            D = 1,
            H = 2,
            S = 3
        };

        public class Card
        {

            private Number Number { get; set; }
            private Suit Suit { get; set; }

            public Card(int i)
            {
                Number = (Number) i;
                Suit = Suit.C;
            }

        }




        public class Player<T> where T : Card
        {
            
        }

        public static void Answer()
        {
            var cards = new List<Card>();
            cards.Add(new Card(2));
            var a = cards[0];
        }


    }

}
