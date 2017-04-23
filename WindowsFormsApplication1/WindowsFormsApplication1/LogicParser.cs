using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicParser

{
    public partial class LogicParser : Form
    {
        List<Object> tmpList;
        public LogicParser()
        {
            InitializeComponent();
            terminalScreen.ReadOnly = true;
        }

        private void Output_Enter(object sender, EventArgs e)
        {
            
        }

        private void and_Click(object sender, EventArgs e)
        {
            formulaInput.AppendText("∧");
        }

        private void or_Click(object sender, EventArgs e)
        {
            formulaInput.AppendText("∨");
        }

        private void negation_Click(object sender, EventArgs e)
        {
            formulaInput.AppendText("¬");
        }

        private void entailment_Click(object sender, EventArgs e)
        {
            formulaInput.AppendText("⇒");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            formulaInput.Clear();
        }

        private void formulaInput_TextChanged(object sender, EventArgs e)
        {
            FormulaParser formula = new FormulaParser();
            formulaInput.Focus();
            formulaInput.Select(formulaInput.TextLength, 0);
            formulaInput.ScrollToCaret();
            string errorMessage = formula.isMatching(formulaInput.Text);
            errorNotification.Text = errorMessage;
            while ((formulaInput.Text == null) || (formulaInput.Text == ""))
            {
                errorNotification.Text = "";
            }
        }

        private void terminalScreen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void input_Click(object sender, EventArgs e)
        {
            string tmpMessage;
            string exp = formulaInput.Text.Trim();
            FormulaParser formula = new FormulaParser();
            if (!formula.isCorrect)
            {
                string faultMessage = formula.isMatching(exp);
                faultMessage = "> " + faultMessage;
                terminalScreen.Text = faultMessage;
            }
            if ((exp == "") || exp == null)
            {
                errorNotification.Text = "Your input formula doesn't exist.";
                return;
            }

            formula.Parse(exp);
            formula.initialize();
            formula.treeCounter();
        }

        
    }
}
