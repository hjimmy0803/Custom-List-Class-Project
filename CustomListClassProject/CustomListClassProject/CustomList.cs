using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomListClassProject
{
    public class CustomList<T> : IEnumerable
    {
        // member variables (Has A)
        T[] items;
        public int count;
        public int capacity;

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
        public T this[int i] 
        {

            get { return items[i]; }
            set { items[i] = value; }
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
            

            if (count >= capacity) 
            {
                T[] temp = new T[capacity * 2];
                for (int i = 0; i < items.Length; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;
                capacity = capacity * 2;
            }
        }
        public void Remove(T itemToRemove)
        {

            T[] temp = new T[capacity];
            bool itemHasBeenRemoved = false;

            for (int i = 0; i < items.Length; i++)
            {
                temp[i] = items[i];
                if (itemToRemove.Equals(items[i])) 
                {

                    count--;
                }
                if (itemHasBeenRemoved == true)
                {

                    temp[i] = items[i + 1];
                }
                else
                {

                    temp[i] = items[i];
                }
             
            }

            items = temp;
        }
        public static CustomList<T> Zip(CustomList<T> left, CustomList<T> right)
        {

            CustomList<T> items = new CustomList<T>();
            for (int i = 0; i < left.count; i++)
            {
                items.Add(left[i]);
                items.Add(right[i]);
            }
            return items;

        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++) 
            {

                yield return  items[1];

            }
            yield return "Finished";
        }



        
    }
}
