using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterApp
{
    public class ChampionCard : FollowerCard
    {
        public string LevelUpConditions { get; set; }
        public OldCard LevelUpChampionCard { get; set; }

        public ChampionCard()
        {
            LevelUpConditions = "None";
            LevelUpChampionCard = new OldCard();
        }
    }
}
