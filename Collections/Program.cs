﻿using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Serdar", "Ahmet" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            List<string> isimler2 = new List<string>{ "Engin", "Murat", "serdar", "Ahmet" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            Console.WriteLine("-----------------------------------");
            isimler2.Add("Emir KArtal");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            Console.WriteLine("-----------------------------------");






        }
    }
}