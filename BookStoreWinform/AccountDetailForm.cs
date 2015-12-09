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
using BookStoreWinform.GroupService;
using BookStoreWinform.OrderService;

namespace BookStoreWinform
{
    public partial class AccountDetailForm : Form
    {
        private AccountClient accountSV = null;
        private GroupClient groupSV = null;
        private OrderClient orderSV = null;
        Account account = null;
        Group[] groups;

        public AccountDetailForm(long id)
        {
            InitializeComponent();
            accountSV = new AccountClient();
            groupSV = new GroupClient();
            orderSV = new OrderClient();
            threadInit.RunWorkerAsync(id);
            
        }

        public void initComboBox()
        {
            List<string> strGroupNames = new List<string>();
            foreach (Group g in groups)
                strGroupNames.Add(g.Name);
            cbGroup.DataSource = strGroupNames;
        }

        private void threadInit_DoWork(object sender, DoWorkEventArgs e)
        {
            account = accountSV.findById(Convert.ToInt64(e.Argument));
            groups = groupSV.findAll();
        }

        private void threadInit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblHoten.Text = account.Fullname;
            lblTaikhoan.Text = account.Username;
            lblEmail.Text = account.Email;
            initComboBox();
            cbGroup.SelectedItem = groups.SingleOrDefault(g => g.id.Equals(account.GroupId)).Name;
            chbStatus.Checked = account.Status.Value;
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

            gvHoadon.DataSource = orderSV.findOrderByAccount(account.id).Select(x => new { x.id, x.CreatedAt, x.Status }).ToList();
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

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            account.ModifiedAt = DateTime.Now;
            account.ModifiedBy = CurrentUser.Username;
            account.Status = chbStatus.Checked;
            account.GroupId = groups[cbGroup.SelectedIndex].id;
            if (accountSV.update(account))
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Thất bại");
            button1.Enabled = true;
        }

    }
}
