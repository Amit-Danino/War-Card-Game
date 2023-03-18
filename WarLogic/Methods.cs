using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarLogic
{
    internal static class Methods
    {
        private static Random rng = new Random();

        public static List<T> Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }

        public static Card DrawCard(List<Card> i_Deck)
        {
            if(i_Deck.Count == 0)
            {
                return null;
            }

            Card cardToReturn = i_Deck[0];
            i_Deck.RemoveAt(0);
            return cardToReturn;
        }
    }
}
