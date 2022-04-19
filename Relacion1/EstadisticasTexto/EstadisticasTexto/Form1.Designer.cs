namespace EstadisticasTexto
{
    partial class EstadistiscasTexto
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
            this.textBoxLetters = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelLetters = new System.Windows.Forms.Label();
            this.labelWords = new System.Windows.Forms.Label();
            this.labelSpaces = new System.Windows.Forms.Label();
            this.labelVowels = new System.Windows.Forms.Label();
            this.labelConsonants = new System.Windows.Forms.Label();
            this.textBoxConsonants = new System.Windows.Forms.TextBox();
            this.textBoxVowels = new System.Windows.Forms.TextBox();
            this.textBoxSpaces = new System.Windows.Forms.TextBox();
            this.textBoxWords = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.textBoxLetters, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelLetters, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelWords, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSpaces, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelVowels, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelConsonants, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxConsonants, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxVowels, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSpaces, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxWords, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxLetters
            // 
            this.textBoxLetters.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxLetters.Location = new System.Drawing.Point(103, 371);
            this.textBoxLetters.Name = "textBoxLetters";
            this.textBoxLetters.ReadOnly = true;
            this.textBoxLetters.Size = new System.Drawing.Size(45, 23);
            this.textBoxLetters.TabIndex = 10;
            // 
            // textBoxInput
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxInput, 10);
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Location = new System.Drawing.Point(3, 3);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(770, 334);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
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
            // textBoxConsonants
            // 
            this.textBoxConsonants.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxConsonants.Location = new System.Drawing.Point(719, 371);
            this.textBoxConsonants.Name = "textBoxConsonants";
            this.textBoxConsonants.ReadOnly = true;
            this.textBoxConsonants.Size = new System.Drawing.Size(51, 23);
            this.textBoxConsonants.TabIndex = 6;
            // 
            // textBoxVowels
            // 
            this.textBoxVowels.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxVowels.Location = new System.Drawing.Point(565, 371);
            this.textBoxVowels.Name = "textBoxVowels";
            this.textBoxVowels.ReadOnly = true;
            this.textBoxVowels.Size = new System.Drawing.Size(45, 23);
            this.textBoxVowels.TabIndex = 7;
            // 
            // textBoxSpaces
            // 
            this.textBoxSpaces.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSpaces.Location = new System.Drawing.Point(411, 371);
            this.textBoxSpaces.Name = "textBoxSpaces";
            this.textBoxSpaces.ReadOnly = true;
            this.textBoxSpaces.Size = new System.Drawing.Size(45, 23);
            this.textBoxSpaces.TabIndex = 8;
            // 
            // textBoxWords
            // 
            this.textBoxWords.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxWords.Location = new System.Drawing.Point(257, 371);
            this.textBoxWords.Name = "textBoxWords";
            this.textBoxWords.ReadOnly = true;
            this.textBoxWords.Size = new System.Drawing.Size(45, 23);
            this.textBoxWords.TabIndex = 9;
            // 
            // EstadistiscasTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EstadistiscasTexto";
            this.Text = "Estadísticas Texto";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxLetters;
        private TextBox textBoxInput;
        private Label labelLetters;
        private Label labelWords;
        private Label labelSpaces;
        private Label labelVowels;
        private Label labelConsonants;
        private TextBox textBoxConsonants;
        private TextBox textBoxVowels;
        private TextBox textBoxSpaces;
        private TextBox textBoxWords;
    }
}