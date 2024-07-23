using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Employee
    {
       /* public int Id { get; set; }

        public string Name { get; set; }

        public static int count;

        static Employee()
        {
            count = 0;
            Console.WriteLine("static const");
        }

        public Employee()
        {
            count ++;
            Console.WriteLine("instance const");
        }*/

        public string FName {  get; set; }

        public string LName { get; set; }

        public override string ToString()
        {
            return $"{FName} {LName}";
        }
    }
}
