using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Card_generator.Models
{
    public class CardViewModel
    {
        public CardType Type { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public string Special { get; set; }
        public int WallConfig { get; set; }
    }

    public enum CardType
    {
        Survivor, Food, Military, Utility
    }
}