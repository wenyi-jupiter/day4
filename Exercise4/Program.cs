using System;
using System.Collections.Generic;
namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var newc = new customer(10)
            {
                Name = "roel",
                City = "madrid"

            };
            foreach(var i in createc())
            {
                if (extensions.comapre(newc, i))
                {
                    Console.WriteLine("the new customer was already in the list");
                }
            }
            Console.WriteLine("the new customer was not in the list");
            var cs = createc();

            var addedCustomers = new List<customer>
            {
                 new customer(9)  { Name = "frank", City = "irvine" },
                 new customer(10) { Name = "Diego", City = "manchester" }

            };
            var updatedCustomers = cs.Append(addedCustomers);

            foreach (var c in updatedCustomers)
            {
                if (newc.comapre(c))
                {
                    Console.WriteLine("The new customer was already in the list");
                    return;
                }

            }
            Console.WriteLine("The new customer was not in the list");

        }
        static List<customer> createc()
        {
            return new List<customer>
            {
                new customer(1){Name="sally",City="london"},
                new customer(2){Name="sallh",City="liverpool"}
            };
        }
    }
}
