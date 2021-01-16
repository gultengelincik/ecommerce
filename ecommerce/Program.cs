using System;
namespace ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.ProductAdi = "Evde Spor";
            urun1.ProductTipi = "Pilates & Yoga";
            urun1.ProductMarka = "Delta Spor";
            urun1.ProductFiyati = 200;

            Product urun2 = new Product();
            urun2.ProductAdi = "Halı";
            urun2.ProductTipi = "kilim";
            urun2.ProductMarka = "Vivense Collection";
            urun2.ProductFiyati = 159;

            Product urun3 = new Product();
            urun3.ProductAdi = "Çalışma Odası";
            urun3.ProductTipi = "Çalışma Masası";
            urun3.ProductMarka = "Novak Ahşap Çalışma Masası";
            urun3.ProductFiyati = 500;

            Product[] urunler = new Product[]
            {
            urun1,urun2,urun3
            };
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].ProductAdi + " : " + urunler[i].ProductTipi + " : " + urunler[i].ProductMarka + " : " + urunler[i].ProductFiyati);
            }
            Console.WriteLine();
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.ProductAdi + " : " + urun.ProductTipi + " : " + urun.ProductMarka + " : " + urun.ProductFiyati);
            }
            Console.WriteLine(); 
            int x = 0;
            while (x <= urunler.Length)
            {
                Console.WriteLine(urunler[x].ProductAdi + " : " + urunler[x].ProductTipi + " : " + urunler[x].ProductMarka + " : " + urunler[x].ProductFiyati);
                x++;
            }
            Console.WriteLine();
        }
    }
    class Product
    {
        public string ProductAdi { get; set; }
        public string ProductTipi { get; set; }
        public string ProductMarka { get; set; }
        public int ProductFiyati { get; set; }
    }
}

