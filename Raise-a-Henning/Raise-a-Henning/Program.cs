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
                //Clearar allt och skriver ut vilka val du har på husdjur.
                Console.Clear();
                Console.WriteLine("Vilken typ av husdjur vill du ha?\n1. Extrovert - Lätt\n2. Katt - Mellan\n3. Introvert - Svår\n");
                
                //Definierar vilket husdjuret är beroende på vad du valde och stänger av loopen
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    p = new Extrovert_Easy();
                    loop1 = false;
                } else if (answer == "2")
                {
                    p = new Katt_Medium();
                    loop1 = false;
                } else if (answer == "3")
                {
                    p = new Introvert_Hard();
                    loop1 = false;
                } else
                {
                    //Säger ajabaja för du gav inte ett valid svar - fortsätter loopen
                    Console.WriteLine("Snälla ge ett svar, 1 - 3. Klicka mellanslag för att fortsätta.\n");
                    Console.ReadKey();
                }
            }

            //Samma sak som med loop1 fast med loop2
            bool loop2 = true;
            while (loop2 == true)
            {
                //Clearar och ber om ett namn för ditt husdjur - är det för långt eller inget alls så fortsätter loopen
                Console.Clear();
                Console.WriteLine("Vad vill du ge ditt nya husdjur för namn?\n");

                string answer = Console.ReadLine();

                if (answer.Length > 16)
                {
                    Console.WriteLine("Namnet är för långt, testa något som är 16 bokstäver eller kortare.\n");
                    Console.ReadKey();
                } else if (answer.Length < 1)
                {
                    Console.WriteLine("Du måste ge ditt husdjur ett namn!\n");
                    Console.ReadKey();
                } else
                {
                    p.name = answer;
                    Console.WriteLine("Ditt nya husdjurs namn är " + p.name + "!\n");
                    loop2 = false;
                }
            }

            while (p.GetAlive() == true)
            {
                p.TakeTurn();
            }
            //Kör en loop med TakeTurn() som slutar när djuret dör.
            
            Console.ReadKey();
        }
    }
}
