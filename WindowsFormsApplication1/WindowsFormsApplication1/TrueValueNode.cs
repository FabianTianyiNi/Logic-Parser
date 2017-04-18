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
    }
}
