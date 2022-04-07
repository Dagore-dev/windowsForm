namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.tbOperator1 = new System.Windows.Forms.TextBox();
            this.tbOperator2 = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnSum, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSubstract, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnMultiply, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDivide, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbOperator1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbOperator2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbResult, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 237);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSum
            // 
            this.btnSum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSum.Location = new System.Drawing.Point(3, 201);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(59, 23);
            this.btnSum.TabIndex = 0;
            this.btnSum.Tag = "+";
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubstract.Location = new System.Drawing.Point(68, 201);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(59, 23);
            this.btnSubstract.TabIndex = 1;
            this.btnSubstract.Tag = "-";
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnMultiply.Location = new System.Drawing.Point(133, 201);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(59, 23);
            this.BtnMultiply.TabIndex = 2;
            this.BtnMultiply.Tag = "*";
            this.BtnMultiply.Text = "*";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDivide.Location = new System.Drawing.Point(198, 201);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(59, 23);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Tag = "/";
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.Btn_Click);
            // 
            // tbOperator1
            // 
            this.tbOperator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbOperator1.Location = new System.Drawing.Point(3, 83);
            this.tbOperator1.Name = "tbOperator1";
            this.tbOperator1.Size = new System.Drawing.Size(59, 23);
            this.tbOperator1.TabIndex = 4;
            // 
            // tbOperator2
            // 
            this.tbOperator2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbOperator2.Location = new System.Drawing.Point(68, 83);
            this.tbOperator2.Name = "tbOperator2";
            this.tbOperator2.Size = new System.Drawing.Size(59, 23);
            this.tbOperator2.TabIndex = 5;
            // 
            // tbResult
            // 
            this.tbResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.tbResult, 2);
            this.tbResult.Location = new System.Drawing.Point(145, 83);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(100, 23);
            this.tbResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSum;
        private Button btnSubstract;
        private Button BtnMultiply;
        private Button btnDivide;
        private TextBox tbOperator1;
        private TextBox tbOperator2;
        private TextBox tbResult;
    }
}