namespace MiPrimeraBaseDeDatosChispas
{
    partial class DBChispas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBChispas));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripRemove = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderCode = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDesc = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPrice = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderStock = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripModify,
            this.toolStripRemove});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNew
            // 
            this.toolStripNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNew.Image")));
            this.toolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.Size = new System.Drawing.Size(62, 22);
            this.toolStripNew.Text = "Nuevo";
            this.toolStripNew.Click += new System.EventHandler(this.ToolStripNew_Click);
            // 
            // toolStripModify
            // 
            this.toolStripModify.Image = ((System.Drawing.Image)(resources.GetObject("toolStripModify.Image")));
            this.toolStripModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripModify.Name = "toolStripModify";
            this.toolStripModify.Size = new System.Drawing.Size(78, 22);
            this.toolStripModify.Text = "Modificar";
            this.toolStripModify.Click += new System.EventHandler(this.ToolStripModify_Click);
            // 
            // toolStripRemove
            // 
            this.toolStripRemove.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRemove.Image")));
            this.toolStripRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRemove.Name = "toolStripRemove";
            this.toolStripRemove.Size = new System.Drawing.Size(70, 22);
            this.toolStripRemove.Text = "Eliminar";
            this.toolStripRemove.Click += new System.EventHandler(this.ToolStripRemove_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCode,
            this.columnHeaderDesc,
            this.columnHeaderPrice,
            this.columnHeaderStock});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 25);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 425);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnHeaderCode
            // 
            this.columnHeaderCode.Text = "Código";
            // 
            // columnHeaderDesc
            // 
            this.columnHeaderDesc.Text = "Descripción";
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Precio";
            // 
            // columnHeaderStock
            // 
            this.columnHeaderStock.Text = "Stock";
            // 
            // DBChispas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DBChispas";
            this.Text = "Mi primera base de datos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DBChispas_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripNew;
        private ToolStripButton toolStripModify;
        private ToolStripButton toolStripRemove;
        private ListView listView1;
        private ColumnHeader columnHeaderCode;
        private ColumnHeader columnHeaderDesc;
        private ColumnHeader columnHeaderPrice;
        private ColumnHeader columnHeaderStock;
    }
}