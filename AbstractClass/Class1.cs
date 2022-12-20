using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class Person
    {
      
        public string firstName { get; set; }
        public string lastName { get; set; }
        public abstract void SayName();

    }

    public class Employee: Person
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

}
