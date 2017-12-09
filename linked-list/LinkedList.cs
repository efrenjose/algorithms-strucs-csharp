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

        public Element HeadValue
        {
            get { return _headValue; }
        }

        public Element TopValue
        {
            get { return _topValue; }
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

            if (this._length < 1)
                throw new Exception("List is empty");

            beforeNodeToDelete = this._topValue.prev;
            beforeNodeToDelete.next = null;
            this._topValue = beforeNodeToDelete;

            this._length--;
        }

        //For queue dequeue
        public void RemoveHead() {

            Element nodeToDelete = null;
            Element newHead = null;

            if (this._length < 1)
                throw new Exception("List is empty");

            newHead = this._headValue.next;
            nodeToDelete = this._headValue;
            nodeToDelete = null;
            this._headValue = newHead;

            this._length--;
        }

        public static Element GetNthToLast(LinkedList linkedList, int position)
        {
            var currentEl = linkedList.TopValue.prev;
            var count = 1;

            while (count < position)
            {
                currentEl = currentEl.prev;
                count++;
            }

            return currentEl;
        }

        public static Element GetNth(LinkedList linkedList, int position)
        {
            var currentEl = linkedList.HeadValue;
            var count = 1;

            //Count the elements in the list
            while (currentEl.next != null)
            {
                currentEl = currentEl.next;
                count++;
            }

            if (count == 0 || position < 1 || position > count)
            {
                throw new Exception("error");
            }

            currentEl = linkedList.HeadValue;
            for (int i = 1; i < position; i++)
            {
                currentEl = currentEl.next;
            }

            return currentEl;
        }

        public static Element GetNthToLastUsingHeadOnly(LinkedList linkedList, int position)
        {

            var currentEl = linkedList.HeadValue;
            var count = 1;

            //Count the elements in the list
            while (currentEl.next != null)
            {
                currentEl = currentEl.next;
                count++;
            }

            //Check the the position is not grater that the elements in the array
            if (position > count - 1)
            {
                throw new Exception("position is grater than the elements in the list");
            }

            //set currenEl to head and do the search
            currentEl = linkedList.HeadValue;
            for (int i = 1;  i < count - position; i++)
            {
                currentEl = currentEl.next;
            }

            return currentEl;
        }
    }
}
