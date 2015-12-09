namespace BookStoreWinform
{
    partial class Order
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
            this.components = new System.ComponentModel.Container();
            this.gvOrder = new System.Windows.Forms.DataGridView();
            this.gvDetail = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.threadInit = new System.ComponentModel.BackgroundWorker();
            this.lblLoad = new System.Windows.Forms.Label();
            this.threadStatus = new System.ComponentModel.BackgroundWorker();
            this.threadDetail = new System.ComponentModel.BackgroundWorker();
            this.menuDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.huỷĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.lblSoluongtong = new System.Windows.Forms.Label();
            this.lblChuaThanhToan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvOrder
            // 
            this.gvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrder.Location = new System.Drawing.Point(12, 12);
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.Size = new System.Drawing.Size(371, 300);
            this.gvOrder.TabIndex = 0;
            this.gvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvOrder_CellClick);
            this.gvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvOrder_CellContentClick);
            this.gvOrder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvOrder_MouseClick);
            // 
            // gvDetail
            // 
            this.gvDetail.AllowUserToAddRows = false;
            this.gvDetail.AllowUserToDeleteRows = false;
            this.gvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetail.Location = new System.Drawing.Point(402, 12);
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.ReadOnly = true;
            this.gvDetail.Size = new System.Drawing.Size(416, 164);
            this.gvDetail.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblChuaThanhToan);
            this.groupBox1.Controls.Add(this.lblSoluongtong);
            this.groupBox1.Location = new System.Drawing.Point(402, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(514, 289);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm hoá đơn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // threadInit
            // 
            this.threadInit.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadInit_DoWork);
            this.threadInit.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.threadInit_RunWorkerCompleted);
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Location = new System.Drawing.Point(12, 329);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(54, 13);
            this.lblLoad.TabIndex = 3;
            this.lblLoad.Text = "Loading...";
            // 
            // threadStatus
            // 
            this.threadStatus.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadStatus_DoWork);
            this.threadStatus.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.threadStatus_RunWorkerCompleted);
            // 
            // threadDetail
            // 
            this.threadDetail.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadDetail_DoWork);
            this.threadDetail.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.threadDetail_RunWorkerCompleted);
            // 
            // menuDelete
            // 
            this.menuDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huỷĐơnHàngToolStripMenuItem});
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(151, 26);
            this.menuDelete.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuDelete_ItemClicked);
            // 
            // huỷĐơnHàngToolStripMenuItem
            // 
            this.huỷĐơnHàngToolStripMenuItem.Name = "huỷĐơnHàngToolStripMenuItem";
            this.huỷĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.huỷĐơnHàngToolStripMenuItem.Text = "Huỷ đơn hàng";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(402, 289);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(106, 23);
            this.btnCapnhat.TabIndex = 4;
            this.btnCapnhat.Text = " Cập nhật dữ liệu";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // lblSoluongtong
            // 
            this.lblSoluongtong.AutoSize = true;
            this.lblSoluongtong.Location = new System.Drawing.Point(20, 33);
            this.lblSoluongtong.Name = "lblSoluongtong";
            this.lblSoluongtong.Size = new System.Drawing.Size(98, 13);
            this.lblSoluongtong.TabIndex = 0;
            this.lblSoluongtong.Text = " Tổng số hoá đơn: ";
            // 
            // lblChuaThanhToan
            // 
            this.lblChuaThanhToan.AutoSize = true;
            this.lblChuaThanhToan.Location = new System.Drawing.Point(20, 70);
            this.lblChuaThanhToan.Name = "lblChuaThanhToan";
            this.lblChuaThanhToan.Size = new System.Drawing.Size(153, 13);
            this.lblChuaThanhToan.TabIndex = 2;
            this.lblChuaThanhToan.Text = " Số hoá đơn chưa thanh toán: ";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 351);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvDetail);
            this.Controls.Add(this.gvOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Order";
            this.Text = "Quản lý hoá đơn";
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuDelete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvOrder;
        private System.Windows.Forms.DataGridView gvDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker threadInit;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Button btnThem;
        private System.ComponentModel.BackgroundWorker threadStatus;
        private System.ComponentModel.BackgroundWorker threadDetail;
        private System.Windows.Forms.ContextMenuStrip menuDelete;
        private System.Windows.Forms.ToolStripMenuItem huỷĐơnHàngToolStripMenuItem;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Label lblChuaThanhToan;
        private System.Windows.Forms.Label lblSoluongtong;
    }
}