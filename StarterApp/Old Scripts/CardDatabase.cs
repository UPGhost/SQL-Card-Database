using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterApp
{
    public class CardDatabase
    {
        public List<OldCard> AllCards { get; set; }
        public List<ChampionCard> ChampionCards { get; set; }
        public List<FollowerCard> FollowerCards { get; set; }
        public List<SpellCard> SpellCards { get; set; }

        public CardDatabase()
        {
            AllCards = new List<OldCard>();
            ChampionCards = new List<ChampionCard>();
            FollowerCards = new List<FollowerCard>();
            SpellCards = new List<SpellCard>();
        }
    }
}
