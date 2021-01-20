using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Açiklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Açiklama = "Diyarbakır Karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Şeftali";
            urun3.Fiyati = 30;
            urun3.Açiklama = "Sulu Şeftali";

            Urun[] urunler = new Urun[] { urun1, urun2 ,urun3};

            //type safe - tip güvenli 

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Açiklama);
                Console.WriteLine("-------------------");

            }

            Console.WriteLine("---------------------------Metodlar---------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle();
            sepetManager.Ekle();
            sepetManager.Ekle();
            sepetManager.Ekle();
            sepetManager.Ekle();
            sepetManager.Ekle();

            SepetManager sepetManager1 = new SepetManager();
            sepetManager.Kaziklandin();


           










        }
    }
}

//dont repeat yourself !!! - Kendini tekrar etme !!! -DRY - Clean Code - Best Practise 