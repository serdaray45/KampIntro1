using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1= new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStok = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitInStok = 3, UnitPrice = 35 };
            //Pascal Case   // camelCase
            // case sensitive - Büyük Küçük harf duyarlı 
            //steak sol taraf - // heap sağ taraf 
            ProductManager productManager = new ProductManager(); 
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            productManager.Topla2(3, 6);
            int toplamaSonucu = productManager.Topla(3, 6);
            Console.WriteLine(toplamaSonucu*2);
            int toplamaSonucu2 = productManager.Topla(150,150);
            Console.WriteLine(toplamaSonucu2*2);
            int toplamaSonucu3 = productManager.Topla(150, 150);
            Console.WriteLine(toplamaSonucu3 * 2);



            //int,double,bool ---- deger tip
            // diziler , class , abstract class , interface --- referans Tip 
            //ref out 3.ders te tekrarını yap..



        }
    }
}
