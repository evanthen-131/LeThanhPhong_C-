namespace Buoi03_1
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
            this.btnCong = new System.Windows.Forms.Button();
            this.lblSoA = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.lblSoB = new System.Windows.Forms.Label();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.lblChuongTrinh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(102, 321);
            this.btnCong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(109, 55);
            this.btnCong.TabIndex = 0;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.Location = new System.Drawing.Point(99, 139);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(44, 20);
            this.lblSoA.TabIndex = 1;
            this.lblSoA.Text = "Số A";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(231, 139);
            this.txtSoA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(479, 26);
            this.txtSoA.TabIndex = 2;
            this.txtSoA.TextChanged += new System.EventHandler(this.txtSoA_TextChanged);
            // 
            // lblSoB
            // 
            this.lblSoB.AutoSize = true;
            this.lblSoB.Location = new System.Drawing.Point(99, 235);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(44, 20);
            this.lblSoB.TabIndex = 3;
            this.lblSoB.Text = "Số B";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(231, 228);
            this.txtSoB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(479, 26);
            this.txtSoB.TabIndex = 4;
            this.txtSoB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(289, 321);
            this.btnTru.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(117, 55);
            this.btnTru.TabIndex = 5;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(467, 321);
            this.btnNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(117, 55);
            this.btnNhan.TabIndex = 6;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(636, 321);
            this.btnChia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(117, 55);
            this.btnChia.TabIndex = 7;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(770, 321);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 55);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(99, 475);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(82, 22);
            this.lblKetQua.TabIndex = 9;
            this.lblKetQua.Text = "Kết quả :";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(231, 475);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(479, 26);
            this.txtKetQua.TabIndex = 10;
            this.txtKetQua.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblChuongTrinh
            // 
            this.lblChuongTrinh.AutoSize = true;
            this.lblChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuongTrinh.ForeColor = System.Drawing.Color.Red;
            this.lblChuongTrinh.Location = new System.Drawing.Point(243, 46);
            this.lblChuongTrinh.Name = "lblChuongTrinh";
            this.lblChuongTrinh.Size = new System.Drawing.Size(463, 32);
            this.lblChuongTrinh.TabIndex = 11;
            this.lblChuongTrinh.Text = "CHƯƠNG TRÌNH TÍNH TOÁN  2 SỐ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.lblChuongTrinh);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.lblSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.lblSoA);
            this.Controls.Add(this.btnCong);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label lblChuongTrinh;
    }
}

