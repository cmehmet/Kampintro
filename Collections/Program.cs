namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            /*
            string[] names = new string[] { "Mehmet", "Özkan", "Ahmet" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            names[3] = "Furkan";     //IndexOutOfRangeException
            Console.WriteLine(names[3]);
            */

            List<string> names2 = new List<string>() { "Mehmet", "Özkan", "Ahmet" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            names2.Add("Furkan");
            Console.WriteLine(names2[3]);

            
        }
    }
}
