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
            this.gvOrder = new System.Windows.Forms.DataGridView();
            this.gvDetail = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.threadInit = new System.ComponentModel.BackgroundWorker();
            this.lblLoad = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvOrder
            // 
            this.gvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrder.Location = new System.Drawing.Point(12, 12);
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.Size = new System.Drawing.Size(371, 300);
            this.gvOrder.TabIndex = 0;
            // 
            // gvDetail
            // 
            this.gvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetail.Location = new System.Drawing.Point(402, 12);
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.Size = new System.Drawing.Size(416, 164);
            this.gvDetail.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(402, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
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
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 88);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm hoá đơn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 351);
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
    }
}