namespace ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Value Type
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 100;
            // number1 = ? 
            Console.WriteLine(number1);

            int[] numbers1 = {1,2,3};
            int[] numbers2 = { 10, 20, 30 };
            numbers1 = numbers2;
            numbers2[0] = 100;
            // numbers1[0] = ?
            Console.WriteLine(numbers1[0]);

        }
    }
}
