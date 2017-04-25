using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicParser
{
    [Serializable]
    class Operator
    {
        
        public enum OperatorType
        {
            NOT = 16,
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
            ERR = 10,
            END = 09
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
        public static Operand tmpResult = new Operand(Operand.OperandType.TMP,"TMP");

        /// <summary>
        /// Define new operator and return their operator type respectively
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static OperatorType convertOperator(string type)
        {
            switch (type)
            {
                case "∧": return OperatorType.AND;
                case "∨": return OperatorType.OR;
                case "⇒": return OperatorType.ENT;
                case "(": return OperatorType.LB;
                case ")": return OperatorType.RB;
                case "¬": return OperatorType.NOT;
                case ".": return OperatorType.END;
                default: return OperatorType.END;
            }
        }

        public static Operand and(Operand.OperandValue OperandA, Operand.OperandValue OperandB)
        {
            
            if (OperandA == Operand.OperandValue.T)
            {
                tmpResult.boolValue = OperandB == Operand.OperandValue.T ?  Operand.OperandValue.T : Operand.OperandValue.F;
            }
            if (OperandA == Operand.OperandValue.F)
            {
                tmpResult.boolValue = OperandB == Operand.OperandValue.T ? Operand.OperandValue.T : Operand.OperandValue.F;
            }
            return tmpResult;
        }

        public static Operand or(Operand.OperandValue OperandA, Operand.OperandValue OperandB)
        {
            if (OperandA == Operand.OperandValue.T) tmpResult.boolValue = Operand.OperandValue.T;
            if (OperandA == Operand.OperandValue.F) tmpResult.boolValue = OperandB == Operand.OperandValue.F ? Operand.OperandValue.F : Operand.OperandValue.T;
            return tmpResult;
        }

        public static Operand imply(Operand.OperandValue OperandA, Operand.OperandValue OperandB)
        {
            if (OperandA == Operand.OperandValue.T && OperandB == Operand.OperandValue.F) tmpResult.boolValue = Operand.OperandValue.F;
            else tmpResult.boolValue = Operand.OperandValue.T;
            return tmpResult;
        }

        
    }
}
