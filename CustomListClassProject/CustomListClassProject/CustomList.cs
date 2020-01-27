using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class CustomList<T>
    {
        // member variables (Has A)
        T[] items;
        private int count;
        private int capacity;

        public int Count 
        {
            //get and/ or set count
            get 
            {
                return count;
            }
            
        }
        public int Capacity 
        {
            get 
            {
                return capacity;
            }
        }

        //constructor (SPAWNER)
        public CustomList() 
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        //member methods (CAN DO)
        public void Add(T itemToAdd) 
        {
            items[0] = itemToAdd;
            // should add a value to our list (to the end)
        }
    }
}
