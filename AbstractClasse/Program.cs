using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasse
{
    public abstract class parent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string SayHello()
        {
            return "Hello World";
        }
        public abstract decimal GetSalary();
    }
    public class child : parent
    {
        public override decimal GetSalary()
        {
            return 3250.50m;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            child c = new child()
            {
                Age = 25,
                FirstName = "Khadija",
                LastName = "sadki"
            };
            Console.WriteLine($"First Name {c.FirstName} Last Name{c.LastName}");
            decimal salary = c.GetSalary();
            Console.WriteLine($"salary : {salary}");
        }
    }
}
