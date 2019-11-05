using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raise_a_Henning
{
    class Introvert_Hard : Pet
    {
        private int matAvtag;
        private int sallskapAvtag;
        private int sallskapAndraAvtag;
        private int karlekAvtag;
        private int motionAvtag;
        private string typ = "Introvert";

        public void Tick()
        {
            mat = mat - matAvtag;
            sallskap = sallskap - sallskapAvtag;
            sallskapAndra = sallskapAndra - sallskapAndraAvtag;
            karlek = karlek - karlekAvtag;
            motion = motion - motionAvtag;
            dollar = dollar + dollarOkning;

        }

        public void ListActions()
        {
            Console.WriteLine("Du kan:\n1. Ge " + name + " ett snack\n2. Lära dig ett spel av " + name + "\n3. Köpa en figurine åt " + name + " från " + name + "s favoritanime" +
                "\n4. Tvinga " + name + " att gå till gymmet\n5. Hjälpa " + name + " att lägga upp en IT-tutorial på youtube");
        }

        public void PrintStats()
        {
            Console.WriteLine("Namn: " + name + "Typ: " + typ + "\n\nMat: " + mat + "\nSällskap: " + sallskap + "\nSällskap med andra djur: " + sallskapAndra + "\nKärlek: " + karlek
                + "\nMotion: " + motion + "\n\nPengar: " + dollar);
        }
    }
}
