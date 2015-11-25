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
using BookStoreWinform.OrderService;

namespace BookStoreWinform
{
    public partial class AddOrder : Form
    {
        private AccountClient accountService = null;
        private OrderClient orderService = null;
        List<OrderService.DetailOrder> detail = null;

        Account customer;

        public AddOrder()
        {
            InitializeComponent();

            accountService = new AccountClient();
            orderService = new OrderClient();
            detail = new List<DetailOrder>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;

            customer = accountService.findAccountByUsername(textBox1.Text);
            OrderService.Order order;
            if (customer != null)
                order = new OrderService.Order() { Account = customer.id, CreatedBy = CurrentUser.Username };
            else
                order = new OrderService.Order() { CreatedBy = CurrentUser.Username };
            for (int i = 0; i < gvProduct.Rows.Count; i++)
            {
                detail.Add(new DetailOrder() { ProductId = Convert.ToInt32(gvProduct.Rows[i].Cells[0].Value), Quantity = Convert.ToInt32(gvProduct.Rows[i].Cells[1].Value) });
            }
            orderService.insert(order, detail.ToArray());
            btnAdd.Enabled = true;
        }
    }
}
