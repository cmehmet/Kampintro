namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseName = "Java";
            course1.EducatorName = "Ahmet Y.";
            course1.WatchingRate = 71;

            Course course2 = new Course();
            course2.CourseName = "C#";
            course2.EducatorName = "Murat A.";
            course2.WatchingRate = 82;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.EducatorName = "Mehmet T.";
            course3.WatchingRate = 67;

            Console.WriteLine(course1.CourseName + " : " + course1.EducatorName );

            Console.WriteLine();

            Course[] courses = new Course[] { course1, course2, course3 };
            foreach( var course in courses ) 
            {
                Console.WriteLine(course.CourseName + " : " + course.EducatorName);
            }
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string EducatorName { get; set; }
        public int WatchingRate { get; set; }
    }
}
