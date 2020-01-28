using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
     class program 
    {
        static void Main(string[] args)
        {
            CustomList<int> jimmyList = new CustomList<int>();

            jimmyList.Add(4);
            jimmyList.Add(6);
            jimmyList.Add(8);

            jimmyList.Remove(6); // { 4, 8 }


        }
    }
}
