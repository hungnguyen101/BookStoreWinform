using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreWinform.OrderService;
using BookStoreWinform.AccountService;

namespace BookStoreWinform
{
    public partial class Order : Form
    {
        private OrderClient orderService = null;
        private AccountClient accountService = null;

        List<OrderService.Order> orders = null;
        long counts = 0;
        decimal total = 0;

        public Order()
        {
            InitializeComponent();

            orderService = new OrderClient();
            accountService = new AccountClient();
            orders = new List<OrderService.Order>();
            threadInit.RunWorkerAsync();
        }

        private void threadInit_DoWork(object sender, DoWorkEventArgs e)
        {
            lblLoad.Show();
            orders = orderService.findAll().ToList();
        }

        private void threadInit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gvOrder.DataSource = orders;
            counts = orders.Count;
            lblLoad.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new AddOrder().Show();
        }


    }
}
