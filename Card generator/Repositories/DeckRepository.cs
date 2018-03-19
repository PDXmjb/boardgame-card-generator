using Card_generator.Models;
using System.Collections.Generic;

namespace Card_generator.Repositories
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