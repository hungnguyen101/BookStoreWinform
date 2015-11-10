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
using System.Security.Cryptography;

namespace BookStoreWinform
{
    public partial class LoginForm : Form
    {
        private AccountClient serv = null;
        public LoginForm()
        {
            InitializeComponent();
            serv = new AccountClient();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            button1.Enabled = false;
            Account acc = serv.Authenticate(txtUsername.Text, MD5(txtPassword.Text));
            if (acc != null)
            {
                if (!acc.GroupId.Equals("customer"))
                {
                    CurrentUser.Username = acc.Username;
                    QuanLy frm = new QuanLy();
                    frm.Show();
                    frm.FormClosed += frm_FormClosed;
                    this.Hide();
                }
                else
                {
                    lblError.Text = "Xin lỗi, đây chỉ là tài khoản khách hàng";
                }
            }
            else
            {
                lblError.Text = "Tài khoản hoặc mật khẩu không đúng";
            }
            button1.Enabled = true;
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private string MD5(string text)
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

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login();
        }
    }
}
