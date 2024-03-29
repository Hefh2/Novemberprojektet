﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raise_a_Henning
{
    abstract class Pet
    {
        //Definierar asciiart från subclass och typ från subclass
        protected abstract string typ { get; set; }
        protected abstract string asciiArt { get; set; }
        
        //Definierar basestats för alla djur
        protected int mat = 100;
        protected int sallskap = 100;
        protected int sallskapAndra = 100;
        protected int karlek = 100;
        protected int motion = 100;
        protected int dollar = 10;
        protected int dollarOkning = 1;
        
        static Random generator = new Random();
        public string name;

        //Kollar om något av stats gått under 1 i vilket fall djuret dör.
        public bool GetAlive()
        {
            if (mat < 1 || sallskap < 1 || sallskapAndra < 1 || karlek < 1 || motion < 1)
            {
                Console.Clear();
                if (mat < 1)
                {
                    Console.WriteLine("\n" + name + " svälte ihjäl.");
                } else if (sallskap < 1)
                {
                    Console.WriteLine("\n" + name + " dog av ensamhet.");
                } else if (sallskapAndra < 1)
                {
                    Console.WriteLine("\n" + name + " dog av att du var för overprotective.");
                } else if (karlek < 1)
                {
                    Console.WriteLine("\n" + name + " dog för att den kände sig oälskad.");
                } else if (motion < 1)
                {
                    Console.WriteLine("\n" + name + " fick ingen träning och dog av flera typer av hjärtsjukdom.");
                }
                return false;
            }

            return true;
        }

        //Clearar text, skriver ut ascii art, skriver ut stats.
        public void PrintStats()
        {
            Console.Clear();
            Console.WriteLine(asciiArt);
            Console.WriteLine("Namn: " + name + "\nTyp: " + typ + "\n\nMat: " + mat + "\nSällskap: " + sallskap + "\nSällskap med andra djur: " + sallskapAndra + "\nKärlek: " + karlek
                + "\nMotion: " + motion + "\n\nPengar: " + dollar + "\n");
        }

        //Hämtar metoder TakeTurn, Tick och ListActions från subklasser.
        public abstract void TakeTurn();
        
        public abstract void Tick();

        public abstract void ListActions();
        
    }
}
