namespace MiniAgenda
{
    partial class MiniAgenda
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
            this.textBoxTasks = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelForDay = new System.Windows.Forms.Label();
            this.labelForMonth = new System.Windows.Forms.Label();
            this.labelForYear = new System.Windows.Forms.Label();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxTasks, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrev, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNext, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxTasks
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxTasks, 2);
            this.textBoxTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTasks.Location = new System.Drawing.Point(3, 3);
            this.textBoxTasks.Multiline = true;
            this.textBoxTasks.Name = "textBoxTasks";
            this.tableLayoutPanel1.SetRowSpan(this.textBoxTasks, 3);
            this.textBoxTasks.Size = new System.Drawing.Size(458, 420);
            this.textBoxTasks.TabIndex = 0;
            this.textBoxTasks.TextChanged += new System.EventHandler(this.TextBoxTasks_TextChanged);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrev.Location = new System.Drawing.Point(504, 343);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "Anterior";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.Location = new System.Drawing.Point(660, 343);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Siguiente";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(467, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(306, 278);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.labelForDay, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelForMonth, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelForYear, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDay, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMonth, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxYear, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(306, 278);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelForDay
            // 
            this.labelForDay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelForDay.AutoSize = true;
            this.labelForDay.Location = new System.Drawing.Point(34, 38);
            this.labelForDay.Name = "labelForDay";
            this.labelForDay.Size = new System.Drawing.Size(24, 15);
            this.labelForDay.TabIndex = 0;
            this.labelForDay.Text = "Día";
            // 
            // labelForMonth
            // 
            this.labelForMonth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelForMonth.AutoSize = true;
            this.labelForMonth.Location = new System.Drawing.Point(29, 130);
            this.labelForMonth.Name = "labelForMonth";
            this.labelForMonth.Size = new System.Drawing.Size(29, 15);
            this.labelForMonth.TabIndex = 1;
            this.labelForMonth.Text = "Mes";
            // 
            // labelForYear
            // 
            this.labelForYear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelForYear.AutoSize = true;
            this.labelForYear.Location = new System.Drawing.Point(29, 223);
            this.labelForYear.Name = "labelForYear";
            this.labelForYear.Size = new System.Drawing.Size(29, 15);
            this.labelForYear.TabIndex = 2;
            this.labelForYear.Text = "Año";
            // 
            // textBoxDay
            // 
            this.textBoxDay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDay.Location = new System.Drawing.Point(64, 34);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.ReadOnly = true;
            this.textBoxDay.Size = new System.Drawing.Size(100, 23);
            this.textBoxDay.TabIndex = 3;
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxMonth.Location = new System.Drawing.Point(64, 126);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.ReadOnly = true;
            this.textBoxMonth.Size = new System.Drawing.Size(100, 23);
            this.textBoxMonth.TabIndex = 4;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxYear.Location = new System.Drawing.Point(64, 219);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.ReadOnly = true;
            this.textBoxYear.Size = new System.Drawing.Size(100, 23);
            this.textBoxYear.TabIndex = 5;
            // 
            // MiniAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MiniAgenda";
            this.Text = "Mini agenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MiniAgenda_FormClosing);
            this.Load += new System.EventHandler(this.MiniAgenda_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxTasks;
        private Button btnPrev;
        private Button btnNext;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelForDay;
        private Label labelForMonth;
        private Label labelForYear;
        private TextBox textBoxDay;
        private TextBox textBoxMonth;
        private TextBox textBoxYear;
    }
}