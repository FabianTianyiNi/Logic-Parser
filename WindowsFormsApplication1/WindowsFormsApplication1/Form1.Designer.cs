namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.input = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.formulaInput = new System.Windows.Forms.TextBox();
            this.filtered = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.toolBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.and = new System.Windows.Forms.Button();
            this.or = new System.Windows.Forms.Button();
            this.negation = new System.Windows.Forms.Button();
            this.entailment = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.toolBox.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.8718F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.1282F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.filtered, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.27341F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.72659F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 534);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.input, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.search, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cancel, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(626, 436);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23077F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.76923F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(151, 95);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(3, 3);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(145, 26);
            this.input.TabIndex = 0;
            this.input.Text = "Input Formula";
            this.input.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(3, 35);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(145, 27);
            this.search.TabIndex = 1;
            this.search.Text = "Filtered Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(3, 68);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(145, 24);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.formulaInput, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 436);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(617, 95);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // formulaInput
            // 
            this.formulaInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formulaInput.Location = new System.Drawing.Point(3, 3);
            this.formulaInput.Multiline = true;
            this.formulaInput.Name = "formulaInput";
            this.formulaInput.Size = new System.Drawing.Size(611, 89);
            this.formulaInput.TabIndex = 0;
            // 
            // filtered
            // 
            this.filtered.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtered.Location = new System.Drawing.Point(626, 3);
            this.filtered.Name = "filtered";
            this.filtered.Size = new System.Drawing.Size(151, 427);
            this.filtered.TabIndex = 3;
            this.filtered.TabStop = false;
            this.filtered.Text = "Filter";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.toolBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(617, 427);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // toolBox
            // 
            this.toolBox.Controls.Add(this.tableLayoutPanel5);
            this.toolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBox.Location = new System.Drawing.Point(3, 376);
            this.toolBox.Name = "toolBox";
            this.toolBox.Size = new System.Drawing.Size(611, 48);
            this.toolBox.TabIndex = 0;
            this.toolBox.TabStop = false;
            this.toolBox.Text = "Tool Box";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 431F));
            this.tableLayoutPanel5.Controls.Add(this.and, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.or, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.negation, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.entailment, 4, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(605, 29);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // and
            // 
            this.and.Dock = System.Windows.Forms.DockStyle.Fill;
            this.and.Location = new System.Drawing.Point(5, 3);
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(37, 23);
            this.and.TabIndex = 0;
            this.and.Text = "button1";
            this.and.UseVisualStyleBackColor = true;
            this.and.Click += new System.EventHandler(this.and_Click);
            // 
            // or
            // 
            this.or.Dock = System.Windows.Forms.DockStyle.Fill;
            this.or.Location = new System.Drawing.Point(48, 3);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(36, 23);
            this.or.TabIndex = 1;
            this.or.Text = "button2";
            this.or.UseVisualStyleBackColor = true;
            this.or.Click += new System.EventHandler(this.or_Click);
            // 
            // negation
            // 
            this.negation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.negation.Location = new System.Drawing.Point(90, 3);
            this.negation.Name = "negation";
            this.negation.Size = new System.Drawing.Size(37, 23);
            this.negation.TabIndex = 2;
            this.negation.Text = "button3";
            this.negation.UseVisualStyleBackColor = true;
            // 
            // entailment
            // 
            this.entailment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entailment.Location = new System.Drawing.Point(133, 3);
            this.entailment.Name = "entailment";
            this.entailment.Size = new System.Drawing.Size(38, 23);
            this.entailment.TabIndex = 3;
            this.entailment.Text = "button4";
            this.entailment.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(611, 367);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.toolBox.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox formulaInput;
        private System.Windows.Forms.GroupBox filtered;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox toolBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button and;
        private System.Windows.Forms.Button or;
        private System.Windows.Forms.Button negation;
        private System.Windows.Forms.Button entailment;
        private System.Windows.Forms.TextBox textBox1;
    }
}

