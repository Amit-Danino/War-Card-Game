using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarLogic
{
    internal class Player
    {
        internal List<Card> m_ActiveCards;
        internal List<Card> m_CardsToBeShuffled;
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
            this.m_ActiveCards = Methods.Shuffle(m_CardsToBeShuffled);
            m_CardsToBeShuffled.Clear();
        }
    }
}
