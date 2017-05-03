using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LogicParser
{
    class FormulaParser
    {
        List<Object> m_tokens = new List<Object>();
        List<object> tmpList = new List<object>();
        //public Stack<Object> Tokens { get { return m_tokens; } }
        private Operand result;
        public bool isCorrect;
        public TrueValueTree<object> logicTree;
        private int pointer = 0;
        Stack<object> tmpStack;
        Queue<object> tmpqueueForOperand = new Queue<object>();
        Stack<object> operands = new Stack<object>();
        Stack<Operator> operators = new Stack<Operator>();
        TrueValueNode<object> curNode;
        TrueValueNode<object> tmpNode;

        //public string expression
        //{
        //    get
        //    {
        //        if (_Expression == null)
        //        {
        //            foreach (var item in Tokens)
        //            {
        //                if (item is Operator)
        //                    _Expression += (((Operator)item).Value + ",");
        //                if (item is Operand)
        //                    _Expression += (((Operand)item).Value + ",");
        //            }
        //        }
        //        return _Expression;
        //    }
        //}
        List<string> m_Operators = new List<string>(new string[]{
            "(","∧",")","∨","⇒","¬","."});
        /// <summary>
        /// To find the position index of the input operator in the formula
        /// </summary>
        /// <param name="exp"></param>
        /// <param name="targetOperator"></param>
        /// <returns></returns>
        public int findOperator(string exp, string findOpt)
        {
            string opt = "";
            for (int i = 0; i < exp.Length; i++)
            {
                string chr = exp.Substring(i, 1);
                if (opt == "")
                {
                    if (findOpt != "")
                    {
                        if (findOpt == chr)
                        {
                            return i;
                        }
                    }
                    else
                    {
                        if (m_Operators.Exists(x => x.Contains(chr)))
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }
        /// <summary>
        /// Used to compare the priority of two operators
        /// </summary>
        /// <param name="operator1"></param>
        /// <param name="operator2"></param>
        /// <returns>three values: 0 same priority, 1 operator1 > operator2, -1 operator1 < operator2 </returns>
        public int comparePriority(Operator.OperatorType operator1, Operator.OperatorType operator2)
        {
            if (operator1 == operator2) return 0;
            if (operator1 > operator2) return 1;
            else return -1;
        }

        /// <summary>
        /// to justify if two reversed brackets exist
        /// </summary>
        /// <param name="exp">input a string</param>
        /// <returns>return faults</returns>
        public string isMatching(string exp)
        {
            Stack<string> bracketMatcher = new Stack<string>();
            //int count = 0; //record how many pairs of brackets
            for (int i = 0; i < exp.Length; i++)
            {
                string chr = exp.Substring(i, 1);
                if (chr == "(")
                {
                    bracketMatcher.Push(chr);
                    //count++;
                }
                if (chr == ")")
                {
                    if (bracketMatcher.Peek() == "(")
                    {
                        bracketMatcher.Pop();
                        isCorrect = true;
                    }

                    else
                    {
                        isCorrect = false;
                        return "SYNTAX ERROR! lack of bracket pairs";
                    }
                        
                }
                if (i == exp.Length - 1)
                {
                    if (bracketMatcher.Count > 0)
                    {
                        isCorrect = false;
                        return "SYNTAX ERROR! Lack of right brackets";
                    }                       
                }
                
            }
            return "";
        }

       

        /// <summary>
        /// Convert the input formula into Rverse Poland Formula
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public void Parse(string exp)
        {
            string matchMessage = isMatching(exp);
            //if (matchMessage != "");
            m_tokens.Clear();
            if (exp.Trim() == "") return;
            //else if (!this.isMatching(exp)) return false;
            

            string curOperand = "";
            string curOperator = "";
            int curPosition = findOperator(exp, "");
            Operator.OperatorType curType = Operator.OperatorType.ERR;

            exp += "."; //define a terminal symbol
            while (true)
            {
                curPosition = findOperator(exp, "");
                if (curPosition == 0) curPosition += 1;
                curOperand = exp.Substring(0, curPosition); //Record C# Substring(int startindex, int length)
                
                curOperator = exp.Substring(curPosition, 1);
                curType = Operator.convertOperator(curOperator);

                if (curOperator == "(")
                {
                    operators.Push(new Operator(curOperator, curOperator));
                    exp = exp.Substring(curPosition + 1).Trim();
                    continue;
                }
                if (curOperand != "") 
                {
                    operands.Push(new Operand(curOperand, curOperand));
                }
                //if (curOperator == "⇒")
                //{
                //    operators.Push(new Operator(curOperator, curOperator));
                //}
                if (curOperator == ".")
                {
                    break;
                }
                //if face the left branket,push the symbol into its stack and shorten the original formula
                
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
                //if opeators stack has symbols, it needs to do the priority comparison,
                //otherwise just add the current operator into operators stack
                if (operators.Count > 0)
                {
                    //Other situdation for inserting operators
                    //if the priority of the current type is greater than the stack peek one
                    if (operators.Peek().Type == Operator.OperatorType.LB)
                    {
                        operators.Push(new Operator(curType, curOperator));
                        exp = exp.Substring(curPosition + 1).Trim();
                    }
                    else
                    {
                        if (operators.Count > 0)
                        {
                            if (comparePriority(curType, operators.Peek().Type) == 1)
                            {
                                operands.Push(new Operator(curType, curOperator));
                            }
                            else
                            {
                                operands.Push(operators.Pop());
                                operators.Push(new Operator(curType, curOperator));
                            }
                        }
                         
                        // when the priority of the current type is smaller than the stack peek one 
                        //push out the peek into the operand stack and put the current type into the operators stack
                        else
                        {
                            operands.Push(operators.Pop());
                            operators.Push(new Operator(curType, curOperator));
                            //continue to justify the priority of the operators stack
                            while (operators.Count > 1)
                            {
                                if (comparePriority(curType, operators.Peek().Type) == 1)
                                {
                                    operands.Push(new Operator(curType, curOperator));
                                    continue;
                                }
                                else
                                {
                                    operands.Push(operators.Pop());
                                    continue;
                                }
                            }
                            while (operators.Count == 0)
                            {
                                operands.Push(curType);
                                break;
                            }
                        }
                    }
                    exp = exp.Substring(curPosition + 1);
                 }

                else
                {
                    operators.Push(new Operator(curType,curOperator));
                    exp = exp.Substring(curPosition + 1);
                }
                
                //exp = exp.Substring(curPosition + 1);
            }
            //clear all the operators left in the operators stack
            while (operators.Count > 0)
            {
                operands.Push(operators.Pop());
            }
            //printf all the sysbols in he operands
            while (operands.Count > 0)
            {
                m_tokens.Add(operands.Pop());
            }

            pointer = m_tokens.Count - 1;

            for (int i = m_tokens.Count - 1; i >= 0; i--)
            {
                operands.Push(m_tokens[i]);
            }
        }

        public void initialize()
        {
            if (m_tokens != null)
            {
                for (int i = 0; i< m_tokens.Count; i++)
                {
                    if (m_tokens[i] is Operand)
                    {
                        ((Operand)m_tokens[i]).boolValue = Operand.OperandValue.T;
                    }
                }
            }
            tmpList = cloneList(m_tokens);
            logicTree = new TrueValueTree<object>(tmpList);
            logicTree.Root = new TrueValueNode<object>(tmpList);
            curNode = logicTree.Root;
            List<TrueValueNode<object>> tmp_list = new List<TrueValueNode<object>>();
            tmp_list.Add(curNode);
            treeCounter(pointer, tmp_list);
        }

        public static T clone<T>(T RealObject)
        {
            using (Stream objectStream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objectStream, RealObject);
                objectStream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(objectStream);
            }
        }

        public List<object> cloneList(List<object> list)
        {
            List<object> newList = new List<object>();
            foreach (object item in list)
            {
                newList.Add(clone<object>(item));
            }
            return newList;
        }

        public TrueValueTree<object> treeCounter(int pointer, List<TrueValueNode<object>> inputlist)
        {
            List<object> copylist1;
            List<object> copylist2;
            foreach (TrueValueNode<object> item in inputlist)
            {
                curNode = item;
                update(curNode);
                copylist1 = cloneList(((List<object>)(item.getValue())));
                for (int i = pointer; i >= 0; i--)
                {
                    if (copylist1[i] is Operand)
                    {
                        if (((Operand)copylist1[i]).boolValue == Operand.OperandValue.F)
                        {
                            continue;
                        }
                        else
                        {
                            ((Operand)copylist1[i]).boolValue = Operand.OperandValue.F;

                            //list.Add(clone<List<object>>(copylist));
                            copylist2 = cloneList(copylist1);
                            tmpNode = new TrueValueNode<object>(copylist2);
                            
                            curNode.addChild(tmpNode);
                            if (checkIfRunOut(copylist1))
                            {
                                //inputlist[i] = Operand.OperandValue.T;
                                pointer--;
                                treeCounter(pointer, curNode.getchildren());
                                break;
                            }
                            ((Operand)copylist1[i]).boolValue = Operand.OperandValue.T;

                            //go back to find father node
                            //if (checkIfRunOut(m_tokens))
                            //{
                            //    curNode = curNode.getParentNode();
                            //    while (curNode.childrenNumber == 1)// if the node only has one child node
                            //    {
                            //        curNode = curNode.getParentNode();
                            //    }
                            //    m_tokens = clone<List<object>>((List<object>)((List<object>)curNode.getValue())[0]);
                            //    pointer = curNode.nodepointer;
                            //    pointer--;
                            //    break;
                            //}
                            //pointer--;
                            //treeCounter();
                        }
                    }
                }
            }


            return logicTree;
        }

        
        
        public int reverseSequenceTValue(List<object> list)  
        {
            int count = 0;
            for (int i = list.Count-1; i > 0; i--)
            {
                if ((list[i] is Operand))
                {
                    if (((Operand)list[i]).boolValue != Operand.OperandValue.F) count++;
                    else continue;
                }
                else continue;
               
            }   
            return count;
        }

        public bool checkIfRunOut(List<object> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Operand)
                {
                    if (((Operand)list[i]).boolValue == Operand.OperandValue.F) return true;
                    else return false;
                } 
            }
            return false;
        }
        public void update(TrueValueNode<object> node) //List<object> list
        {
            List<object> calList = (List<object>)node.getValue();
            tmpStack = new Stack<object>();
            //pointer = m_tokens.Count - 1; 
            int count = 0; // to calculate how many operands in  the formula.
            if (calList == null || calList.Count == 0) throw new ArgumentNullException("Cannot update null list into tree");
            TrueValueNode<object> tmpnode = new TrueValueNode<object>(calList);
            for (int i = pointer; i >= 0; i--)
            {
                
                if (calList[i] is Operator) 
                {
                    if (i != 0)
                    {
                        tmpqueueForOperand.Enqueue(calList[i]);
                    }
                    else
                    {
                        tmpqueueForOperand.Enqueue(calList[i]);
                        //evaluate(tmpqueueForOperand, tmpStack);
                        if (containsAnswer())
                        {
                            operands.Pop();
                            node.answer = evaluate(tmpqueueForOperand, tmpStack);
                            
                        }
                        else
                        {
                            node.answer = evaluate(tmpqueueForOperand, tmpStack);
                        }
                    }
                }
                    
                else tmpqueueForOperand.Enqueue(calList[i]);
            }

            //m_tokens.RemoveAt(m_tokens.Count - 1);
            //logicTree.Root.addChild(new TrueValueNode<object>(m_tokens));

            tmpqueueForOperand.Clear();
        }

        public string evaluate(Queue<object> queue, Stack<object> stack)
        {
            string answer = "";//"T" by default
            if (queue == null) throw new ArgumentNullException();
            while (queue.Count != 0)
            {
                stack.Push(queue.Dequeue()); //to avoid stack.Peek() return ArgumentNullError
                while (stack.Peek() is Operand)
                {
                    stack.Push(queue.Dequeue());
                }
                Operator tmpOperator = (Operator)stack.Pop();
                Operand operandB = (Operand)stack.Pop();
                Operand operandA = (Operand)stack.Pop();

                switch (tmpOperator.Type)
                {
                    #region and "∧"
                    case Operator.OperatorType.AND:
                        stack.Push(new Operand(Operator.and(operandA.boolValue, operandB.boolValue)));
                        answer = Operator.and(operandA.boolValue, operandB.boolValue).boolValue.ToString();
                        break;
                    #endregion
                    #region or
                    case Operator.OperatorType.OR:
                        stack.Push(new Operand(Operator.or(operandA.boolValue, operandB.boolValue)));
                        answer = Operator.or(operandA.boolValue, operandB.boolValue).boolValue.ToString();
                        break;
                    #endregion
                    #region imply
                    case Operator.OperatorType.ENT:
                        stack.Push(new Operand(Operator.imply(operandA.boolValue, operandB.boolValue)));
                        answer = Operator.imply(operandA.boolValue, operandB.boolValue).boolValue.ToString();
                        break;
                        #endregion

                }
            }
            return answer;
        }
        public bool containsAnswer()
        {
            if (operands.Peek() is Operand.OperandType) return true;
            else return false;
        }
    }

        
    }

