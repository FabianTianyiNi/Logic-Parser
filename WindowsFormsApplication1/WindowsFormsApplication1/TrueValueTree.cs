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
    }
}
