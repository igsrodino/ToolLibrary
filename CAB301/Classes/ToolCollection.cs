using System;
using System.Linq;

namespace Assignment
{
    public class ToolCollection : iToolCollection
    {
        Tool[] collection;
        
        private int count = 0;

        public ToolCollection()
        {
            collection = new Tool[1000000];
        }

        public int Number => count;

        public void add(Tool aTool)
        {
            collection[Number] = aTool;
            count++;
        }

        public void delete(Tool aTool)
        {
            int index = Array.IndexOf(collection, aTool);

            if (index > -1) {

                for (; index < Number; index++)
                {
                    collection[index] = collection[index + 1];
                }
                count--;
            }
            Console.WriteLine("Tool deleted.");
        }

        public bool search(Tool aTool)
        {
            return Array.IndexOf(collection, aTool) > -1;
        }

        public Tool[] toArray()
        {
            return collection.Where(x => x != null).ToArray();
        }
    }
}
