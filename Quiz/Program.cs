using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime;
            string[] metin = new string[] { "salam", "sucuk", "pastırma" };
            Console.WriteLine("Kelime Girin: ");
            kelime = Console.ReadLine();
            Console.WriteLine("Substring(2,3): "+StringSinif.Cikar(kelime,2,3));
            Console.WriteLine("Join: "+StringSinif.Birlestir('-',metin));


            Console.ReadKey();
        }
    }
}
