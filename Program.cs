using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine(a%2);
        }
    }

    static class CollectionOperations
    {
        static void ListOperations(ref List<string> list)
        {
            ///validation check
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("The list is empty");
                return;
            }
            /// getting midle index to remove from list
            int listIndex = list.Count();
            int middleIndex = (listIndex % 2 == 0) ?  listIndex /2 :  listIndex / 2 + 1;
            list.RemoveAt(middleIndex);

            if (list.Contains("mamas"))
            {
                list.Add("6");
            }

            

        }
    }
}
