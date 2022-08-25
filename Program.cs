namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var database = new AyobolaContext();
            var student = new Student();
            student.Name = "joy";
            student.Martic = 467588;
            database.Students.Add(student);
            var final = database.SaveChanges();


        }
    }
}


    