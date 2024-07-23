using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Person
    {
        public string fullName {  get; set; }

        public static explicit operator Employee(Person value)
        {
            string[] str=value.fullName.Split(" ");

            return new Employee()
            {
                FName = str[0],
                LName = str[1],
            };
        }

        public virtual void print()
        {
            Console.WriteLine("Hello");
        }
    }


    class Studen : Person
    {
        public sealed override void print()
        {
            Console.WriteLine("Hello student");
        }
    }

    class Student2 : Studen
    {

    }
}
