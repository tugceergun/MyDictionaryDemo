using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> costumer = new MyDictionary<int, string>();
            costumer.Add(2345, "Tuğçe");
            costumer.Add(6789, "Fatma");

            Console.WriteLine(costumer.Count);


            foreach (int item in costumer.Keys)
            {
                Console.WriteLine("Key:" +item);
                //we printed the keys with foreach.
            }

            for (int i = 0; i < costumer.Values.Length; i++)
            {
                Console.WriteLine("item " + (i + 1) + " :" + costumer.Values[i]);
                //we printed the values with for.
            }
        }
    }
}
