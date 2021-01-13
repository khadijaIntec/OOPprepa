using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprepa
{
    public class Persoon
    {
        public string FullName { get; set; }
        public int Age { get; set; }

        public Persoon()
        {
            Age = 15;
        }
        public Persoon(string fullName) : this()
        {
            this.FullName = fullName;
        }
        public Persoon(string fullName, int age) : this(fullName)
        {
            this.FullName = fullName;
            this.Age = age;
        }


        public void GetDetails()
        {
            Console.WriteLine($"The Fullname is :{FullName} and the Age is {Age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persoon p = new Persoon
            {

                FullName ="Khadija Sadki",
                Age = 28
            };
                 p.GetDetails();
            Console.ReadKey();
          
        }
    }
}
