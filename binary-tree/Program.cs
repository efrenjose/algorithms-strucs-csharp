using System;

namespace binarytree
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.PrintInOrder();
        }
    }

    public class Node {
        int _key;
        Node _left, _right;

        public Node(int item) {
            _key = item;
            _left = null;
            _right = null;
        }

        public Node Left
        {
            get { return _left;  }
            set { _left = value; }
        }

        public Node Right
        {
            get { return _right; }
            set { _right = value; }
        }

        public int Key
        {
            get { return _key; }
            set { _key = value; }
        }
    }

    public class BinaryTree {

        Node _root;

        public BinaryTree()
        {
            _root = null;
        }

        public Node Root
        {
            get { return _root; }
            set { _root = value; }
        }

        public void PrintPreOrder(Node node)
        {
            if (node == null) return;

            Console.WriteLine(node.Key + " ");
            PrintInOrder(node.Left);
            PrintInOrder(node.Right);
        }

        public void PrintInOrder(Node node)
        {
            if (node == null) return;

            PrintInOrder(node.Left);
            Console.WriteLine(node.Key + " ");
            PrintInOrder(node.Right);
        }

        public void PrintPostOrder(Node node)
        {
            if (node == null) return;

            PrintInOrder(node.Left);
            PrintInOrder(node.Right);
            Console.WriteLine(node.Key + " ");
        }

        public void PrintPreOrder()
        {
            PrintPreOrder(_root);
        }

        public void PrintInOrder()
        {
            PrintInOrder(_root);
        }

        public void PrintPostOrder()
        {
            PrintPostOrder(_root);
        }
    }
}
