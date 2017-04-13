using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class FormulaParser
    {
        Stack<Object> m_tokens = new Stack<object>();
        public Stack<Object> Tokens { get { return m_tokens; } }
        private string _Expression;
        public string expression
        {
            get
            {
                if (_Expression == null)
                {
                    foreach (var item in Tokens)
                    {
                        if (item is Operator)
                            _Expression += (((Operator)item).Value + ",");
                        if (item is Operand)
                            _Expression += (((Operand)item).Value + ",");
                    }
                }
                return _Expression;
            }
        }

        /// <summary>
        /// To find the position index of the input operator in the formula
        /// </summary>
        /// <param name="exp"></param>
        /// <param name="targetOperator"></param>
        /// <returns></returns>
        public int findOperator(string exp, string targetOperator)
        {
            return -1;
        }

        public bool comparePriority(int operator1, int operator2)
        {

            return false;
        }


        /// <summary>
        /// Convert the input formula into Rverse Poland Formula
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public bool Parse(string exp)
        {
            m_tokens.Clear();
            if (exp.Trim() == "") return false;
            else if (!this.isMatching(exp)) return false;
            Stack<Object> operands = new Stack<Object>();
            Stack<Operator> operators = new Stack<Operator>();

            Operator.OperatorType curType = Operator.OperatorType.ERR;
            string curOperand = "";
            string curOperator = "";
            int curPosition = 0;

            while (true)
            {
                curPosition = findOperator(exp, "");
                curOperand = exp.Substring(0, curPosition); //Record C# Substring(int startindex, int length)
                curOperator = exp.Substring(curPosition, 1);

                if (curOperand != "") //if the 
                {
                    operands.Push(new Operand(curOperand, curOperand));
                }
                if (curOperator == ".")
                {
                    break;
                }
                //if face the left branket,push the symbol into its stack and shorten the original formula
                if (curOperator == "(")
                {
                    operators.Push(new Operator(curOperator, curOperator));
                    exp = exp.Substring(curPosition +1).Trim();
                    continue;
                }
                if (curOperator == ")")
                {
                    while (operators.Count() > 0)
                    {
                        if (operators.Peek().Type != Operator.OperatorType.LB) operands.Push(operators.Pop());
                        else
                        {
                            operators.Pop();
                            break;
                        }
                    }
                    exp = exp.Substring(curPosition + 1).Trim();
                    continue;
                }
                //priority comparison
                if()


            }


        }
    }
}
