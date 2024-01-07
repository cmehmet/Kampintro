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

            

        }
    }
}
