using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema lemmikvärv;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsol kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled {userColor} ükssarvik";

            Console.WriteLine("Sissesta oma lemmik värv");
            string userColor = Console.ReadLine();

            if (userColor == "punane")
            {
                Console.WriteLine("oled romantiline.");
            }
            else if (userColor == "sinine")
            {
                Console.WriteLine("oled töökas.");
            }
            else if (userColor == "roheline")
            {
                Console.WriteLine("oled looduse sõber.");
            }
            else
            {
                Console.WriteLine($"oled {userColor} ükssarvik");
            }
            Console.WriteLine("Kena päeva!");

         



                

        }
    }
}
