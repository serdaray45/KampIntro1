using System;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {//type safety - tip güvenliği !!!
         //dont repeat yourself - Kendini Tekrar Etme !!!
         //değer tutucu - #alias - takma ad !!!
            string kategoriEtiketi="Kategoriler";
            int ogrenciSayisi = 320000;
            double faizOrani = 1.45;
            bool besiktasSiyahtir =false;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("artış oku !!!");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("azaliş oku!!!");
            }
            else
            {
                Console.WriteLine("eşittir oku!!!");

            }
    


        }
    }
}
