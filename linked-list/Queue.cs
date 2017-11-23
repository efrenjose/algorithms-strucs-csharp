using System;
namespace linkedlist
{
    public class Queue
    {
        private LinkedList _linkedList;

        public Queue()
        {
            _linkedList = new LinkedList();
        }

        public void Enqueue(Element el)
        {
            _linkedList.Add(el);
        }

        public void Dequeue()
        {
            _linkedList.RemoveHead();
        }
    }
}
