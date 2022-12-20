using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee() { firstName = "Sample", lastName = "Student" };
            name.SayName();
            Console.ReadLine();
        }
    }
}
