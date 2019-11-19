using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raise_a_Henning
{
    class Katt_Medium : Pet
    {
        protected override string typ { get; set; } = "Katt (Henning)";
        protected override string asciiArt { get; set; } = @"
        /\_____/\
       /  o   o  \
      ( ==  ^  == )
       )         (
      (           )
     ( (  )   (  ) )
    (__(__)___(__)__)
";
        
        public override void Tick()
        {
            mat = mat - 5;
            sallskap = sallskap - 10;
            sallskapAndra = sallskapAndra - 10;
            karlek = karlek - 20;
            motion = motion - 5;
            dollar = dollar + dollarOkning;

        }

        public override void ListActions()
        {
            Console.WriteLine("Du kan:\n1. Mata " + name + "\n2. Mata " + name + " mycket\n3. Leka med " + name + "\n4. Sätta dig framför soffan och kolla på TV med " + name +
                "\n5. Släppa ut " + name + " över natten\n");
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
            Console.WriteLine("Du matar " + name + ".");
            mat += 30;
            dollar -= 1;
            //Mata

            if (mat > 100)
            {
                mat = 100;
            }
        }

        public void action2()
        {
            Console.WriteLine("Du matar " + name + " mycket.");
            mat += 60;
            karlek += 30;
            motion -= 10;
            dollar -= 2;
            //Mata mycket

            if (mat > 100)
            {
                mat = 100;
            }
            if (karlek > 100)
            {
                karlek = 100;
            }
        }

        public void action3()
        {
            Console.WriteLine("Du leker med " + name + ".");
            sallskap += 30;
            karlek += 30;
            motion += 40;
            //Lek

            if (motion > 100)
            {
                motion = 100;
            }
            if (sallskap > 100)
            {
                sallskap = 100;
            }
            if (karlek > 100)
            {
                karlek = 100;
            }
        }

        public void action4()
        {
            Console.WriteLine("Du kollar på TV tillsammans med " + name + ".");
            karlek += 50;
            sallskap += 30;
            motion -= 20;
            //TV

            if (karlek > 100)
            {
                karlek = 100;
            }
            if (sallskap > 100)
            {
                sallskap = 100;
            }
        }

        public void action5()
        {
            Console.WriteLine("Du släpper ut " + name + " över natten.");
            motion += 20;
            sallskapAndra += 40;
            //Släpp ut

            if (motion > 100)
            {
                motion = 100;
            }
            if (sallskapAndra > 100)
            {
                sallskapAndra = 100;
            }
        }
    }
}
