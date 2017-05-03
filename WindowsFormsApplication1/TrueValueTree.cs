using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicParser
{
    class TrueValueTree<T>
    {
        private TrueValueNode<T> root;
        private TrueValueNode<T> node;
        List<TrueValueNode<T>> visitedNode;

        public TrueValueTree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("The value couldn't be null");
            }
            else
            {
                this.node = new TrueValueNode<T>(value);
            }
        }
        public TrueValueTree(TrueValueNode<T> root)
        {
            this.root = root;
        }
        public TrueValueTree(T value, params TrueValueTree<T>[] children)
            : this(value)
        {
            foreach (TrueValueTree<T> child in children)
            {
                this.root.addChild(child.root);
            }
        }
        public TrueValueNode<T> Root
        {
            get
            {
                return this.root;
            }
            set
            {
                this.root = value;
            }
        }

        public List<object> treeBFSTrace()
        {
            Queue<TrueValueNode<T>> tempqueue = new Queue<TrueValueNode<T>>();
            List<TrueValueNode<T>> children = new List<TrueValueNode<T>>();
            List<object> displayList = new List<object>();
            visitedNode = new List<TrueValueNode<T>>();
            tempqueue.Enqueue(root);
            root.Visited = true;
            while (tempqueue.Count > 0)
            {
                TrueValueNode<T> node = tempqueue.Dequeue();
                visitedNode.Add(node);
                displayList.Add(node);
                children = node.getchildren();
                foreach (TrueValueNode<T> item in children)
                {
                    tempqueue.Enqueue(item);
                    item.Visited = true;
                    displayList.Add(item);
                }
            }
            return displayList;
        }
        public bool checkIfExist(TrueValueNode<T> node)
        {
            foreach (TrueValueNode<T> item in visitedNode)
            {
                if (item == node) return true;
                else continue;
            }
            return false;
        }
        public bool isEmpty()
        {
            if (root == null) return true;
            return false;
        }

        

    }
}
