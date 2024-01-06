namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Mehmet");
            names.Add("Özkan");
            Console.WriteLine(names.Length());
            names.List();

        }
    }
}
