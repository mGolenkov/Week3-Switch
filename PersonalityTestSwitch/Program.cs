using System;

namespace PersonalityTestSwitch
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
            string userColor = Console.ReadLine().ToLower();

            switch(userColor)
            {
                case "punane":
                    Console.WriteLine("oled romantiline.");
                    break;
                case "sininse":
                    Console.WriteLine("oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("oled looduse sõber.");
                    break;
                default:
                    Console.WriteLine($"oled {userColor} ükssarvik");
                    break;
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
