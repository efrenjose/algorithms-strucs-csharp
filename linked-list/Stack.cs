using System;
namespace linkedlist
{
    public class Stack
    {

        private LinkedList _linkedList;

        public Stack()
        {
            _linkedList = new LinkedList();
        }

        public void Push(Element el) {
            _linkedList.Add(el);
        }

        public void Pop() {
            if (_linkedList.Length > 0)
            {
                _linkedList.RemoveAt(_linkedList.Length);
                return;
            }
            throw new Exception("The stack is empty");
        }
    }
}
