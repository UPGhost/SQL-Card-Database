using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterApp
{
    public class TemplarAI
    {
        public string AIName { get; set; }
        public System.DateTime CurrentDate { get; }
        public string[] LateHours { get; set; }

        public TemplarAI()
        {
            AIName = "Templar";
            CurrentDate = DateTime.Now;           
            LateHours = new string[] { "0", "1", "2", "3", "4", "5", "21", "22", "23" };
            
        }
    }
}
