using System;

namespace linkedlist
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            var linkedList = new LinkedList();

            for (int i = 4; i <= 16; i+=4)
            {
                var el = new Element(i);
                linkedList.Add(el);
            }

            var elSearched = linkedList.SearchElementAt(100);
        }
    }
}
