using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreWinform
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.Show();
        }

        private void btnLoaisanpham_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.Show();
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            AccountForm frm = new AccountForm();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order frm = new Order();
            frm.Show();
        }
    }
}
