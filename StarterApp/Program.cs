using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterApp
{
    class Program 
    {

        static void Main(string[] args)
        {

            TemplarAI Templar = new TemplarAI();

            Console.WriteLine("Welcome, my name is {0} and this is your application.", Templar.AIName);
            Console.WriteLine("The Current Date is {0}", Templar.CurrentDate.ToString());


            //Time Check Because it's late
            BasicFunctions.LateNightCheck(Templar.CurrentDate, Templar.LateHours);      
        }     
    }
}
