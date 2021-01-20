using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim GeliştiriciYetiştirme Kampı";
            string kurs2 = "Proğramlaya Başlangıç İçin Temel Kurs";
            string kurs3 = "java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            Console.WriteLine("------------------------------------------------");





            //array- dizi
            string[] kurslar = new string[] { "Yazilim GeliştiriciYetiştirme Kampı", "Proğramlaya Başlangıç İçin Temel Kurs" , "java","python","futbol","c#" };
            

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar [i]);

            }
            Console.WriteLine("------------------------------------------------");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu !!!");
        }
    }
}
