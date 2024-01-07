using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Methods
    {
        public void Add()
        {
            Console.WriteLine("Added!");
        }

        public int Add2 (int number1, int number2 = 18) // ---> default parameter (defaultnondefault parametre gelemez)
        {                                               // Defaultu olan parametreden sonra non-default parametre gelemez.    
            return number1 + number2;
        }

        public int Add3 (int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        public int Add4(ref int number3, int number4)
        {
            number3 = 30;
            return number3 + number4;
        }

        public int Add5(out int number5, int number6)
        {
            number5 = 30;
            return number5 + number6;
        }

        public int Multiply (int number1, int number2)
        {
            return (number1 * number2);
        }
        // Method Overloading
        public int Multiply (int number1, int number2, int number3)
        {
            return (number1 * number2 * number3);
        }

        public int Add6 (params int[] number) // params'dan sonra parametre gelemez.
        {
            return number.Sum();
        }


    }
}
