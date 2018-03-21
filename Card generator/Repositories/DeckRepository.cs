using CardGenerator.Models;
using System.Collections.Generic;

namespace CardGenerator.Repositories
{
    public class DeckRepository
    {
        public Deck GetDeck(int deckId)
        {
            RDSContext.Create();

            return new Deck("Hi", new List<Card>());
        }
    }
}