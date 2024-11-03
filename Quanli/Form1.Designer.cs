namespace Quanli
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1dangnhap = new System.Windows.Forms.Button();
            this.button3thoat = new System.Windows.Forms.Button();
            this.label1tentaikhoan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1dangnhap1 = new System.Windows.Forms.Label();
            this.button2dangki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1dangnhap
            // 
            this.button1dangnhap.Location = new System.Drawing.Point(418, 351);
            this.button1dangnhap.Name = "button1dangnhap";
            this.button1dangnhap.Size = new System.Drawing.Size(109, 44);
            this.button1dangnhap.TabIndex = 0;
            this.button1dangnhap.Text = "Đăng Nhập";
            this.button1dangnhap.UseVisualStyleBackColor = true;
            //this.button1dangnhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3thoat
            // 
            this.button3thoat.Location = new System.Drawing.Point(683, 351);
            this.button3thoat.Name = "button3thoat";
            this.button3thoat.Size = new System.Drawing.Size(91, 44);
            this.button3thoat.TabIndex = 1;
            this.button3thoat.Text = "Thoát";
            this.button3thoat.UseVisualStyleBackColor = true;
            //this.button3thoat.Click += new System.EventHandler(this.button3thoat_Click);
            // 
            // label1tentaikhoan
            // 
            this.label1tentaikhoan.AutoSize = true;
            this.label1tentaikhoan.Location = new System.Drawing.Point(359, 167);
            this.label1tentaikhoan.Name = "label1tentaikhoan";
            this.label1tentaikhoan.Size = new System.Drawing.Size(88, 16);
            this.label1tentaikhoan.TabIndex = 2;
            this.label1tentaikhoan.Text = "Tên tài khỏan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(482, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(482, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 22);
            this.textBox2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1dangnhap1
            // 
            this.label1dangnhap1.AutoSize = true;
            this.label1dangnhap1.Location = new System.Drawing.Point(518, 59);
            this.label1dangnhap1.Name = "label1dangnhap1";
            this.label1dangnhap1.Size = new System.Drawing.Size(75, 16);
            this.label1dangnhap1.TabIndex = 7;
            this.label1dangnhap1.Text = "Đăng Nhập";
            // 
            // button2dangki
            // 
            this.button2dangki.Location = new System.Drawing.Point(554, 351);
            this.button2dangki.Name = "button2dangki";
            this.button2dangki.Size = new System.Drawing.Size(109, 44);
            this.button2dangki.TabIndex = 8;
            this.button2dangki.Text = "Đăng Kí";
            this.button2dangki.UseVisualStyleBackColor = true;
           // this.button2dangki.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2dangki);
            this.Controls.Add(this.label1dangnhap1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1tentaikhoan);
            this.Controls.Add(this.button3thoat);
            this.Controls.Add(this.button1dangnhap);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1dangnhap;
        private System.Windows.Forms.Button button3thoat;
        private System.Windows.Forms.Label label1tentaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1dangnhap1;
        private System.Windows.Forms.Button button1dangki;
        private System.Windows.Forms.Button button2dangki;
    }
}

