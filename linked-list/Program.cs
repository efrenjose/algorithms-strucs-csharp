using System;

namespace linkedlist
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            var linkedList = new LinkedList();


            for (int i = 0; i < 9; i++)
            {
                var el = new Element(i + 1);
                linkedList.Add(el);
            }
        }
    }
}
