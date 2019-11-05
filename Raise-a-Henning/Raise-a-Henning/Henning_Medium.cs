using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raise_a_Henning
{
    class Henning_Medium : Pet
    {
        private int matAvtag;
        private int sallskapAvtag;
        private int sallskapAndraAvtag;
        private int karlekAvtag;
        private int motionAvtag;
        private string typ = "Katt (Henning)";

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
            Console.WriteLine("Du kan:\n1. Mata " + name + "\n2. Mata " + name + " mycket\n3. Leka med " + name + "\n4. Sätta dig framför soffan och kolla på TV med " + name +
                "\n5. Släppa ut " + name + " över natten");
        }

        public void PrintStats()
        {
            Console.WriteLine("Namn: " + name + "Typ: " + typ + "\n\nMat: " + mat + "\nSällskap: " + sallskap + "\nSällskap med andra djur: " + sallskapAndra + "\nKärlek: " + karlek
                + "\nMotion: " + motion + "\n\nPengar: " + dollar);
        }
    }
}
