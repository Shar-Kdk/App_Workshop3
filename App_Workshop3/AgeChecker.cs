using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Workshop3
{
    internal class AgeChecker
    {
        public void CheckAge()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 13)
                Console.WriteLine("You are a child.");
            else if (age < 20)
                Console.WriteLine("You are a teenager.");
            else if (age < 60)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are a senior citizen.");
        }
    }
}
