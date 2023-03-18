using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarForm.Properties;
using WarLogic;

namespace WarForm
{
    public partial class WarGame : Form
    {
        private Game game;
        private Boolean cardsOnBoard = false;
        private Bitmap[] cardsImages = new Bitmap[54];
        private List<Card> cardTiePile = new List<Card>();
        private Boolean wasTie = false;

        public WarGame(String i_playerName1, String i_playerName2)
        {
            game = new Game(i_playerName1, i_playerName2);
            InitializeComponent();
            initializeSpecialComponents();
        }

        private void initializeSpecialComponents()
        {
            labelPlayerName1.Text = game.m_Player1.m_Name;
            labelPlayerName2.Text = game.m_Player2.m_Name;
            labelPlayer1NumCards.Text = game.m_Player1.m_ActiveCards.Count.ToString();
            labelPlayer2NumCards.Text = game.m_Player2.m_ActiveCards.Count.ToString();
            OpenFileDialog open = new OpenFileDialog();

            for (int i = 2; i < 54; i++)
            {
                cardsImages[i] = (Bitmap)Resources.ResourceManager.GetObject("_" + i);
            }

        }

        private void shuffleIfNeeded()
        {
            if (game.m_Player1.m_ActiveCards.Count < 1)
            {
                game.m_Player1.Shuffle();
            }

            if (game.m_Player2.m_ActiveCards.Count < 1)
            {
                game.m_Player2.Shuffle();
            }

            updateLabels();
            if (game.m_Player1.m_ActiveCards.Count == 0)
            {
                MessageBox.Show("Winner is:" + labelPlayerName2.Text + ". Congratulations!");
            }

            if (game.m_Player2.m_ActiveCards.Count == 0)
            {
                MessageBox.Show("Winner is:" + labelPlayerName1.Text + ". Congratulations!");
            }

        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (!cardsOnBoard)
            {
                cardsOnBoard = true;
                buttonDraw.Text = "Ok";
                Card firstPlayerCard = game.m_Player1.DrawCard();
                Card secondPlayerCard = game.m_Player2.DrawCard();
                displayCards(firstPlayerCard, secondPlayerCard);
                shuffleIfNeeded();

                winner(firstPlayerCard, secondPlayerCard);
                shuffleIfNeeded();
            }
            else
            {
                if (!wasTie)
                {
                    labelWinner.Text = "";
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                }
                cardsOnBoard = false;
                buttonDraw.Text = "Draw";
            }
        }

        private void displayCards(Card i_player1, Card i_player2)
        {
            int cardNumber1 = i_player1.m_Number + ((int)i_player1.m_Type-1)*13;
            int cardNumber2 = i_player2.m_Number + ((int)i_player2.m_Type-1)*13;
            pictureBox1.Image = cardsImages[cardNumber1];
            pictureBox2.Image = cardsImages[cardNumber2];
        }

        private void tie()
        {
            pictureBox1.Image = Resources.CardImage;
            pictureBox2.Image = Resources.CardImage;
            wasTie = true;
            for (int i = 0; i < 3; i++)
            {
                cardTiePile.Add(game.m_Player1.DrawCard());
                cardTiePile.Add(game.m_Player2.DrawCard());
                shuffleIfNeeded();
            }
        }

        private void winner(Card i_FirstCard, Card i_SecondCard)
        {
            if (i_FirstCard.m_Number > i_SecondCard.m_Number)
            {
                game.m_Player1.AddCard(i_FirstCard);
                game.m_Player1.AddCard(i_SecondCard);
                labelWinner.Text = labelPlayerName1.Text + " has won!";
                if (wasTie)
                {
                    ifWasTie(game.m_Player1);
                    labelWinner.Text = labelPlayerName1.Text + " has won the tie!";

                }
            }
            else if (i_FirstCard.m_Number < i_SecondCard.m_Number)
            {
                game.m_Player2.AddCard(i_FirstCard);
                game.m_Player2.AddCard(i_SecondCard);
                labelWinner.Text = labelPlayerName2.Text + " has won!";
                if (wasTie)
                {
                    ifWasTie(game.m_Player2);
                    labelWinner.Text = labelPlayerName2.Text + " has won the tie!";

                }
            }
            else
            {
                labelWinner.Text = "Tie!";
                tie();
                game.m_Player1.AddCard(i_FirstCard);
                game.m_Player2.AddCard(i_SecondCard);
            }
        }

        private void updateLabels()
        {
            labelInactiveCards1.Text = game.m_Player1.m_CardsToBeShuffled.Count.ToString();
            labelInactiveCards2.Text = game.m_Player2.m_CardsToBeShuffled.Count.ToString();

            labelPlayer1NumCards.Text = game.m_Player1.m_ActiveCards.Count.ToString();
            labelPlayer2NumCards.Text = game.m_Player2.m_ActiveCards.Count.ToString();

        }

        private void ifWasTie(Player i_winningPlayer)
        {
            while (cardTiePile.Count > 0)
            {
                i_winningPlayer.m_CardsToBeShuffled.Add(cardTiePile[0]);
                cardTiePile.RemoveAt(0);
            }

            wasTie = false;
            shuffleIfNeeded();
        }
    }
}
