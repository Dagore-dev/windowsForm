namespace MultiConvesor
{
    partial class MultiConversor
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonKelvin1 = new System.Windows.Forms.RadioButton();
            this.radioButtonFarenheit1 = new System.Windows.Forms.RadioButton();
            this.radioButtonCelsius1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonKelvin2 = new System.Windows.Forms.RadioButton();
            this.radioButtonFarenheit2 = new System.Windows.Forms.RadioButton();
            this.radioButtonCelsius2 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
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
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(144, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(532, 321);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(382, 206);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonKelvin1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonFarenheit1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonCelsius1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(382, 206);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // radioButtonKelvin1
            // 
            this.radioButtonKelvin1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonKelvin1.AutoSize = true;
            this.radioButtonKelvin1.Location = new System.Drawing.Point(162, 161);
            this.radioButtonKelvin1.Name = "radioButtonKelvin1";
            this.radioButtonKelvin1.Size = new System.Drawing.Size(57, 19);
            this.radioButtonKelvin1.TabIndex = 2;
            this.radioButtonKelvin1.TabStop = true;
            this.radioButtonKelvin1.Tag = "2";
            this.radioButtonKelvin1.Text = "Kelvin";
            this.radioButtonKelvin1.UseVisualStyleBackColor = true;
            this.radioButtonKelvin1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonFarenheit1
            // 
            this.radioButtonFarenheit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonFarenheit1.AutoSize = true;
            this.radioButtonFarenheit1.Location = new System.Drawing.Point(154, 92);
            this.radioButtonFarenheit1.Name = "radioButtonFarenheit1";
            this.radioButtonFarenheit1.Size = new System.Drawing.Size(74, 19);
            this.radioButtonFarenheit1.TabIndex = 1;
            this.radioButtonFarenheit1.TabStop = true;
            this.radioButtonFarenheit1.Tag = "1";
            this.radioButtonFarenheit1.Text = "Farenheit";
            this.radioButtonFarenheit1.UseVisualStyleBackColor = true;
            this.radioButtonFarenheit1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonCelsius1
            // 
            this.radioButtonCelsius1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonCelsius1.AutoSize = true;
            this.radioButtonCelsius1.Checked = true;
            this.radioButtonCelsius1.Location = new System.Drawing.Point(160, 24);
            this.radioButtonCelsius1.Name = "radioButtonCelsius1";
            this.radioButtonCelsius1.Size = new System.Drawing.Size(62, 19);
            this.radioButtonCelsius1.TabIndex = 0;
            this.radioButtonCelsius1.TabStop = true;
            this.radioButtonCelsius1.Tag = "0";
            this.radioButtonCelsius1.Text = "Celsius";
            this.radioButtonCelsius1.UseVisualStyleBackColor = true;
            this.radioButtonCelsius1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(391, 3);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel1.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(382, 206);
            this.panel2.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.radioButtonKelvin2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.radioButtonFarenheit2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.radioButtonCelsius2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(382, 206);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // radioButtonKelvin2
            // 
            this.radioButtonKelvin2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonKelvin2.AutoSize = true;
            this.radioButtonKelvin2.Location = new System.Drawing.Point(162, 161);
            this.radioButtonKelvin2.Name = "radioButtonKelvin2";
            this.radioButtonKelvin2.Size = new System.Drawing.Size(57, 19);
            this.radioButtonKelvin2.TabIndex = 2;
            this.radioButtonKelvin2.TabStop = true;
            this.radioButtonKelvin2.Tag = "2";
            this.radioButtonKelvin2.Text = "Kelvin";
            this.radioButtonKelvin2.UseVisualStyleBackColor = true;
            this.radioButtonKelvin2.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonFarenheit2
            // 
            this.radioButtonFarenheit2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonFarenheit2.AutoSize = true;
            this.radioButtonFarenheit2.Location = new System.Drawing.Point(154, 92);
            this.radioButtonFarenheit2.Name = "radioButtonFarenheit2";
            this.radioButtonFarenheit2.Size = new System.Drawing.Size(74, 19);
            this.radioButtonFarenheit2.TabIndex = 1;
            this.radioButtonFarenheit2.TabStop = true;
            this.radioButtonFarenheit2.Tag = "1";
            this.radioButtonFarenheit2.Text = "Farenheit";
            this.radioButtonFarenheit2.UseVisualStyleBackColor = true;
            this.radioButtonFarenheit2.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonCelsius2
            // 
            this.radioButtonCelsius2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonCelsius2.AutoSize = true;
            this.radioButtonCelsius2.Checked = true;
            this.radioButtonCelsius2.Location = new System.Drawing.Point(160, 24);
            this.radioButtonCelsius2.Name = "radioButtonCelsius2";
            this.radioButtonCelsius2.Size = new System.Drawing.Size(62, 19);
            this.radioButtonCelsius2.TabIndex = 0;
            this.radioButtonCelsius2.TabStop = true;
            this.radioButtonCelsius2.Tag = "0";
            this.radioButtonCelsius2.Text = "Celsius";
            this.radioButtonCelsius2.UseVisualStyleBackColor = true;
            this.radioButtonCelsius2.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // MultiConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MultiConversor";
            this.Text = "Multi Conversor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton radioButtonKelvin1;
        private RadioButton radioButtonFarenheit1;
        private RadioButton radioButtonCelsius1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel4;
        private RadioButton radioButtonKelvin2;
        private RadioButton radioButtonFarenheit2;
        private RadioButton radioButtonCelsius2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}