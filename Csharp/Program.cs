using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------First 5 Students List----------");
            for (int i = 0; i < 5; i++)
            {
                students students = new students();
                Console.WriteLine("Enter Your ID: ");
                students.ID = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your Name: ");
                students.name = Console.ReadLine();
                Console.WriteLine("Enter Your GPA: ");
                students.GPA = double.Parse(Console.ReadLine());
                Console.WriteLine("----------");
                students.print();
                Console.WriteLine("***********************");
            }
        }
    }
    class students
    {
        public double ID;
        public string name;
        public double GPA;
      public void print() 
        {
            Console.WriteLine("Your ID is: "+ID);
            Console.WriteLine("Your Name is: "+name);
            Console.WriteLine("Your GPA is: "+GPA);
        }
    }
}
