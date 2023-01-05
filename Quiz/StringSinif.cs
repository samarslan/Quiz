using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class StringSinif
    {
        public static int Uzunluk(string metin)
        {
            int sayi = 0;
            foreach(char harf in metin.ToCharArray())
            {
                sayi++;
            }
            return sayi;
        }
        public static int DiziUzunluk(string[] metin)
        {
            int sayi = 0;
            foreach (string harf in metin)
            {
                sayi++;
            }
            return sayi;
        }

        public static string Cikar(string metin, int index, int range)
        {
            char[] arr = metin.ToCharArray();
            string cevap = "";
            for (int i = index; i < index+range; i++)
            {
                cevap += arr[i];
            }

            return cevap;
        }
        public static string Birlestir(char c, string[] arr)
        {
            string cevap = "";
            for (int i = 0; i < DiziUzunluk(arr); i++)
            {
                cevap = cevap + c + arr[i];
            }
            return cevap;
        }
        public static int Indexini_bul(string metin, string kisim)
        {

        }
    }
}
