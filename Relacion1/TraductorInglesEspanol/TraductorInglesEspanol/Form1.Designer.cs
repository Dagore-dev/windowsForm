namespace TraductorInglesEspanol
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnToSpanish = new System.Windows.Forms.Button();
            this.btnToEnglish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnToSpanish, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnToEnglish, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(166, 137);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 190);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(48, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // btnToSpanish
            // 
            this.btnToSpanish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToSpanish.Location = new System.Drawing.Point(35, 131);
            this.btnToSpanish.Name = "btnToSpanish";
            this.btnToSpanish.Size = new System.Drawing.Size(125, 23);
            this.btnToSpanish.TabIndex = 1;
            this.btnToSpanish.Text = "Traducir al castellano";
            this.btnToSpanish.UseVisualStyleBackColor = true;
            this.btnToSpanish.Click += new System.EventHandler(this.BtnToSpanish_Click);
            // 
            // btnToEnglish
            // 
            this.btnToEnglish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToEnglish.Location = new System.Drawing.Point(232, 131);
            this.btnToEnglish.Name = "btnToEnglish";
            this.btnToEnglish.Size = new System.Drawing.Size(125, 23);
            this.btnToEnglish.TabIndex = 2;
            this.btnToEnglish.Text = "Traducir al inglés";
            this.btnToEnglish.UseVisualStyleBackColor = true;
            this.btnToEnglish.Click += new System.EventHandler(this.BtnToEnglish_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Esperando...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private Button btnToSpanish;
        private Button btnToEnglish;
        private Label label1;
    }
}