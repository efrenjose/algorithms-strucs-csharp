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

            //linkedList.RemoveAt(3);

            var stack = new Stack();
            //stack.Push(new Element(4));
            //stack.Push(new Element(8));
            //stack.Push(new Element(12));
            stack.Pop();

            //var elSearched = linkedList.SearchElementAt(2);


        }
    }
}
