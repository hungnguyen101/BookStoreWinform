namespace BookStoreWinform
{
    partial class AccountForm
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
            this.gvAccount = new System.Windows.Forms.DataGridView();
            this.threadInit = new System.ComponentModel.BackgroundWorker();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccount)).BeginInit();
            this.menuControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvAccount
            // 
            this.gvAccount.AllowUserToAddRows = false;
            this.gvAccount.AllowUserToDeleteRows = false;
            this.gvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAccount.Location = new System.Drawing.Point(12, 48);
            this.gvAccount.Name = "gvAccount";
            this.gvAccount.ReadOnly = true;
            this.gvAccount.Size = new System.Drawing.Size(574, 293);
            this.gvAccount.TabIndex = 0;
            this.gvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAccount_CellClick);
            this.gvAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvAccount_MouseClick);
            // 
            // threadInit
            // 
            this.threadInit.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadInit_DoWork);
            this.threadInit.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.threadInit_RunWorkerCompleted);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(12, 19);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(100, 23);
            this.btnCapnhat.TabIndex = 2;
            this.btnCapnhat.Text = "Cập nhật dữ liệu";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(118, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm tài khoản";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(225, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuControl
            // 
            this.menuControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaToolStripMenuItem,
            this.xoáToolStripMenuItem});
            this.menuControl.Name = "menuControl";
            this.menuControl.Size = new System.Drawing.Size(153, 70);
            this.menuControl.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuControl_ItemClicked);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.chỉnhSửaToolStripMenuItem.Text = "Xem chi tiết";
            // 
            // xoáToolStripMenuItem
            // 
            this.xoáToolStripMenuItem.Name = "xoáToolStripMenuItem";
            this.xoáToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.xoáToolStripMenuItem.Text = "Xoá";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 353);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.gvAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AccountForm";
            this.Text = " Quản lý tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.gvAccount)).EndInit();
            this.menuControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvAccount;
        private System.ComponentModel.BackgroundWorker threadInit;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip menuControl;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoáToolStripMenuItem;
    }
}