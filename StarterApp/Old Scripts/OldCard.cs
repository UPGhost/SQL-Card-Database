using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterApp
{
    public class OldCard
    {
        private int IDNumber { get; }
        public string CardName { get; set; }
        public string Region { get; set; }
        public int ManaCost { get; set; }
        public string CardType { get; set; }
        public string CardRarity { get; set; }
        public string CardDescription { get; set; }


        public OldCard()
        {
            IDNumber = -1;
            CardName = "No Name";
            Region = "No Region";
            ManaCost = 0;
            CardType = "No Type";
            CardRarity = "No Rarity";
            CardDescription = "No Description";
        }
    }
}
