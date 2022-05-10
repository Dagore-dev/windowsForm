namespace PruebaFiltros
{
    partial class PruebaFiltros
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
            this.labelForNIF = new System.Windows.Forms.Label();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.labelForAlfanumerico = new System.Windows.Forms.Label();
            this.textBoxAlfanumerico = new System.Windows.Forms.TextBox();
            this.labelForLetras = new System.Windows.Forms.Label();
            this.textBoxLetras = new System.Windows.Forms.TextBox();
            this.labelForReales = new System.Windows.Forms.Label();
            this.textBoxReales = new System.Windows.Forms.TextBox();
            this.labelForEnteros = new System.Windows.Forms.Label();
            this.textBoxEnteros = new System.Windows.Forms.TextBox();
            this.labelForNumerico = new System.Windows.Forms.Label();
            this.textBoxNumerico = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelForNIF, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNIF, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelForAlfanumerico, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAlfanumerico, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelForLetras, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLetras, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelForReales, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxReales, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelForEnteros, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEnteros, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelForNumerico, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNumerico, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelForNIF
            // 
            this.labelForNIF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForNIF.AutoSize = true;
            this.labelForNIF.Location = new System.Drawing.Point(181, 383);
            this.labelForNIF.Name = "labelForNIF";
            this.labelForNIF.Size = new System.Drawing.Size(25, 15);
            this.labelForNIF.TabIndex = 10;
            this.labelForNIF.Text = "NIF";
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNIF.Location = new System.Drawing.Point(532, 379);
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(100, 23);
            this.textBoxNIF.TabIndex = 11;
            this.textBoxNIF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNIF_KeyPress);
            // 
            // labelForAlfanumerico
            // 
            this.labelForAlfanumerico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForAlfanumerico.AutoSize = true;
            this.labelForAlfanumerico.Location = new System.Drawing.Point(154, 312);
            this.labelForAlfanumerico.Name = "labelForAlfanumerico";
            this.labelForAlfanumerico.Size = new System.Drawing.Size(79, 15);
            this.labelForAlfanumerico.TabIndex = 8;
            this.labelForAlfanumerico.Text = "Alfanumérico";
            // 
            // textBoxAlfanumerico
            // 
            this.textBoxAlfanumerico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAlfanumerico.Location = new System.Drawing.Point(532, 308);
            this.textBoxAlfanumerico.Name = "textBoxAlfanumerico";
            this.textBoxAlfanumerico.Size = new System.Drawing.Size(100, 23);
            this.textBoxAlfanumerico.TabIndex = 9;
            this.textBoxAlfanumerico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAlfanumerico_KeyPress);
            // 
            // labelForLetras
            // 
            this.labelForLetras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForLetras.AutoSize = true;
            this.labelForLetras.Location = new System.Drawing.Point(175, 241);
            this.labelForLetras.Name = "labelForLetras";
            this.labelForLetras.Size = new System.Drawing.Size(38, 15);
            this.labelForLetras.TabIndex = 6;
            this.labelForLetras.Text = "Letras";
            // 
            // textBoxLetras
            // 
            this.textBoxLetras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLetras.Location = new System.Drawing.Point(532, 237);
            this.textBoxLetras.Name = "textBoxLetras";
            this.textBoxLetras.Size = new System.Drawing.Size(100, 23);
            this.textBoxLetras.TabIndex = 7;
            this.textBoxLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLetras_KeyPress);
            // 
            // labelForReales
            // 
            this.labelForReales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForReales.AutoSize = true;
            this.labelForReales.Location = new System.Drawing.Point(149, 170);
            this.labelForReales.Name = "labelForReales";
            this.labelForReales.Size = new System.Drawing.Size(89, 15);
            this.labelForReales.TabIndex = 4;
            this.labelForReales.Text = "Números reales";
            // 
            // textBoxReales
            // 
            this.textBoxReales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxReales.Location = new System.Drawing.Point(532, 166);
            this.textBoxReales.Name = "textBoxReales";
            this.textBoxReales.Size = new System.Drawing.Size(100, 23);
            this.textBoxReales.TabIndex = 5;
            this.textBoxReales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxReales_KeyPress);
            // 
            // labelForEnteros
            // 
            this.labelForEnteros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForEnteros.AutoSize = true;
            this.labelForEnteros.Location = new System.Drawing.Point(145, 99);
            this.labelForEnteros.Name = "labelForEnteros";
            this.labelForEnteros.Size = new System.Drawing.Size(98, 15);
            this.labelForEnteros.TabIndex = 2;
            this.labelForEnteros.Text = "Números enteros";
            // 
            // textBoxEnteros
            // 
            this.textBoxEnteros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEnteros.Location = new System.Drawing.Point(532, 95);
            this.textBoxEnteros.Name = "textBoxEnteros";
            this.textBoxEnteros.Size = new System.Drawing.Size(100, 23);
            this.textBoxEnteros.TabIndex = 3;
            this.textBoxEnteros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEnteros_KeyPress);
            // 
            // labelForNumerico
            // 
            this.labelForNumerico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForNumerico.AutoSize = true;
            this.labelForNumerico.Location = new System.Drawing.Point(164, 28);
            this.labelForNumerico.Name = "labelForNumerico";
            this.labelForNumerico.Size = new System.Drawing.Size(60, 15);
            this.labelForNumerico.TabIndex = 0;
            this.labelForNumerico.Text = "Numérico";
            // 
            // textBoxNumerico
            // 
            this.textBoxNumerico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNumerico.Location = new System.Drawing.Point(532, 24);
            this.textBoxNumerico.Name = "textBoxNumerico";
            this.textBoxNumerico.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumerico.TabIndex = 1;
            this.textBoxNumerico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumerico_KeyPress);
            // 
            // PruebaFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PruebaFiltros";
            this.Text = "Prueba filtros";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelForNIF;
        private TextBox textBoxNIF;
        private Label labelForAlfanumerico;
        private TextBox textBoxAlfanumerico;
        private Label labelForLetras;
        private TextBox textBoxLetras;
        private Label labelForReales;
        private TextBox textBoxReales;
        private Label labelForEnteros;
        private TextBox textBoxEnteros;
        private Label labelForNumerico;
        private TextBox textBoxNumerico;
    }
}