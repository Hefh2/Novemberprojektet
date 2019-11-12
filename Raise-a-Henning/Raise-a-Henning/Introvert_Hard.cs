﻿using System;
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
            motion = motion - 5;
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
