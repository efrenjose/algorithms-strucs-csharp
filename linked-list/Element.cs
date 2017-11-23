using System;
namespace linkedlist
{
    public class Element
    {

        public int val;
        public Element next;
        public Element prev;

        public Element(int value)
        {
            val = value;
            next = null;
            prev = null;
        }
    }
}
