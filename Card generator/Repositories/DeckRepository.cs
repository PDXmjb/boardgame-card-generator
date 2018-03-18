using Card_generator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Card_generator.Repositories
{
    public class DeckRepository
    {
        public Deck GetDeck(int deckId)
        {
            return new Deck("Hi", new List<Card>());
        }
    }
}