namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {   
             
            // Do not repeat yourself
            Console.WriteLine("Kategori");
            Console.WriteLine("Kategori");
            Console.WriteLine("Kategori");
            Console.WriteLine("Kategori");
            Console.WriteLine("Kategori");

            Console.WriteLine("Kategoriler");
            Console.WriteLine("Kategoriler");
            Console.WriteLine("Kategoriler");
            Console.WriteLine("Kategoriler");
            Console.WriteLine("Kategoriler");

            Console.WriteLine();

            /*string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);*/

            // type safety
            // value keeper, alias (kategori etiketi)
            string kategoriEtiketi = "Kategoriler";

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            

            int ogrenciSayisi = 120;
            double faizOrani = 1.33;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 9.34;
            double dolarBugun = 9.34;

            if (sistemeGirisYapmisMi)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Kayıt Ol Butonu");
            }

            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else
            {
                Console.WriteLine("Eşittir Simgesi");
            }

        }
    }
}
