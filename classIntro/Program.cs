﻿using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Serdar Arslan";
            kurs1.IzlenmeOrani = 69;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Emir Kartal Arslan";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "Zeynep Naz Arslan";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs4= new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Ayşe Arslan";
            kurs4.IzlenmeOrani = 100;


            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3,kurs4 };

            foreach (var kurs in kurslar)
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            {

            }
        }
    }

    class Kurs
    {
        public string  KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int  IzlenmeOrani { get; set; }



    }
}
