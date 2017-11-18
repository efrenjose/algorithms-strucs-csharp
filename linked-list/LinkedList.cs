using System;
namespace linkedlist
{
    public class LinkedList
    {

        int lenght;
        Element headValue;

        public Element Add(Element element)
        {
            var el = element;
            var currentEl = headValue;

            //Empty list
            if (headValue == null)
            {
                this.headValue = el;
                this.lenght += 1;

                return el;
            }

            //Non-empty list
            while (currentEl.next != null)
            {
                currentEl = currentEl.next;
            }

            currentEl.next = el;

            this.lenght += 1;

            return el;
        }
    }
}
