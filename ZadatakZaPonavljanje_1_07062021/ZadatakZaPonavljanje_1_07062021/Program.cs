using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakZaPonavljanje_1_07062021
{
    class Program
    {
        static void Main(string[] args)
        {
            string broj;
            Console.Write("Upišite neki broj: ");
            broj = Console.ReadLine();
            Console.WriteLine("Traženi broj sa zbrojem deset je: " + KlasaG.Plus10(Convert.ToInt32(broj)));
            Console.WriteLine("Metoda f50 je jednaka: " + KlasaG.f50(Convert.ToInt32(broj)));
            Console.ReadKey();
        }
    }
}
