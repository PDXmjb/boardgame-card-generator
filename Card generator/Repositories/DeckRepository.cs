using CardGenerator.Models;
using System.Collections.Generic;

namespace CardGenerator.Repositories
{
    public class DeckRepository
    {
        public Deck GetDeck(int deckId)
        {

            // Build a new list of cards.
            using (var context = RDSContext.Create())
            {
                

            }

            // Build each card, with each card label.

            return new Deck("Hi", new List<Card>());
        }
    }
}