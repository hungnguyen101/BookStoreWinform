using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreWinform.AccountService;

namespace BookStoreWinform
{
    public partial class AccountForm : Form
    {
        private AccountClient accountSV = null;
        Account[] arrAccounts;
        public AccountForm()
        {
            InitializeComponent();

            accountSV = new AccountClient();
            threadInit.RunWorkerAsync();
            initComboBox();
        }

        private void initComboBox()
        {
            string[] filters = { "Khách hàng", "Quản trị", "Tài khoản bị ban", "Khách hàng quen thuộc" };
            foreach (string item in filters)
                comboBox1.Items.Add(item);
        }

        private void threadInit_DoWork(object sender, DoWorkEventArgs e)
        {
            arrAccounts = accountSV.findAll();
        }

        private void threadInit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gvAccount.DataSource = arrAccounts.Select(a =>
                new { a.Fullname, a.Username, a.Email, a.Status, a.GroupId, a.CreatedAt }).ToArray();
            btnCapnhat.Enabled = true;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            btnCapnhat.Enabled = false;
            threadInit.RunWorkerAsync();
        }

        private void gvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gvAccount.Rows[e.RowIndex].Selected = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    gvAccount.DataSource = arrAccounts.Where(a => a.GroupId.Equals("customer")).Select(a =>
                        new { a.Fullname, a.Username, a.Email, a.GroupId, a.CreatedAt, a.Status }).ToArray();
                    break;
                case 1:
                    gvAccount.DataSource = arrAccounts.Where(a => a.GroupId.Equals("admin")).Select(a =>
                        new { a.Fullname, a.Username, a.Email, a.GroupId, a.CreatedAt, a.Status }).ToArray();
                    break;
                case 2:
                    gvAccount.DataSource = arrAccounts.Where(a => a.Status.Value == false).Select(a =>
                        new { a.Fullname, a.Username, a.Email, a.GroupId, a.CreatedAt, a.Status }).ToArray();
                    break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddAccount frm = new AddAccount();
            frm.Show();
            frm.FormClosed += frm_FormClosed;
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            threadInit.RunWorkerAsync();
        }

        private void gvAccount_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                menuControl.Items[2].Enabled = (arrAccounts[gvAccount.CurrentRow.Index].Username == CurrentUser.Username);
                menuControl.Show(Cursor.Position);
            }
        }

        private void menuControl_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string currentEmail = gvAccount.CurrentRow.Cells["Email"].Value.ToString();
            long id = arrAccounts.SingleOrDefault(a => a.Email.Equals(currentEmail)).id;
            switch (e.ClickedItem.ToString())
            {
                case "Xem chi tiết":
                    AccountDetailForm frm = new AccountDetailForm(id);
                    frm.Show();
                    frm.FormClosed += frm_FormClosed;
                    break;
                case "Xoá":
                    DialogResult rs = MessageBox.Show("Chắc chắn xoá?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (rs == System.Windows.Forms.DialogResult.OK)
                    {
                        accountSV.delete(id);
                        threadInit.RunWorkerAsync();
                    }
                    break;
                case "Đổi mật khẩu":
                    new ChangePassword(id).Show();
                    break;
            }
        }
    }
}
