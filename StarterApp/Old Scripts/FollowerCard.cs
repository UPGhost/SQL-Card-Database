using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterApp
{
    public class FollowerCard : OldCard
    {
        public int AttackRating { get; set; }
        public int HealthRating { get; set; }
        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }

        public FollowerCard()
        {
            AttackRating = 0;
            HealthRating = 0;
            Attribute1 = "None";
            Attribute2 = "None";
        }
            
    }
}
