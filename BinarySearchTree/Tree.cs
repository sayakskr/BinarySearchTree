using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class Tree
    {
        private Node _root;

        public Node Root 
        {
            get => _root;
            private set { }
        }

        public Node InsertNode(int value)
            => RecursiveInsert(_root, value);

        public Node InsertNodes(params int[] values)
        {
            foreach(int param in values)
                _root = RecursiveInsert(_root, param);

            return _root;
        }

        private Node RecursiveInsert(Node root, int value)
        {
            if (root == null)
                return new Node() { data = value };

            if (value > root.data)
                root.right = RecursiveInsert(root.right, value);
            if (value < root.data)
                root.left = RecursiveInsert(root.left, value);

            return root;
        }

        //public Node DeleteNode(int value)
        //{

        //}
    }
}
