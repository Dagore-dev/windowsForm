namespace VisualGatos
{
    partial class VisualGatitos
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBoxEyeColor = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxRace = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.labelForEyeColor = new System.Windows.Forms.Label();
            this.labelForSize = new System.Windows.Forms.Label();
            this.labelForWeight = new System.Windows.Forms.Label();
            this.labelForRace = new System.Windows.Forms.Label();
            this.labelForColor = new System.Windows.Forms.Label();
            this.listViewDetail = new System.Windows.Forms.ListView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelForName = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdate, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEyeColor, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSize, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxWeight, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRace, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxColor, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelForEyeColor, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelForSize, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelForWeight, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelForRace, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelForColor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewDetail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelForName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnRemove, 2);
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(544, 390);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "Eliminar";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnUpdate, 2);
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(544, 345);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnSave, 2);
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(544, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // textBoxEyeColor
            // 
            this.textBoxEyeColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEyeColor.Location = new System.Drawing.Point(629, 219);
            this.textBoxEyeColor.Name = "textBoxEyeColor";
            this.textBoxEyeColor.Size = new System.Drawing.Size(100, 23);
            this.textBoxEyeColor.TabIndex = 17;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSize.Location = new System.Drawing.Point(629, 177);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 23);
            this.textBoxSize.TabIndex = 16;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxWeight.Location = new System.Drawing.Point(629, 135);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 23);
            this.textBoxWeight.TabIndex = 15;
            // 
            // textBoxRace
            // 
            this.textBoxRace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRace.Location = new System.Drawing.Point(629, 93);
            this.textBoxRace.Name = "textBoxRace";
            this.textBoxRace.Size = new System.Drawing.Size(100, 23);
            this.textBoxRace.TabIndex = 14;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxColor.Location = new System.Drawing.Point(629, 51);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 23);
            this.textBoxColor.TabIndex = 13;
            // 
            // labelForEyeColor
            // 
            this.labelForEyeColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForEyeColor.AutoSize = true;
            this.labelForEyeColor.Location = new System.Drawing.Point(446, 223);
            this.labelForEyeColor.Name = "labelForEyeColor";
            this.labelForEyeColor.Size = new System.Drawing.Size(77, 15);
            this.labelForEyeColor.TabIndex = 12;
            this.labelForEyeColor.Text = "Color de ojos";
            // 
            // labelForSize
            // 
            this.labelForSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForSize.AutoSize = true;
            this.labelForSize.Location = new System.Drawing.Point(460, 181);
            this.labelForSize.Name = "labelForSize";
            this.labelForSize.Size = new System.Drawing.Size(49, 15);
            this.labelForSize.TabIndex = 10;
            this.labelForSize.Text = "Tamaño";
            // 
            // labelForWeight
            // 
            this.labelForWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForWeight.AutoSize = true;
            this.labelForWeight.Location = new System.Drawing.Point(469, 139);
            this.labelForWeight.Name = "labelForWeight";
            this.labelForWeight.Size = new System.Drawing.Size(32, 15);
            this.labelForWeight.TabIndex = 8;
            this.labelForWeight.Text = "Peso";
            // 
            // labelForRace
            // 
            this.labelForRace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForRace.AutoSize = true;
            this.labelForRace.Location = new System.Drawing.Point(469, 97);
            this.labelForRace.Name = "labelForRace";
            this.labelForRace.Size = new System.Drawing.Size(31, 15);
            this.labelForRace.TabIndex = 6;
            this.labelForRace.Text = "Raza";
            // 
            // labelForColor
            // 
            this.labelForColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForColor.AutoSize = true;
            this.labelForColor.Location = new System.Drawing.Point(467, 55);
            this.labelForColor.Name = "labelForColor";
            this.labelForColor.Size = new System.Drawing.Size(36, 15);
            this.labelForColor.TabIndex = 4;
            this.labelForColor.Text = "Color";
            // 
            // listViewDetail
            // 
            this.listViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDetail.FullRowSelect = true;
            this.listViewDetail.GridLines = true;
            this.listViewDetail.Location = new System.Drawing.Point(3, 3);
            this.listViewDetail.MultiSelect = false;
            this.listViewDetail.Name = "listViewDetail";
            this.tableLayoutPanel1.SetRowSpan(this.listViewDetail, 10);
            this.listViewDetail.Size = new System.Drawing.Size(382, 420);
            this.listViewDetail.TabIndex = 1;
            this.listViewDetail.UseCompatibleStateImageBehavior = false;
            this.listViewDetail.View = System.Windows.Forms.View.Details;
            this.listViewDetail.SelectedIndexChanged += new System.EventHandler(this.ListViewDetail_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(629, 9);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 2;
            // 
            // labelForName
            // 
            this.labelForName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForName.AutoSize = true;
            this.labelForName.Location = new System.Drawing.Point(459, 13);
            this.labelForName.Name = "labelForName";
            this.labelForName.Size = new System.Drawing.Size(51, 15);
            this.labelForName.TabIndex = 3;
            this.labelForName.Text = "Nombre";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnNew, 2);
            this.btnNew.Location = new System.Drawing.Point(544, 261);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // VisualGatitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VisualGatitos";
            this.Text = "Gatitos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisualGatitos_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelForEyeColor;
        private Label labelForSize;
        private Label labelForWeight;
        private Label labelForRace;
        private Label labelForColor;
        private ListView listViewDetail;
        private TextBox textBoxName;
        private Label labelForName;
        private TextBox textBoxEyeColor;
        private TextBox textBoxSize;
        private TextBox textBoxWeight;
        private TextBox textBoxRace;
        private TextBox textBoxColor;
        private Button btnRemove;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnNew;
    }
}