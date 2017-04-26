using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicParser
{
    class TrueValueNode<T>
    {
        private T value;
        private bool hasParent;
        private List<TrueValueNode<T>> children;
        private TrueValueNode<T> parentNode;
        public int childrenNumber;
        public int nodepointer;
        private bool visited;

        public bool Visited
        {
            set
            { this.visited = value; }
            get
            { return this.visited; }
        }
        public List<TrueValueNode<T>> getchildren()
        {
            return this.children;
        }
        public TrueValueNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("The value couldn't be null");
            }
            else
            {
                this.value = value;
                this.children = new List<TrueValueNode<T>>();
            }
        }
        
        public bool hasChild()
        {
            if (children == null || !children.Any()) return false;
            else return true;
        }
        public void addChild(TrueValueNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("You cannot insert null object");
            }
            if (child.hasParent)
            {
                throw new ArgumentException("The node has already had a parent!");
            }
            child.hasParent = true;
            this.children.Add(child);

        }

        public void traverseChildNode(TrueValueNode<T> fatherNode)
        {
            if (fatherNode.hasChild())
            {
                
            }
            else
            {

            }
        }

        public void setParentNode(TrueValueNode<T> fatherNode)
        {
            this.parentNode = fatherNode;
        }

        public TrueValueNode<T> getParentNode()
        {
            return this.parentNode;
        }
        public T getValue()
        {
            return this.value;
        }

        
    }
}
