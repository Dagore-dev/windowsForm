namespace CreaDiccionario
{
    partial class CreaDiccionario
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
            this.listBoxPairs = new System.Windows.Forms.ListBox();
            this.labelForSpanish = new System.Windows.Forms.Label();
            this.labelForEnglish = new System.Windows.Forms.Label();
            this.textBoxSpanish = new System.Windows.Forms.TextBox();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.listBoxPairs, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelForSpanish, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelForEnglish, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSpanish, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEnglish, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listBoxPairs
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listBoxPairs, 2);
            this.listBoxPairs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPairs.FormattingEnabled = true;
            this.listBoxPairs.ItemHeight = 15;
            this.listBoxPairs.Location = new System.Drawing.Point(3, 3);
            this.listBoxPairs.Name = "listBoxPairs";
            this.tableLayoutPanel1.SetRowSpan(this.listBoxPairs, 4);
            this.listBoxPairs.Size = new System.Drawing.Size(382, 420);
            this.listBoxPairs.TabIndex = 0;
            this.listBoxPairs.SelectedIndexChanged += new System.EventHandler(this.ListBoxPairs_SelectedIndexChanged);
            // 
            // labelForSpanish
            // 
            this.labelForSpanish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForSpanish.AutoSize = true;
            this.labelForSpanish.Location = new System.Drawing.Point(461, 45);
            this.labelForSpanish.Name = "labelForSpanish";
            this.labelForSpanish.Size = new System.Drawing.Size(48, 15);
            this.labelForSpanish.TabIndex = 1;
            this.labelForSpanish.Text = "Español";
            // 
            // labelForEnglish
            // 
            this.labelForEnglish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForEnglish.AutoSize = true;
            this.labelForEnglish.Location = new System.Drawing.Point(466, 151);
            this.labelForEnglish.Name = "labelForEnglish";
            this.labelForEnglish.Size = new System.Drawing.Size(38, 15);
            this.labelForEnglish.TabIndex = 2;
            this.labelForEnglish.Text = "Inglés";
            // 
            // textBoxSpanish
            // 
            this.textBoxSpanish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSpanish.Location = new System.Drawing.Point(585, 41);
            this.textBoxSpanish.Name = "textBoxSpanish";
            this.textBoxSpanish.Size = new System.Drawing.Size(188, 23);
            this.textBoxSpanish.TabIndex = 3;
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEnglish.Location = new System.Drawing.Point(585, 147);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(188, 23);
            this.textBoxEnglish.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(447, 307);
            this.btnAdd.Name = "btnAdd";
            this.tableLayoutPanel1.SetRowSpan(this.btnAdd, 2);
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(641, 307);
            this.btnRemove.Name = "btnRemove";
            this.tableLayoutPanel1.SetRowSpan(this.btnRemove, 2);
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Borrar";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // CreaDiccionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreaDiccionario";
            this.Text = "Crea diccionario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreaDiccionario_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListBox listBoxPairs;
        private Label labelForSpanish;
        private Label labelForEnglish;
        private TextBox textBoxSpanish;
        private TextBox textBoxEnglish;
        private Button btnAdd;
        private Button btnRemove;
    }
}