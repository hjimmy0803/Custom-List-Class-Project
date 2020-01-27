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
            set {
                count = value;
            }
            
        }
        public int Capacity 
        {
            get 
            {
                return capacity;
            }
            set 
            {
                capacity = value;
            }
            
            
        }

        //Indexer
        public T[] this[int i] 
        {

            get { return items; }
            set { items = value; }
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

            items[count] = itemToAdd;
            count++;
            T[] temp = new T[capacity * 2];

            if (count >= capacity) 
            {

                items = temp;
            }






            //if ([] = 0; items.Count; i++){ }
            // should add a value to our list (to the end)
        }
    }
}
