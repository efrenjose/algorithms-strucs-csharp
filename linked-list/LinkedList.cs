using System;
namespace linkedlist
{
    public class LinkedList
    {

        int _length;
        Element _headValue;
        Element _topValue;

        public int Length
        {
            get { return _length; }
        }

        public Element Add(Element element)
        {
            var el = element;
            var currentEl = this._headValue;

            //Empty list
            if (this._headValue == null)
            {
                this._headValue = el;
                this._topValue = el;

                this._length += 1;

                return el;
            }

            //Non-empty list
            currentEl = this._topValue;
            el.prev = currentEl;
            currentEl.next = el;
            this._topValue = currentEl.next;

            //Increase length
            this._length += 1;

            return el;
        }

        public Element SearchElementAt(int position) {
            var currentEl = this._headValue;
            var length = this._length;
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

        public void RemoveAt(int position) {
            var currentEl = this._headValue;
            var length = this._length;
            var count = 1;
            var message = "Failure: non-existent node in this list.";
            Element beforeNodeToDelete = null;
            Element nodeToDelete = null;
            Element deletedNode = null;

            if (position < 0 || position > length) {
                throw new Exception(message);
            }

            if (position == 1) {
                this._headValue = currentEl.next;
                this._topValue = currentEl.next;
                deletedNode = currentEl;
                currentEl = null;
                this._length--;
                return;
            }

            while (count < position)
            {
                beforeNodeToDelete = currentEl;
                nodeToDelete = currentEl.next;
                currentEl = currentEl.next;
                count++;
            }

            beforeNodeToDelete.next = nodeToDelete.next;
            this._topValue = nodeToDelete.next;
            deletedNode = nodeToDelete;
            nodeToDelete = null;
            this._length--;
        }

        //For stack pop
        public void Remove() {

            Element beforeNodeToDelete = null;
            Element nodeToDelete = null;

            if (this._length < 1) {
                throw new Exception("List is empty");
            }

            beforeNodeToDelete = this._topValue.prev;
            beforeNodeToDelete.next = null;
            //nodeToDelete = this._topValue;
            //nodeToDelete = null;
            this._topValue = beforeNodeToDelete;

            this._length--;
        }
    }
}
