using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    public static class extensions
    {
        public static bool comapre(this customer c1, customer c2)
        {
            if(c1.CID==c2.CID && c1.Name==c2.Name && c1.City == c2.City)
            {
                return true;
            }
            return false;
        }
        public static List<T> Append<T>(this List<T> a, List<T> b)
        {
            var newList = new List<T>(a);
            newList.AddRange(b);
            return newList;
        }

    }
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
}
