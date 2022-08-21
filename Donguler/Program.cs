// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;

string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Programlamaya başlangıç için temel kurs";
string kurs3 = "Java";

// array

string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                                  "Programlamaya başlangıç için temel kurs",
                                  "Java",
                                  "Python",
                                  "C#"  };



for (int i = 0; i < kurslar.Length ; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("For bitti");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("sayfa sonu - footer");