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

        public void DoAction(string which)
        {
            if (which == "1")
            {
                action1();
            }
            else if (which == "2")
            {
                action2();
            }
            else if (which == "3")
            {
                action3();
            }
            else if (which == "4")
            {
                action4();
            }
            else if (which == "5")
            {
                action5();
            }
        }

        public void action1()
        {

        }

        public void action2()
        {

        }

        public void action3()
        {

        }

        public void action4()
        {

        }

        public void action5()
        {

        }

        public void ListActions()
        {
            Console.WriteLine("Du kan:\n1. Mata " + name + "\n2. Mata " + name + " mycket\n3. Leka med " + name + "\n4. Sätta dig framför soffan och kolla på TV med " + name +
                "\n5. Släppa ut " + name + " över natten");
        }

        public void PrintStats()
        {
            Console.Clear();
            Console.WriteLine("Namn: " + name + "Typ: " + typ + "\n\nMat: " + mat + "\nSällskap: " + sallskap + "\nSällskap med andra djur: " + sallskapAndra + "\nKärlek: " + karlek
                + "\nMotion: " + motion + "\n\nPengar: " + dollar + "\n");
        }
    }
}
