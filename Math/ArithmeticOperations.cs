using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    internal class ArithmeticOperations
    {
        public void Add(int number1, int number2)
        {
            int sum = number1 + number2;
            Console.WriteLine("Sonuç : " + sum);
        }

        // Böyle yapmamalıyız. Çünkü daha sonra yeni bir ürün bilgisi eklememiz gerekirse (stockAmount),
        // bu methodun kullanıldığı bütün yerler patlar ve hepsini elle düzeltmemiz gerekir.
        // O yüzden direkt olarak Product class'ını parametre olarak vermeliyiz.
        public void Add2(string productName, int price, string description , int stockAmount)//, int stockAmount
        {
            Console.WriteLine("Sepete eklendi : " + " " + productName);
        }
    }
}
