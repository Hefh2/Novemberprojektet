using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raise_a_Henning
{
    class Introvert_Hard : Pet
    {
        protected override string typ { get; set; } = "Introvert";
        protected override string asciiArt { get; set; } = @"
            _     _
           (')-=-(')
         __(   '   )__
        / _/'-----'\_ \
     ___\\ \\     // //___
     >____)/_\---/_\(____<
";

        public override void Tick()
        {
            mat = mat - 20;
            sallskap = sallskap - 5;
            sallskapAndra = sallskapAndra - 5;
            karlek = karlek - 20;
            motion = motion - 20;
            dollar = dollar + dollarOkning;

        }

        public override void ListActions()
        {
            Console.WriteLine("Du kan:\n1. Ge " + name + " ett snack\n2. Lära dig ett spel av " + name + "\n3. Köpa en figurine åt " + name + " från " + name + "s favoritanime" +
                "\n4. Tvinga " + name + " att gå till gymmet\n5. Hjälpa " + name + " att lägga upp en IT-tutorial på youtube\n");
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
            Console.WriteLine("Du ger " + name + " ett gamersnack.");
            mat += 60;
            motion -= 10;
            dollar -= 2;
            //Gamer snacks

            if (mat > 100)
            {
                mat = 100;
            }
        }

        public void action2()
        {
            Console.WriteLine("Du låter " + name + " lära dig ett spel.");
            sallskap += 20;
            //Spel

            if (sallskap > 100)
            {
                sallskap = 100;
            }
        }

        public void action3()
        {
            Console.WriteLine("Du köper en anime figurine åt " + name + " som en present.");
            karlek += 100;
            dollar -= 4;
            //Figurine

            if (karlek > 100)
            {
                karlek = 100;
            }
        }

        public void action4()
        {
            Console.WriteLine("Du tvingar " + name + " att gå till gymmet.");
            motion += 50;
            karlek -= 20;
            //Gymma

            if (motion > 100)
            {
                motion = 100;
            }
        }

        public void action5()
        {
            Console.WriteLine("Du hjälper " + name + " att lägga upp en IT-tutorial på YuoTubo.");
            sallskap += 20;
            dollar += 1;
            //IT-tutorial

            if (sallskap > 100)
            {
                sallskap = 100;
            }
        }
    }
}
