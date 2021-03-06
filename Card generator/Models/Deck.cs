﻿using System.Collections.Generic;

namespace CardGenerator.Models
{
    public class Deck
    {
        public string Name { get; private set; }
        public List<Card> Cards { get; private set; }

        public Deck(string name, List<Card> cards)
        {
            Name = name;
            Cards = cards;
        }
    }
}