namespace Buoi4_04
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
            this.phHinh = new System.Windows.Forms.PictureBox();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.btnLuuFile = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.phHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // phHinh
            // 
            this.phHinh.Location = new System.Drawing.Point(39, 69);
            this.phHinh.Name = "phHinh";
            this.phHinh.Size = new System.Drawing.Size(257, 292);
            this.phHinh.TabIndex = 0;
            this.phHinh.TabStop = false;
            this.phHinh.Click += new System.EventHandler(this.phHinh_Click);
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(121, 394);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(99, 23);
            this.btnChonHinh.TabIndex = 2;
            this.btnChonHinh.Text = "Chọn hình ảnh";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(353, 394);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(75, 23);
            this.btnChonFile.TabIndex = 2;
            this.btnChonFile.Text = "Chọn tệp tin";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // btnLuuFile
            // 
            this.btnLuuFile.Location = new System.Drawing.Point(475, 394);
            this.btnLuuFile.Name = "btnLuuFile";
            this.btnLuuFile.Size = new System.Drawing.Size(75, 23);
            this.btnLuuFile.TabIndex = 2;
            this.btnLuuFile.Text = "Lưu tệp tin";
            this.btnLuuFile.UseVisualStyleBackColor = true;
            this.btnLuuFile.Click += new System.EventHandler(this.btnLuuFile_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(652, 394);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(338, 69);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(418, 292);
            this.txtNoiDung.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuuFile);
            this.Controls.Add(this.btnChonFile);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.phHinh);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.phHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox phHinh;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Button btnLuuFile;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtNoiDung;
    }
}

