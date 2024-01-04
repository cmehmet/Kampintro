namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            string course1 = "Java";
            string course2 = "C#";
            string course3 = "C++";
            string course4 = "Python";

            Console.WriteLine(course1);
            Console.WriteLine(course2);
            Console.WriteLine(course3);
            Console.WriteLine(course4);

            Console.WriteLine();

            //arrays
            string[] courses = new string[] { "Java", "C#", "C++", "Python"};

            for (int i = 0; i < courses.Length; i++) 
            {
                Console.WriteLine(courses[i]);
            }
            Console.WriteLine("Sayfa sonu - footer");

            Console.WriteLine();

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
