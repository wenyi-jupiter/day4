using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        public class customer
        {
            public customer(int id)
            {
                CID = id;
            }
            public int CID { get; private set; }
            public string Name { get; set; }
            public string City { get; set; }

            public override string ToString()
            {
                return Name + "\t" + City;
            }


        }
        static void vartest()
        {
            var i = 43;
            var s = "this is just a test";
            var numbers = new[] { 4, 6, 9 };
            var complex = new SortedDictionary<string, List<DateTime>>();
            var x = new[] { 1, 2, 3 };

            
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("customers:\n");
            foreach(var c in createc())
            {
                Console.WriteLine(c);
            }
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
