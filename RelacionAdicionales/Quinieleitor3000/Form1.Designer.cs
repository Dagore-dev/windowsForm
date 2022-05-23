namespace Quinieleitor3000
{
    partial class Quinieleitor
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
            this.labelForJornada = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnPartido = new System.Windows.Forms.ColumnHeader();
            this.columnGanaLocal = new System.Windows.Forms.ColumnHeader();
            this.columnEmpate = new System.Windows.Forms.ColumnHeader();
            this.columnGanaVisitante = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelForJornada, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGenerate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelForJornada
            // 
            this.labelForJornada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForJornada.AutoSize = true;
            this.labelForJornada.Location = new System.Drawing.Point(72, 37);
            this.labelForJornada.Name = "labelForJornada";
            this.labelForJornada.Size = new System.Drawing.Size(48, 15);
            this.labelForJornada.TabIndex = 0;
            this.labelForJornada.Text = "Jornada";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown1.Location = new System.Drawing.Point(228, 33);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            38,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnGenerate, 2);
            this.btnGenerate.Location = new System.Drawing.Point(117, 393);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "¡Generar quiniela!";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPartido,
            this.columnGanaLocal,
            this.columnEmpate,
            this.columnGanaVisitante});
            this.tableLayoutPanel1.SetColumnSpan(this.listView1, 2);
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 93);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(378, 264);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnPartido
            // 
            this.columnPartido.Text = "Partido";
            this.columnPartido.Width = 250;
            // 
            // columnGanaLocal
            // 
            this.columnGanaLocal.Text = "1";
            this.columnGanaLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnGanaLocal.Width = 40;
            // 
            // columnEmpate
            // 
            this.columnEmpate.Text = "X";
            this.columnEmpate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnEmpate.Width = 40;
            // 
            // columnGanaVisitante
            // 
            this.columnGanaVisitante.Text = "2";
            this.columnGanaVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnGanaVisitante.Width = 40;
            // 
            // Quinieleitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Quinieleitor";
            this.Text = "Quinieleitor 3000";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelForJornada;
        private NumericUpDown numericUpDown1;
        private Button btnGenerate;
        private ListView listView1;
        private ColumnHeader columnPartido;
        private ColumnHeader columnGanaLocal;
        private ColumnHeader columnEmpate;
        private ColumnHeader columnGanaVisitante;
    }
}