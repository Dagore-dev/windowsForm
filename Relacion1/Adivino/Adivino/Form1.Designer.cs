namespace Adivino
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
            this.labelGuessedNumber = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHigher = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnCorrectNumber = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.labelHowToPlay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGuessedNumber
            // 
            this.labelGuessedNumber.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelGuessedNumber, 2);
            this.labelGuessedNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGuessedNumber.Location = new System.Drawing.Point(3, 0);
            this.labelGuessedNumber.Name = "labelGuessedNumber";
            this.labelGuessedNumber.Size = new System.Drawing.Size(515, 61);
            this.labelGuessedNumber.TabIndex = 0;
            this.labelGuessedNumber.Text = "Esperando ...";
            this.labelGuessedNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelGuessedNumber, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnHigher, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLower, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCorrectNumber, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNewGame, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelHowToPlay, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(129, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 309);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnHigher
            // 
            this.btnHigher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHigher.Enabled = false;
            this.btnHigher.Location = new System.Drawing.Point(3, 64);
            this.btnHigher.Name = "btnHigher";
            this.btnHigher.Size = new System.Drawing.Size(254, 55);
            this.btnHigher.TabIndex = 1;
            this.btnHigher.Text = "Mayor";
            this.btnHigher.UseVisualStyleBackColor = true;
            this.btnHigher.Click += new System.EventHandler(this.btnHigher_Click);
            // 
            // btnLower
            // 
            this.btnLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLower.Enabled = false;
            this.btnLower.Location = new System.Drawing.Point(263, 64);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(255, 55);
            this.btnLower.TabIndex = 2;
            this.btnLower.Text = "Menor";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnCorrectNumber
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnCorrectNumber, 2);
            this.btnCorrectNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCorrectNumber.Enabled = false;
            this.btnCorrectNumber.Location = new System.Drawing.Point(3, 125);
            this.btnCorrectNumber.Name = "btnCorrectNumber";
            this.btnCorrectNumber.Size = new System.Drawing.Size(515, 55);
            this.btnCorrectNumber.TabIndex = 3;
            this.btnCorrectNumber.Text = "¡Correcto!";
            this.btnCorrectNumber.UseVisualStyleBackColor = true;
            this.btnCorrectNumber.Click += new System.EventHandler(this.BtnCorrectNumber_Click);
            // 
            // btnNewGame
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnNewGame, 2);
            this.btnNewGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewGame.Location = new System.Drawing.Point(3, 186);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(515, 55);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "Nueva Partida";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // labelHowToPlay
            // 
            this.labelHowToPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHowToPlay.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelHowToPlay, 2);
            this.labelHowToPlay.Location = new System.Drawing.Point(71, 269);
            this.labelHowToPlay.Name = "labelHowToPlay";
            this.labelHowToPlay.Size = new System.Drawing.Size(379, 15);
            this.labelHowToPlay.TabIndex = 5;
            this.labelHowToPlay.Text = "Piensa un número del uno al cien y este programa intentará adivinarlo.";
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

        private Label labelGuessedNumber;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnHigher;
        private Button btnLower;
        private Button btnCorrectNumber;
        private Button btnNewGame;
        private Label labelHowToPlay;
    }
}