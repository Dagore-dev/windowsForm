namespace EstadisticasTexto
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelLetters = new System.Windows.Forms.Label();
            this.labelWords = new System.Windows.Forms.Label();
            this.labelSpaces = new System.Windows.Forms.Label();
            this.labelVowels = new System.Windows.Forms.Label();
            this.labelConsonants = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelLetters, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelWords, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSpaces, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelVowels, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelConsonants, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox6.Location = new System.Drawing.Point(103, 371);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(45, 23);
            this.textBox6.TabIndex = 10;
            // 
            // textBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 10);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(770, 334);
            this.textBox1.TabIndex = 0;
            // 
            // labelLetters
            // 
            this.labelLetters.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelLetters.AutoSize = true;
            this.labelLetters.Location = new System.Drawing.Point(59, 375);
            this.labelLetters.Name = "labelLetters";
            this.labelLetters.Size = new System.Drawing.Size(38, 15);
            this.labelLetters.TabIndex = 1;
            this.labelLetters.Text = "Letras";
            // 
            // labelWords
            // 
            this.labelWords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWords.AutoSize = true;
            this.labelWords.Location = new System.Drawing.Point(200, 375);
            this.labelWords.Name = "labelWords";
            this.labelWords.Size = new System.Drawing.Size(51, 15);
            this.labelWords.TabIndex = 2;
            this.labelWords.Text = "Palabras";
            // 
            // labelSpaces
            // 
            this.labelSpaces.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSpaces.AutoSize = true;
            this.labelSpaces.Location = new System.Drawing.Point(353, 375);
            this.labelSpaces.Name = "labelSpaces";
            this.labelSpaces.Size = new System.Drawing.Size(52, 15);
            this.labelSpaces.TabIndex = 3;
            this.labelSpaces.Text = "Espacios";
            // 
            // labelVowels
            // 
            this.labelVowels.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelVowels.AutoSize = true;
            this.labelVowels.Location = new System.Drawing.Point(513, 375);
            this.labelVowels.Name = "labelVowels";
            this.labelVowels.Size = new System.Drawing.Size(46, 15);
            this.labelVowels.TabIndex = 4;
            this.labelVowels.Text = "Vocales";
            // 
            // labelConsonants
            // 
            this.labelConsonants.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelConsonants.AutoSize = true;
            this.labelConsonants.Location = new System.Drawing.Point(637, 375);
            this.labelConsonants.Name = "labelConsonants";
            this.labelConsonants.Size = new System.Drawing.Size(76, 15);
            this.labelConsonants.TabIndex = 5;
            this.labelConsonants.Text = "Consonantes";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.Location = new System.Drawing.Point(719, 371);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(51, 23);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox3.Location = new System.Drawing.Point(565, 371);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(45, 23);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox4.Location = new System.Drawing.Point(411, 371);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(45, 23);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox5.Location = new System.Drawing.Point(257, 371);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(45, 23);
            this.textBox5.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox6;
        private TextBox textBox1;
        private Label labelLetters;
        private Label labelWords;
        private Label labelSpaces;
        private Label labelVowels;
        private Label labelConsonants;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}