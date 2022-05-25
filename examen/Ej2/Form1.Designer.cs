namespace Ej2
{
    partial class PasswdChecker
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
            this.labelForPasswd = new System.Windows.Forms.Label();
            this.labelForRepeatPasswd = new System.Windows.Forms.Label();
            this.textBoxForPasswd = new System.Windows.Forms.TextBox();
            this.textBoxForRepeatPass = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelForSpaces = new System.Windows.Forms.Label();
            this.labelForSpecial = new System.Windows.Forms.Label();
            this.labelForDigit = new System.Windows.Forms.Label();
            this.labelForMayus = new System.Windows.Forms.Label();
            this.labelForMinus = new System.Windows.Forms.Label();
            this.labelForEight = new System.Windows.Forms.Label();
            this.labelForEqual = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelForPasswd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelForRepeatPasswd, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxForPasswd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxForRepeatPass, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelForEqual, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelForPasswd
            // 
            this.labelForPasswd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelForPasswd.AutoSize = true;
            this.labelForPasswd.Location = new System.Drawing.Point(166, 75);
            this.labelForPasswd.Name = "labelForPasswd";
            this.labelForPasswd.Size = new System.Drawing.Size(67, 15);
            this.labelForPasswd.TabIndex = 0;
            this.labelForPasswd.Text = "Contraseña";
            // 
            // labelForRepeatPasswd
            // 
            this.labelForRepeatPasswd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelForRepeatPasswd.AutoSize = true;
            this.labelForRepeatPasswd.Location = new System.Drawing.Point(143, 255);
            this.labelForRepeatPasswd.Name = "labelForRepeatPasswd";
            this.labelForRepeatPasswd.Size = new System.Drawing.Size(113, 15);
            this.labelForRepeatPasswd.TabIndex = 1;
            this.labelForRepeatPasswd.Text = "Repita la contraseña";
            // 
            // textBoxForPasswd
            // 
            this.textBoxForPasswd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxForPasswd.Location = new System.Drawing.Point(3, 123);
            this.textBoxForPasswd.Name = "textBoxForPasswd";
            this.textBoxForPasswd.Size = new System.Drawing.Size(394, 23);
            this.textBoxForPasswd.TabIndex = 2;
            this.textBoxForPasswd.TextChanged += new System.EventHandler(this.TextBoxForPasswd_TextChanged);
            // 
            // textBoxForRepeatPass
            // 
            this.textBoxForRepeatPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxForRepeatPass.Location = new System.Drawing.Point(3, 303);
            this.textBoxForRepeatPass.Name = "textBoxForRepeatPass";
            this.textBoxForRepeatPass.Size = new System.Drawing.Size(394, 23);
            this.textBoxForRepeatPass.TabIndex = 3;
            this.textBoxForRepeatPass.TextChanged += new System.EventHandler(this.TextBoxForRepeatPass_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnSave, 2);
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(325, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar contraseña";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.labelForSpaces, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelForSpecial, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelForDigit, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelForMayus, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelForMinus, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelForEight, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 174);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // labelForSpaces
            // 
            this.labelForSpaces.AutoSize = true;
            this.labelForSpaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelForSpaces.ForeColor = System.Drawing.Color.Lime;
            this.labelForSpaces.Location = new System.Drawing.Point(3, 140);
            this.labelForSpaces.Name = "labelForSpaces";
            this.labelForSpaces.Size = new System.Drawing.Size(388, 34);
            this.labelForSpaces.TabIndex = 5;
            this.labelForSpaces.Text = "La contaseña no debe contener espacios";
            this.labelForSpaces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelForSpecial
            // 
            this.labelForSpecial.AutoSize = true;
            this.labelForSpecial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelForSpecial.ForeColor = System.Drawing.Color.Red;
            this.labelForSpecial.Location = new System.Drawing.Point(3, 112);
            this.labelForSpecial.Name = "labelForSpecial";
            this.labelForSpecial.Size = new System.Drawing.Size(388, 28);
            this.labelForSpecial.TabIndex = 4;
            this.labelForSpecial.Text = "La contraseña debe tener un caracter especial";
            this.labelForSpecial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelForDigit
            // 
            this.labelForDigit.AutoSize = true;
            this.labelForDigit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelForDigit.ForeColor = System.Drawing.Color.Red;
            this.labelForDigit.Location = new System.Drawing.Point(3, 84);
            this.labelForDigit.Name = "labelForDigit";
            this.labelForDigit.Size = new System.Drawing.Size(388, 28);
            this.labelForDigit.TabIndex = 3;
            this.labelForDigit.Text = "La contraseña debe contener un dígito";
            this.labelForDigit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelForMayus
            // 
            this.labelForMayus.AutoSize = true;
            this.labelForMayus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelForMayus.ForeColor = System.Drawing.Color.Red;
            this.labelForMayus.Location = new System.Drawing.Point(3, 56);
            this.labelForMayus.Name = "labelForMayus";
            this.labelForMayus.Size = new System.Drawing.Size(388, 28);
            this.labelForMayus.TabIndex = 2;
            this.labelForMayus.Text = "La contraseña debe contener una letra mayúscula";
            this.labelForMayus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelForMinus
            // 
            this.labelForMinus.AutoSize = true;
            this.labelForMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelForMinus.ForeColor = System.Drawing.Color.Red;
            this.labelForMinus.Location = new System.Drawing.Point(3, 28);
            this.labelForMinus.Name = "labelForMinus";
            this.labelForMinus.Size = new System.Drawing.Size(388, 28);
            this.labelForMinus.TabIndex = 1;
            this.labelForMinus.Text = "La contraseña debe contener una letra minúscula";
            this.labelForMinus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelForEight
            // 
            this.labelForEight.AutoSize = true;
            this.labelForEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelForEight.ForeColor = System.Drawing.Color.Red;
            this.labelForEight.Location = new System.Drawing.Point(3, 0);
            this.labelForEight.Name = "labelForEight";
            this.labelForEight.Size = new System.Drawing.Size(388, 28);
            this.labelForEight.TabIndex = 0;
            this.labelForEight.Text = "La contraseña debe tener al menor 8 caracteres";
            this.labelForEight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelForEqual
            // 
            this.labelForEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelForEqual.AutoSize = true;
            this.labelForEqual.ForeColor = System.Drawing.Color.Red;
            this.labelForEqual.Location = new System.Drawing.Point(403, 307);
            this.labelForEqual.Name = "labelForEqual";
            this.labelForEqual.Size = new System.Drawing.Size(394, 15);
            this.labelForEqual.TabIndex = 6;
            this.labelForEqual.Text = "Las contraseñas deben ser iguales";
            this.labelForEqual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswdChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PasswdChecker";
            this.Text = "Comprueba contraseñas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelForPasswd;
        private Label labelForRepeatPasswd;
        private TextBox textBoxForPasswd;
        private TextBox textBoxForRepeatPass;
        private Button btnSave;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelForSpaces;
        private Label labelForSpecial;
        private Label labelForDigit;
        private Label labelForMayus;
        private Label labelForMinus;
        private Label labelForEight;
        private Label labelForEqual;
    }
}