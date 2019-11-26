using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raise_a_Henning
{
    class Extrovert_Easy : Pet
    {
        //Btw alla svårighetsgrader är typ samma kod så jag kommenterar bara den här.

        //Typ och ascii som kan hämtas av pet
        protected override string typ { get; set; } = "Extrovert";
        protected override string asciiArt { get; set; } = @"
                   _ |\_
                   \` ..\
              __,.-' = __Y =
            .'        )
      _    /   ,    \/\_
     ((____|    )_-\ \_-`
     `-----'`-----` `--`
";
        
        //Minskar statsen för varje action spelaren tar.
        public override void Tick()
        {
            mat = mat - 10;
            sallskap = sallskap - 5;
            sallskapAndra = sallskapAndra - 15;
            karlek = karlek - 5;
            motion = motion - 10;
            dollar = dollar + dollarOkning;

        }

        //Lista upp vilka actions spelar kan ta beroende på vilket pet.
        public override void ListActions()
        {
            Console.WriteLine("Du kan:\n1. Mata " + name + "\n2. Ta en promenad med " + name + "\n3. Äta middag på stan med " + name + "\n4. Ordna en spel kväll åt " + name + " och " + name + "s kompisar" +
                "\n5. Släppa ut " + name + " att vara med sina kompisar ett tag\n ");
        }

        //Kombinerar PrintStats, ListActions, (action1 - 5), och tick i en metod som jag kallar TakeTurn. Den Printar stats och actions man kan välja mellan, ser vad spelaren svarar. Tar den actionen och drar ner alla stats ett steg.
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

            }

            Tick();
        }

        //Drar ner och upp alla stats beroende på vad actionen ska representera - Mata höjer mat.
        //Stats kan inte gå över 100.

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
            Console.WriteLine("Du tar med " + name + " på en promand.");
            motion += 50;
            sallskap += 30;
            //Promenad

            if (motion > 100)
            {
                motion = 100;
            }
            if (sallskap > 100)
            {
                sallskap = 100;
            }
        }

        public void action3()
        {
            Console.WriteLine("Du tar med " + name + " på en middag ute på stan.");
            mat += 30;
            sallskap += 30;
            karlek += 30;
            dollar -= 2;
            //Middag

            if (mat > 100)
            {
                mat = 100;
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
            Console.WriteLine("Du hostar en spelkväll för " + name + " och dens vänner.");
            sallskapAndra += 60;
            dollar -= 1;
            //Spelkväll

            if (sallskapAndra > 100)
            {
                sallskapAndra = 100;
            }
        }

        public void action5()
        {
            Console.WriteLine("Du släpper ut " + name + " till dens kompisar att leka.");
            sallskapAndra += 30;
            motion += 15;
            //Utekväll

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
