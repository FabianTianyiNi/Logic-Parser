using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicParser
{
    class Operand
    {
        public enum OperandType
        {
            A = 0,
            B = 1,
            C = 2,
            D = 3,
            E = 4,
            F = 5,
            G = 6,
            H = 7,
            I = 8,
            J = 9,
            K = 10,
            L = 11,
            M = 12,
            N = 13,
            O = 14,
            P = 15,
            Q = 16,
            R = 17,
            S = 18,
            T = 19,
            U = 20,
            V = 21,
            W = 22,
            X = 23,
            Y = 24,
            Z = 25,
            ERR = 26
        }
        public enum OperandValue
        {
            T = 0,
            F = 1
        }
        public OperandType Type { get; set; }
        public string Value { get; set; }
        public OperandValue boolValue { get; set; }
        public string boolType { get; set; }
        public Operand(OperandType type, string value)
        {
            this.Type = type;
            this.Value = value;
        }
        public Operand(string type, string value)
        {
            this.Type = ConvertOperand(type);
            this.Value = value;
        }
        public Operand(string value)
        {
            this.Value = value;
        }

        public static OperandType ConvertOperand(string type)
        {
            switch (type)
            {
                case "A": return OperandType.A;
                case "B": return OperandType.B;
                case "C": return OperandType.C;
                case "D": return OperandType.D;
                case "E": return OperandType.E;
                case "F": return OperandType.F;
                case "G": return OperandType.G;
                case "H": return OperandType.H;
                case "I": return OperandType.I;
                case "J": return OperandType.J;
                case "K": return OperandType.K;
                case "L": return OperandType.L;
                case "M": return OperandType.M;
                case "N": return OperandType.N;
                case "O": return OperandType.O;
                case "P": return OperandType.P;
                case "Q": return OperandType.Q;
                case "R": return OperandType.R;
                case "S": return OperandType.S;
                case "T": return OperandType.T;
                case "U": return OperandType.U;
                case "V": return OperandType.V;
                case "W": return OperandType.W;
                case "X": return OperandType.X;
                case "Y": return OperandType.Y;
                case "Z": return OperandType.Z;
                default: return OperandType.ERR;
            }
        }
    }
}
