using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarLogic
{
    internal class Game
    {
        private List<Card> m_Cards = new List<Card>();
        internal Player m_Player1;
        internal Player m_Player2;
        public Game(String i_PlayerName1, String i_PlayerName2)
        {
            m_Player1 = new Player(i_PlayerName1);
            m_Player2 = new Player(i_PlayerName2);
            initGame();
        }

        private void initGame()
        {
            for (int i = 2; i < 15; i++)
            {
                m_Cards.Add(new Card(i, 1));
                m_Cards.Add(new Card(i, 2));
                m_Cards.Add(new Card(i, 3));
                m_Cards.Add(new Card(i, 4));
            }
            Methods.Shuffle(m_Cards);
            int numOfCards = m_Cards.Count;
            for(int i = 0; i < numOfCards; i++)
            {
                if (i < numOfCards / 2)
                {
                    Card cardToAdd = Methods.DrawCard(this.m_Cards);
                    m_Player1.AddCard(cardToAdd);
                }
                else{
                    Card cardToAdd = Methods.DrawCard(this.m_Cards);
                    m_Player2.AddCard(cardToAdd);
                }
            }
            m_Player1.Shuffle();
            m_Player2.Shuffle();
        }
    }
}
