namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> footballers = new Dictionary<int, string>();
            int adet = footballers.Count;
            Console.WriteLine(adet);

            footballers.Add(7, "Cristiano Ronaldo");
            footballers.Add(12, "Marcelo");
            footballers.Add(10, "Mesut Özil");
            footballers.Add(9, "Karim Benzema");

            foreach (var footballer in footballers)
            {
                Console.WriteLine(footballer.Value + " - " + footballer.Key);
            }

            MyDictionary<int, string> footballers2 = new MyDictionary<int, string>();
            int size = footballers2.Length();
            Console.WriteLine(size);
            footballers2.Add(17, "Emrah Atay");
            int size2 = footballers2.Length();
            Console.WriteLine(size2);
            Console.WriteLine(footballers2.GetKey(0));
            Console.WriteLine(footballers2.GetValue(17));


        }
    }
}
