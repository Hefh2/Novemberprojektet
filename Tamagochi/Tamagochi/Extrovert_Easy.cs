using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raise_a_Henning
{
    class Extrovert_Easy : Pet
    {
        protected override string typ { get; set; } = "Extrovert";
        protected override string asciiArt { get; set; } = "";

        private int matAvtag;
        private int sallskapAvtag;
        private int sallskapAndraAvtag;
        private int karlekAvtag;
        private int motionAvtag;
        
        public override void Tick()
        {
            mat = mat - matAvtag;
            sallskap = sallskap - sallskapAvtag;
            sallskapAndra = sallskapAndra - sallskapAndraAvtag;
            karlek = karlek - karlekAvtag;
            motion = motion - motionAvtag;
            dollar = dollar + dollarOkning;

        }

        public override void ListActions()
        {
            Console.WriteLine("Du kan:\n1. Mata " + name + "\n2. Ta en promenad med " + name + "\n3. Äta middag på stan med " + name + "\n4. Ordna en spel kväll åt " + name + " och " + name + "s kompisar" +
                "\n5. Släppa ut " + name + " att vara med sina kompisar ett tag\n ");
        }

        public override void TakeTurn()
        {

            bool loop = true;
            while (loop == true)
            {
                PrintStats();
                ListActions();

                string whichAction = Console.ReadLine();
                if (whichAction == "1")
                {
                    action1();
                    loop = false;
                }
                else if (whichAction == "2")
                {
                    action2();
                    loop = false;
                }
                else if (whichAction == "3")
                {
                    action3();
                    loop = false;
                }
                else if (whichAction == "4")
                {
                    action4();
                    loop = false;
                }
                else if (whichAction == "5")
                {
                    action5();
                    loop = false;
                }

                Tick();
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
    }
}
