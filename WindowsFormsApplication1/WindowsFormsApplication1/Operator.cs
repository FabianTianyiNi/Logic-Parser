using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Operator
    {
        public enum OperatorType
        {
            /// <summary>
            /// Left Blanket
            /// </summary>
            LB = 10,
            /// <summary>
            /// Right Blanket
            /// </summary>
            RB = 11,
            /// <summary>
            /// Not
            /// </summary>
            NOT = 12,
            /// <summary>
            /// Entailment
            /// </summary>
            EN = 13,
            /// <summary>
            /// And
            /// </summary>
            AND = 14,
            /// <summary>
            /// Or
            /// </summary>
            NOT = 15,
            ERR = 16


        }
        public OperatorType Type { get; set; }
        public string Value { get; set; }
        public Operator(OperatorType type, string value)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Define new operator and return their operator type respectively
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public OperatorType ConvertOperator(string type)
        {
            switch (type)
            {
                case "&&": return OperatorType.AND;
                case "||": return OperatorType.OR;
                case "!": return OperatorType.NOT;
                case "=>": return OperatorType.EN;
                case "(": return OperatorType.LB;
                case ")": return OperatorType.RB;
                default: return OperatorType.AND;
            }
        }

        public int bool comparePriority(OperatorType typeA, OperatorType typeB)
        {

        }
    }
}
