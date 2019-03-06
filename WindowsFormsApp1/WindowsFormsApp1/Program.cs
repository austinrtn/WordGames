using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{

    //Program name: Word Game
    //Author: Austin Kolongowski
    //Version: 1.1

    static class Program
    {

        // This method is used to generate random numbers since c#'s random method often generates reapting numbers because it is based
        // of the cpu clock (I believe)
        private static readonly Random getrandom = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame());
        }


    }

    
    public class wordGame
    {
 
        private string word; // The word that needs to be solved 

        private string hint1;
        private string hint2;
        private string hint3;

        public wordGame(string word, string hint1, string hint2, string hint3)
        {
            this.word = word;
            this.hint1 = hint1;
            this.hint2 = hint2;
            this.hint3 = hint3;
        }


        public string getWord()
        {
            return word;
        }

       
        public string getHint1()
        {
            return hint1;
        }


        public string getHint2()
        {
            return hint2;
        }


        public string getHint3()
        {
            return hint3;
        }
    }
}
