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

        public TrueValueTree(T value)
        {
            if (value == null) 
            {
                throw new ArgumentNullException("The value couldn't be null");
            }
            else
            {
                this.root = new TrueValueNode<T>(value);
            }
        }
        public TrueValueTree(T value, params TrueValueTree<T>[] children)
            :this(value)
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
        }

    }
}
