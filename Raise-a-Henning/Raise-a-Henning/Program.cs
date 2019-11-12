using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raise_a_Henning
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet p = new Extrovert_Easy();
            //Definierar Pet p så att p som definieras inne i loopen kan användas utanför
            bool loop1 = true;
            while (loop1 == true)
            {
                Console.Clear();
                Console.WriteLine("Vilken typ av husdjur vill du ha?\n1. Extrovert - Lätt\n2. Katt - Mellan\n3. Introvert - Svår\n");
                
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    p = new Extrovert_Easy();
                    loop1 = false;
                } else if (answer == "2")
                {
                    p = new Henning_Medium();
                    loop1 = false;
                } else if (answer == "3")
                {
                    p = new Introvert_Hard();
                    loop1 = false;
                } else
                {
                    Console.WriteLine("Snälla ge ett svar, 1 - 3. Klicka mellanslag för att fortsätta.\n");
                    Console.ReadKey();
                }
                //Frågar spelaren vilken typ av husdjur den vill ha och beroende på det ändrar den p till att vara den typen av husdjur.
                //Om man inte ger ett svar 1 - 3 så säger den åt en det och startar om loopen.
            }

            bool loop2 = true;
            while (loop2 == true)
            {
                Console.Clear();
                Console.WriteLine("Vad vill du ge ditt nya husdjur för namn?\n");

                string answer = Console.ReadLine();

                if (answer.Length > 16)
                {
                    Console.WriteLine("Namnet är för långt, testa något som är 16 bokstäver eller kortare.\n");
                } else if (answer.Length < 1)
                {
                    Console.WriteLine("Du måste ge ditt husdjur ett namn!\n");
                } else
                {
                    p.name = answer;
                    Console.WriteLine("Ditt nya husdjurs namn är " + p.name + "!\n");
                    loop2 = false;
                }
            }
            //Gör en loop som fortsätter tills husdjuret har fått ett namn mellan 1 och 16 bokstäver.

            while (p.GetAlive() == true)
            {
                p.TakeTurn();
            }

            Console.Clear();
            Console.WriteLine("lmao ded");
            Console.ReadKey();
        }
    }
}
