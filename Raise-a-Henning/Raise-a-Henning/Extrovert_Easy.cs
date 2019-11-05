using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raise_a_Henning
{
    class Extrovert_Easy : Pet
    {
        private int matAvtag;
        private int sallskapAvtag;
        private int sallskapAndraAvtag;
        private int karlekAvtag;
        private int motionAvtag;
        private string typ = "Extrovert";

        public void DoAction(int which)
        {
            if (which == 1)
            {
                action1();
            }
            else if (which == 2)
            {
                action2();
            }
            else if (which == 3)
            {
                action3();
            }
            else if (which == 4)
            {
                action4();
            }
            else if (which == 5)
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
            Console.WriteLine("Du kan:\n1. Mata " + name + "\n2. Ta en promenad med " + name + "\n3. Äta middag på stan med " + name + "\n4. Ordna en spel kväll åt " + name + " och " + name + "s kompisar" +
                "\n5. Släppa ut " + name + " att vara med sina kompisar ett tag");
        }

        public void PrintStats()
        {
            Console.WriteLine("Namn: " + name + "Typ: " + typ + "\n\nMat: " + mat + "\nSällskap: " + sallskap + "\nSällskap med andra djur: " + sallskapAndra + "\nKärlek: " + karlek
                + "\nMotion: " + motion + "\n\nPengar: " + dollar);
        }
    }
}
