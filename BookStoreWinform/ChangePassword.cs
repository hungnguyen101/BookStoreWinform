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
    public partial class ChangePassword : Form
    {
        private long id;
        private AccountClient service = null;
        public ChangePassword(long id)
        {
            InitializeComponent();
            service = new AccountClient();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            string oldP = txtOld.Text;
            string newP = txtNew.Text;
            string check = txtCheck.Text;

            if (!newP.Equals(check))
                MessageBox.Show("2 mật khẩu không giống nhau", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (newP.Length <= 6)
                MessageBox.Show("Mật khẩu phải lớn hơn 6 ký tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Account acc = service.findById(id);
                if (!acc.Password.Equals(MD5(oldP)))
                    MessageBox.Show("Mật khẩu cũ không khớp");
                else
                {
                    acc.Password = MD5(newP);
                    if (service.update(acc))
                        MessageBox.Show("Thành công");
                    else
                        MessageBox.Show("Thất bại");
                }
            }
            button1.Enabled = true;
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
    }
}
