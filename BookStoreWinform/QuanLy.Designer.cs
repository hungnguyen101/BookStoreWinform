﻿namespace BookStoreWinform
{
    partial class QuanLy
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
            this.btnSanpham = new System.Windows.Forms.Button();
            this.btnLoaisanpham = new System.Windows.Forms.Button();
            this.btnTaikhoan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSanpham
            // 
            this.btnSanpham.Location = new System.Drawing.Point(83, 36);
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.Size = new System.Drawing.Size(95, 23);
            this.btnSanpham.TabIndex = 0;
            this.btnSanpham.Text = " Sản phẩm";
            this.btnSanpham.UseVisualStyleBackColor = true;
            this.btnSanpham.Click += new System.EventHandler(this.btnSanpham_Click);
            // 
            // btnLoaisanpham
            // 
            this.btnLoaisanpham.Location = new System.Drawing.Point(83, 99);
            this.btnLoaisanpham.Name = "btnLoaisanpham";
            this.btnLoaisanpham.Size = new System.Drawing.Size(95, 23);
            this.btnLoaisanpham.TabIndex = 1;
            this.btnLoaisanpham.Text = "Loại sản phẩm";
            this.btnLoaisanpham.UseVisualStyleBackColor = true;
            this.btnLoaisanpham.Click += new System.EventHandler(this.btnLoaisanpham_Click);
            // 
            // btnTaikhoan
            // 
            this.btnTaikhoan.Location = new System.Drawing.Point(83, 162);
            this.btnTaikhoan.Name = "btnTaikhoan";
            this.btnTaikhoan.Size = new System.Drawing.Size(95, 23);
            this.btnTaikhoan.TabIndex = 2;
            this.btnTaikhoan.Text = " Tài khoản";
            this.btnTaikhoan.UseVisualStyleBackColor = true;
            this.btnTaikhoan.Click += new System.EventHandler(this.btnTaikhoan_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = " Hoá đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTaikhoan);
            this.Controls.Add(this.btnLoaisanpham);
            this.Controls.Add(this.btnSanpham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuanLy";
            this.Text = "Quản lý bán hàng";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSanpham;
        private System.Windows.Forms.Button btnLoaisanpham;
        private System.Windows.Forms.Button btnTaikhoan;
        private System.Windows.Forms.Button button1;
    }
}