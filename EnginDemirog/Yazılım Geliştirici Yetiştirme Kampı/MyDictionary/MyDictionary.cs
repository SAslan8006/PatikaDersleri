using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<T,V>
    {
        KeyValuePair<T,V>[] items;
        KeyValuePair<T, V>[] tempItems;
        public MyDictionary()
        {
            items= new KeyValuePair<T, V>[0];
        }
        public void Add(T key,V value)
        {
            tempItems = items;
            items =new KeyValuePair<T, V>[tempItems.Length+1];
            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }
            items[items.Length - 1] = new KeyValuePair<T, V>(key, value);
        }
        public void ShowList()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }

        public int Count
        {
            get { return items.Length; }
        }

    }
}
