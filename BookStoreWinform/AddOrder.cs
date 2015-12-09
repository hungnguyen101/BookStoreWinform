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
using BookStoreWinform.ProductSV;

namespace BookStoreWinform
{
    public partial class AddOrder : Form
    {
        private AccountClient accountService = null;
        private OrderClient orderService = null;
        private ProductClient productService = null;
        List<OrderService.DetailOrder> detail = null;

        Account customer;

        public AddOrder()
        {
            InitializeComponent();

            accountService = new AccountClient();
            orderService = new OrderClient();
            productService = new ProductClient();
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
            int productId = 0, quantity = 0;
            Product p = null;
            bool err = false;
            for (int i = 0; i < gvProduct.Rows.Count - 1; i++)
            {
                productId = Convert.ToInt32(gvProduct.Rows[i].Cells[0].Value);
                quantity = Convert.ToInt32(gvProduct.Rows[i].Cells[1].Value);
                p = productService.findById(productId);
                if (p.Quantity >= quantity)
                    detail.Add(new DetailOrder() { ProductId = productId, Quantity = quantity });
                else
                {
                    err = true;
                    break;
                }
            }
            if (!err)
            {
                orderService.insert(order, detail.ToArray());
                
            }
            else
            {
                MessageBox.Show("Số lượng sản phẩm " + p.Name + " có mã " + p.id + " vượt quá số lượng trong kho.");
            }
            btnAdd.Enabled = true;
            
        }
    }
}
