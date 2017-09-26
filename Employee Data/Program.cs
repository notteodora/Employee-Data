using System;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());
            int ID = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Employee ID: {0:d8}", ID);
            Console.WriteLine("Salary: {0:f2}", salary);
        }
    }
}