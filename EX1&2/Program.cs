using System;
using System.Collections.Generic;

namespace Lab4
{
    public class customer
    {
        public customer(int id)
        {
            CID = id;
        }
        public int CID { get;private set; }
        public string Name { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return Name + "\t" + City;
        }


    }
    class Program
    {

        static void Main(string[] args)
        {
            //customer c = new customer(1) ;
            //c.Name = "Maria"; 
            //c.City = "Berlin";
            customer c= new customer(1) { Name = "Jack", City = "Washington" };
            //c.CID = 1;
            Console.WriteLine(c);
            List<point> square = new List<point>
            {
                new point{X=0,Y=5 },
                new point{X=5,Y=5}
            };

            //List<customer> c1 = createc();
            Console.WriteLine("customers:\n");
            foreach(customer c2 in createc())
            {
                Console.WriteLine(c2);
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
