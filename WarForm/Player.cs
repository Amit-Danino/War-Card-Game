using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarLogic
{
    internal class Player
    {
        internal List<Card> m_ActiveCards = new List<Card>();
        internal List<Card> m_CardsToBeShuffled = new List<Card>();
        internal String m_Name;
        public Player(String i_Name)
        {
            m_Name = i_Name;
        }

        public void AddCard(Card i_Card)
        {
            m_CardsToBeShuffled.Add(i_Card);
        }

        public Card DrawCard()
        {
            return Methods.DrawCard(m_ActiveCards);
        }

        public void Shuffle()
        {
            while (this.m_CardsToBeShuffled.Count > 0)
            {
                this.m_ActiveCards.Add(Methods.DrawCard(this.m_CardsToBeShuffled));
            }
        }
    }
}
