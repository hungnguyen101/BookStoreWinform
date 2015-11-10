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
    public partial class AccountDetailForm : Form
    {
        private AccountClient accountSV = null;
        Account account = null;
        public AccountDetailForm(long id)
        {
            InitializeComponent();
            accountSV = new AccountClient();
            threadInit.RunWorkerAsync(id);
        }

        private void threadInit_DoWork(object sender, DoWorkEventArgs e)
        {
            account = accountSV.findById(Convert.ToInt64(e.Argument));
        }

        private void threadInit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblHoten.Text = account.Fullname;
            lblTaikhoan.Text = account.Username;
            lblEmail.Text = account.Email;
            lblGroup.Text = account.GroupId;
            btnTrangthai.Text = (account.Status.Value) ? "Vô hiệu hoá" : "Kích hoạt";
            gvThongtin.Columns.Add("tieude", "Tiêu đề");
            gvThongtin.Columns.Add("thongtin", "Thông tin");
            gvThongtin.Rows.Add("Địa chỉ", account.Address);
            gvThongtin.Rows.Add("Ngày sinh", account.DayOfBirth);
            gvThongtin.Rows.Add("Ngày tạo", account.CreatedAt.Value.ToShortDateString());
            gvThongtin.Rows.Add("Người tạo", account.CreatedBy);
            gvThongtin.Rows.Add("Ngày sửa", (account.ModifiedAt.HasValue) ? account.ModifiedAt.Value.ToShortDateString() : "");
            gvThongtin.Rows.Add("Người sửa", account.ModifiedBy);
            gvThongtin.Rows.Add("Yahoo", account.Yahoo);
            gvThongtin.Rows.Add("Facebook", account.Facebook);
            gvThongtin.Rows.Add("Phone", account.Phone);
            gvThongtin.Rows.Add("Skype", account.Skype);
            if (account.Avatar != "" || account.Avatar != null)
                threadLoadImage.RunWorkerAsync();
        }

        private void threadLoadImage_DoWork(object sender, DoWorkEventArgs e)
        {
            picAvatar.Load(account.Avatar);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {

            }
        }

    }
}
