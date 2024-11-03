namespace Quanli
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1thoat = new System.Windows.Forms.Button();
            this.label1ngay = new System.Windows.Forms.Label();
            this.label2loaichitieu = new System.Windows.Forms.Label();
            this.labelsotien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2them = new System.Windows.Forms.Button();
            this.button3xoa = new System.Windows.Forms.Button();
            this.button4sua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1thoat
            // 
            this.button1thoat.Location = new System.Drawing.Point(677, 357);
            this.button1thoat.Name = "button1thoat";
            this.button1thoat.Size = new System.Drawing.Size(75, 23);
            this.button1thoat.TabIndex = 0;
            this.button1thoat.Text = "Thoát";
            this.button1thoat.UseVisualStyleBackColor = true;
            // 
            // label1ngay
            // 
            this.label1ngay.AutoSize = true;
            this.label1ngay.Location = new System.Drawing.Point(25, 84);
            this.label1ngay.Name = "label1ngay";
            this.label1ngay.Size = new System.Drawing.Size(40, 16);
            this.label1ngay.TabIndex = 1;
            this.label1ngay.Text = "Ngày";
            // 
            // label2loaichitieu
            // 
            this.label2loaichitieu.AutoSize = true;
            this.label2loaichitieu.Location = new System.Drawing.Point(25, 138);
            this.label2loaichitieu.Name = "label2loaichitieu";
            this.label2loaichitieu.Size = new System.Drawing.Size(80, 16);
            this.label2loaichitieu.TabIndex = 2;
            this.label2loaichitieu.Text = "Loại chi tiêu ";
            // 
            // labelsotien
            // 
            this.labelsotien.AutoSize = true;
            this.labelsotien.Location = new System.Drawing.Point(25, 195);
            this.labelsotien.Name = "labelsotien";
            this.labelsotien.Size = new System.Drawing.Size(48, 16);
            this.labelsotien.TabIndex = 3;
            this.labelsotien.Text = "Số tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mô tả";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 267);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 8;
            // 
            // button2them
            // 
            this.button2them.Location = new System.Drawing.Point(261, 357);
            this.button2them.Name = "button2them";
            this.button2them.Size = new System.Drawing.Size(75, 23);
            this.button2them.TabIndex = 10;
            this.button2them.Text = "Thêm";
            this.button2them.UseVisualStyleBackColor = true;
            //this.button2them.Click += new System.EventHandler(this.button2them_Click);
            // 
            // button3xoa
            // 
            this.button3xoa.Location = new System.Drawing.Point(406, 357);
            this.button3xoa.Name = "button3xoa";
            this.button3xoa.Size = new System.Drawing.Size(75, 23);
            this.button3xoa.TabIndex = 11;
            this.button3xoa.Text = "Xóa";
            this.button3xoa.UseVisualStyleBackColor = true;
            // 
            // button4sua
            // 
            this.button4sua.Location = new System.Drawing.Point(536, 357);
            this.button4sua.Name = "button4sua";
            this.button4sua.Size = new System.Drawing.Size(75, 23);
            this.button4sua.TabIndex = 12;
            this.button4sua.Text = "Sửa";
            this.button4sua.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(441, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(723, 260);
            this.dataGridView1.TabIndex = 13;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngay";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Loai chi tieu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "So tien";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mo ta";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(117, 195);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4sua);
            this.Controls.Add(this.button3xoa);
            this.Controls.Add(this.button2them);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelsotien);
            this.Controls.Add(this.label2loaichitieu);
            this.Controls.Add(this.label1ngay);
            this.Controls.Add(this.button1thoat);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1thoat;
        private System.Windows.Forms.Label label1ngay;
        private System.Windows.Forms.Label label2loaichitieu;
        private System.Windows.Forms.Label labelsotien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2them;
        private System.Windows.Forms.Button button3xoa;
        private System.Windows.Forms.Button button4sua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}