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
            var currentEl = this.headValue;

            //Empty list
            if (this.headValue == null)
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

        public Element SearchElementAt(int position) {
            var currentEl = this.headValue;
            var length = this.lenght;
            var count = 1;
            var message = "Failure: non-existent node in this list";

            if (length == 0 || position < 1 || position > length)
            {
                throw new Exception(message);
            }

            while (count < position) {
                currentEl = currentEl.next;
                count += 1;
            }

            return currentEl;
        }


    }
}
