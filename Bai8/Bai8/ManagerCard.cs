using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class ManagerCard
    {
        private List<Card> cards;

        public ManagerCard()
        {
            this.cards = new List<Card>();
        }

        public void add(Card card)
        {
            this.cards.Add(card);
        }

        /*public boolean delete(String id)
        {
            Card card = this.cards.stream().filter(t->t.getId().equals(id)).findFirst().orElse(null);
            if (card == null)
            {
                return false;
            }
            this.cards.remove(card);
            return true;
        }*/
    }
}
