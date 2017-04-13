using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicParser
{
    class Operator
    {
        public enum OperatorType
        {
            /// <summary>
            /// Left Blanket
            /// </summary>
            LB = 15,
            /// <summary>
            /// Right Blanket
            /// </summary>
            RB = 14,
            /// <summary>
            /// Not
            /// </summary>
            AND = 13,
            /// <summary>
            /// Entailment
            /// </summary>
            OR = 12,
            /// <summary>
            /// And
            /// </summary>
            ENT = 11,
            /// <summary>
            /// Or
            /// </summary>
            ERR = 10
        }
        public OperatorType Type { get; set; }
        public string Value { get; set; }
        public Operator(OperatorType type, string value)
        {
            this.Type = type;
            this.Value = value;
        }

        public Operator(string type, string value)
        {
            this.Type = convertOperator(type);
            this.Value = value;
        }

        /// <summary>
        /// Define new operator and return their operator type respectively
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public OperatorType convertOperator(string type)
        {
            switch (type)
            {
                case "&": return OperatorType.AND;
                case "|": return OperatorType.OR;
                case ">": return OperatorType.ENT;
                case "(": return OperatorType.LB;
                case ")": return OperatorType.RB;
                default: return OperatorType.AND;
            }
        }

        
    }
}
