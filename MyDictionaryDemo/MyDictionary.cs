using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] keys;
        Tvalue[] items;

        public MyDictionary()
        {
            keys = new Tkey[0];
            items = new Tvalue[0];
        }

        public void Add(Tkey key,Tvalue item)
        {
            Tkey[] tempKey = keys;
            Tvalue[] tempValue = items;

            keys = new Tkey[keys.Length + 1];
            items = new Tvalue[items.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i]; //we equated the reference values
            }

            for (int i = 0; i < tempValue.Length; i++)
            {
                items[i] = tempValue[i];
            }

            keys[keys.Length - 1] = key;
            items[items.Length - 1] = item; //we added the last item
        }

        public int Count
        {
            get { return keys.Length; }
        }

        public Tkey[] Keys
        {
            get { return keys; }
        }

        public Tvalue[] Values
        {
            get { return items; }
        }
    }
}
