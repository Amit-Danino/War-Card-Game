using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarLogic
{
    internal class Game
    {
        private List<Card> m_Cards;
        private Player m_Player1;
        private Player m_Player2;
        public Game(String i_PlayerName1, String i_PlayerName2)
        {
            m_Player1 = new Player(i_PlayerName1);
            m_Player2 = new Player(i_PlayerName2);
            initGame();
        }

        private void initGame()
        {
            for (int i = 1; i < 14; i++)
            {
                m_Cards.Add(new Card(i, Card.Type.Diamonds));
                m_Cards.Add(new Card(i, Card.Type.Spades));
                m_Cards.Add(new Card(i, Card.Type.Hearts));
                m_Cards.Add(new Card(i, Card.Type.Clubs));
            }
            Methods.Shuffle(m_Cards);
            for(int i = 0; i < m_Cards.Count; i++)
            {
                if (i < m_Cards.Count / 2)
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

        public void Play()
        {
            Card playerCard1 = m_Player1.DrawCard();
            Card playerCard2 = m_Player2.DrawCard();
            if(playerCard1.m_Number > playerCard2.m_Number)
            {
                m_Player1.AddCard(playerCard1);
                m_Player1.AddCard(playerCard2);
            }
        }
    }
}
