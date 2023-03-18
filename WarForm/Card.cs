using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarLogic
{
    internal class Card
    {
        internal int m_Number;
        internal Type m_Type;
        public Card(int i_Number, int i_Type)
        {
            m_Number = i_Number;
            m_Type =(Type)i_Type;
        }

        internal enum Type
        {
            Clubs = 1,
            Diamonds = 2,
            Hearts = 3,
            Spades = 4,
        }
    }
}
