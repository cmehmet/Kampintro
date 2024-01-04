namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOperations arithmeticOperations = new ArithmeticOperations();
            arithmeticOperations.Add(2, 7);
            arithmeticOperations.Add(4, 14);

            // Patladı
            /*
            arithmeticOperations.Add2("Elma", 20, "Amasya Elması");
            arithmeticOperations.Add2("Karpuz", 35, "Diyarbakır Karpuzu");
            arithmeticOperations.Add2("Muz", 45, "Anamur Muzu");
            */

            // Tek tek her yeri düzelttik. İyi bir yöntem değil.
            arithmeticOperations.Add2("Elma", 20, "Amasya Elması", 16);
            arithmeticOperations.Add2("Karpuz", 35, "Diyarbakır Karpuzu", 20);
            arithmeticOperations.Add2("Muz", 45, "Anamur Muzu",100);

        }
    }
}
