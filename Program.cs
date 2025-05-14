
    using System;
using ClassLibrary1;

namespace Finalproje1
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                KiralikAraba ke = new KiralikAraba(500, 400, 4, 5, 120, "Toyota");
                KiralikAraba ke1 = new KiralikAraba(600, 450, 2, 4, 110, "Renault");
                KiralikAraba ke2 = new KiralikAraba(700, 500, 5, 5, 130, "Ford");


                SatilikAraba se = new SatilikAraba(500, 3, "Toyota", 5, 120);
                SatilikAraba se1 = new SatilikAraba(400, 5, "Renault", 4, 110);
                SatilikAraba se2 = new SatilikAraba(300, 8, "Ford", 5, 130);

                Console.WriteLine(se.ToString());

                Console.WriteLine(ke.ToString());

                Console.WriteLine($"\nToplam Araba Sayisi: {Araba.Sayac}");
                Console.WriteLine($"Satilik Toyota Fiyatı: {se.FiyatHesapla()}");
                Console.WriteLine($"se tipi: {se.TipiGoster()}");
            }
        }
    }

