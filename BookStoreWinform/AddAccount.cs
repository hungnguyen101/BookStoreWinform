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
using System.Security.Cryptography;

namespace BookStoreWinform
{
    public partial class AddAccount : Form
    {
        private AccountClient accountSV = null;
        private GroupClient groupSV = null;

        Group[] groups;
        List<string> strGroupNames = null;
        public AddAccount()
        {
            InitializeComponent();
            groupSV = new GroupClient();
            groups = groupSV.findAll();
            strGroupNames = new List<string>();
            foreach (Group g in groups)
                strGroupNames.Add(g.Name);
            cbNhom.DataSource = strGroupNames;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            accountSV = new AccountClient();
            Account acc = new Account();
            acc.CreatedAt = DateTime.Now;
            acc.CreatedBy = CurrentUser.Username;
            acc.Email = txtEmail.Text;
            acc.Fullname = txtHoten.Text;
            acc.GroupId = groups[cbNhom.SelectedIndex].id;
            acc.Password = MD5Hash(txtMatkhau.Text);
            acc.Username = txtTaikhoan.Text;
            acc.Status = chbTrangthai.Checked;
            if (accountSV.insert(acc) > -1)
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Thất bại");
            btnThem.Enabled = true;
        }

        private static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
