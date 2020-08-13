using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    static class CollectionOperations
    {
        static void ListOperations(ref List<string> list)
        {
            ///validation check
            if (list == null)
            {
                return;
            }
            if (list.Count == 0)
            {
                Console.WriteLine("The list is empty");
                return;
            }
            /// getting midle index to remove from list
            int listIndex = list.Count();
            int middleIndex = (listIndex % 2 == 0) ?  listIndex /2 :  listIndex / 2 + 1;
            list.RemoveAt(middleIndex);

            ///if contains aram and index is odd it reverts list order
            if (list.Contains("mamas"))
            {
                list.Add("6");
            }
            if (list.Contains("aram"))
            {
                if (list.IndexOf("aram") %2 != 0)
                {
                    list.Reverse();
                }
            }
            
            /// adds str[2,3,4] if list has 3 or more uniq items
            if (list.Count >= 3)
            {
                List<string> uniqItemsList = new List<string>();
                foreach (var item in list)
                {
                    if (!uniqItemsList.Contains(item))
                    {
                        uniqItemsList.Add(item);
                    }
                }
                if (uniqItemsList.Count >= 3)
                {
                    List<string> str = new List<string>(new string[] { "2", "3", "4" });
                    list.InsertRange(2, str);
                }
            }
                        
        }
        
        static void DictionaryOperations(ref IDictionary<string,int> dict)
        {
            if(dict == null)
            {
                return;
            }
            if (dict.Count == 0)
            {
                return;
            }
            int scubaValue = default;
            if (dict.TryGetValue("scuba", out scubaValue))
            {
                if(scubaValue == 6)
                {
                    dict.Add("Empire", 6);
                }
            }
        }

        static void StackOperations(ref Stack<DateTime> dateStack)
        {
            if (dateStack == null)
            {
                return;
            }
            if (dateStack.Count == 0)
            {
                return;
            }
            DateTime todaysSate = DateTime.Today;
            int compare = DateTime.Compare(dateStack.Peek(), todaysSate);
            if (compare < 0)
            {
                dateStack.Pop();
                dateStack.Push(todaysSate);
            }
        }
    }
}
