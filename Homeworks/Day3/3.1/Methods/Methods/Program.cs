namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            Methods methods = new Methods();
            methods.Add();
            methods.Add();

            Console.WriteLine("--------------------");

            int result1 = methods.Add2(17, 7);
            int result2 = methods.Add2(17);
            Console.WriteLine("Result1 : " + result1 + " Result2 : " + result2);

            Console.WriteLine("--------------------");

            int number1 = 7;
            int number2 = 23;
            int result3 = methods.Add3(number1, number2);
            Console.WriteLine("Result : " + result3 + " Number1 : " + number1);

            Console.WriteLine("--------------------");

            int number3 = 7;
            int number4 = 23;
            int result4 = methods.Add4(ref number3, number4);
            Console.WriteLine("Result : " + result4 + " Number1 : " + number3);

            Console.WriteLine("--------------------");

            int number5;
            int number6 = 23;
            int result5 = methods.Add5(out number5, number6);
            Console.WriteLine("Result : " + result5 + " Number1 : " + number5);

            Console.WriteLine("--------------------");

            Console.WriteLine(methods.Multiply(5,7));
            Console.WriteLine(methods.Multiply(5,7,3));

            Console.WriteLine(methods.Add6(2,3,4,5,6,7));

        }
    }
}
