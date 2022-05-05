namespace FlagGenerator
{
    partial class FlagGenerator
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLoad, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Location = new System.Drawing.Point(562, 63);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoad.Location = new System.Drawing.Point(562, 213);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(562, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btn22, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn21, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn20, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn12, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn11, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn02, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn01, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn00, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 444);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btn22
            // 
            this.btn22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn22.Location = new System.Drawing.Point(265, 299);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(126, 142);
            this.btn22.TabIndex = 8;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.BtnFlag_Click);
            // 
            // btn21
            // 
            this.btn21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn21.Location = new System.Drawing.Point(134, 299);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(125, 142);
            this.btn21.TabIndex = 7;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.BtnFlag_Click);
            // 
            // btn20
            // 
            this.btn20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn20.Location = new System.Drawing.Point(3, 299);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(125, 142);
            this.btn20.TabIndex = 6;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.BtnFlag_Click);
            // 
            // btn12
            // 
            this.btn12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn12.Location = new System.Drawing.Point(265, 151);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(126, 142);
            this.btn12.TabIndex = 5;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.BtnFlag_Click);
            // 
            // btn11
            // 
            this.btn11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn11.Location = new System.Drawing.Point(134, 151);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(125, 142);
            this.btn11.TabIndex = 4;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.BtnFlag_Click);
            // 
            // btn10
            // 
            this.btn10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn10.Location = new System.Drawing.Point(3, 151);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(125, 142);
            this.btn10.TabIndex = 3;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.BtnFlag_Click);
            // 
            // btn02
            // 
            this.btn02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn02.Location = new System.Drawing.Point(265, 3);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(126, 142);
            this.btn02.TabIndex = 2;
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.BtnFlag_Click);
            // 
            // btn01
            // 
            this.btn01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn01.Location = new System.Drawing.Point(134, 3);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(125, 142);
            this.btn01.TabIndex = 1;
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.BtnFlag_Click);
            // 
            // btn00
            // 
            this.btn00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn00.Location = new System.Drawing.Point(3, 3);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(125, 142);
            this.btn00.TabIndex = 0;
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.BtnFlag_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FlagGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FlagGenerator";
            this.Text = "Generador de banderas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnReset;
        private Button btnLoad;
        private Button btnSave;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn22;
        private Button btn21;
        private Button btn20;
        private Button btn12;
        private Button btn11;
        private Button btn10;
        private Button btn02;
        private Button btn01;
        private Button btn00;
        private ColorDialog colorDialog1;
        private OpenFileDialog openFileDialog1;
    }
}