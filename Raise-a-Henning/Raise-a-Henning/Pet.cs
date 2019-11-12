using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raise_a_Henning
{
    abstract class Pet
    {
        protected abstract string typ { get; set; }
        protected abstract string asciiArt { get; set; }
        
        protected int mat = 100;
        protected int sallskap = 100;
        protected int sallskapAndra = 100;
        protected int karlek = 100;
        protected int motion = 100;
        protected int dollar = 10;
        protected int dollarOkning = 1;
        
        static Random generator = new Random();
        public string name;

        public bool GetAlive()
        {
            if (mat != 0 || sallskap != 0 || sallskapAndra != 0 || karlek != 0 || motion != 0)
            {
                return true;
            }
            return false;
        }

        public void PrintStats()
        {
            Console.Clear();
            Console.WriteLine(asciiArt);
            Console.WriteLine("Namn: " + name + "\nTyp: " + typ + "\n\nMat: " + mat + "\nSällskap: " + sallskap + "\nSällskap med andra djur: " + sallskapAndra + "\nKärlek: " + karlek
                + "\nMotion: " + motion + "\n\nPengar: " + dollar + "\n");
        }

        public abstract void TakeTurn();
        
        public abstract void Tick();

        public abstract void ListActions();
        
    }
}
