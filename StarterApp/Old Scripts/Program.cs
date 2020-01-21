using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarterApp
{
    class Program 
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {
            TemplarAI Templar = new TemplarAI();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserInterface());

            /*Don't do anything right now
              
            Console.WriteLine("{0}: Version Number {1}. Created by {2}", VersionInfo.ApplicationName, VersionInfo.VersionNumber, VersionInfo.CreatorName);
            Console.WriteLine("Welcome, my name is {0} and this is a Card Database for Legends of Runeterra.", Templar.AIName);

            //Time Check Because it's late
            BasicFunctions.LateNightCheck(Templar.CurrentDate, Templar.LateHours);      
            
             */
        }     
    }
}