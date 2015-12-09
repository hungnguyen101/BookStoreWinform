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
using BookStoreWinform.ProductSV;

namespace BookStoreWinform
{
    public partial class Order : Form
    {
        private OrderClient orderService = null;
        private AccountClient accountService = null;
        private ProductClient productService = null;

        List<OrderModel> orders = null;
        OrderService.Order[] arrOrder;
        OrderService.DetailOrder[] detail;
        long counts = 0;
        decimal total = 0;

        public Order()
        {
            InitializeComponent();

            orderService = new OrderClient();
            accountService = new AccountClient();
            productService = new ProductClient();
            orders = new List<OrderModel>();
            threadInit.RunWorkerAsync();
        }

        private void threadInit_DoWork(object sender, DoWorkEventArgs e)
        {
            orders.Clear();
            arrOrder = orderService.findAll();
            foreach (var item in arrOrder)
            {
                OrderModel model = new OrderModel();
                model.MaHD = item.id;
                model.NgayTao = item.CreatedAt.Value.ToShortDateString();
                model.TinhTrang = item.Status.Value;
                model.KhachHang = item.Account.HasValue ?
                    accountService.findById(item.Account.Value).Fullname : "Khách hàng mua tại cửa hàng";
                orders.Add(model);
            }
        }

        private void threadInit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gvOrder.DataSource = orders;
            gvOrder.Columns["MaHD"].HeaderText = "Mã";
            gvOrder.Columns["KhachHang"].HeaderText = "Khách hàng";
            gvOrder.Columns["NgayTao"].HeaderText = "Ngày lập";
            gvOrder.Columns["TinhTrang"].HeaderText = "Đã thành toán";
            counts = orders.Count;
            lblSoluongtong.Text = "Tổng số hoá đơn: " + counts;
            long countStatus = 0;
            foreach (var item in orders)
                if (!item.TinhTrang)
                    countStatus++;
            lblChuaThanhToan.Text = "Số hoá đơn chưa thanh toán: " + countStatus;
            lblLoad.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddOrder frm = new AddOrder();
            frm.Show();
            frm.FormClosed += frm_FormClosed;
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            gvOrder.DataSource = null;
            gvDetail.DataSource = null;
            threadInit.RunWorkerAsync();
        }

        private void gvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                gvOrder.Rows[e.RowIndex].Selected = true;
                lblLoad.Text = "Loading";
                gvDetail.DataSource = null;
                if (threadDetail.IsBusy)
                    threadDetail.CancelAsync();
                threadDetail.RunWorkerAsync(orders[e.RowIndex].MaHD);
                    
            }
            
        }

        private void gvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 3)
            {
                gvOrder.Enabled = false;
                lblLoad.Text = "Loading";
                threadStatus.RunWorkerAsync(gvOrder.Rows[e.RowIndex].Cells[3].Value);
            }
        }

        private void threadStatus_DoWork(object sender, DoWorkEventArgs e)
        {
            OrderService.Order entity = arrOrder[gvOrder.CurrentRow.Index];
            entity.Status = Convert.ToBoolean(e.Argument);
            if (!orderService.update(entity))
                MessageBox.Show("Thất bại");
        }

        private void threadStatus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gvOrder.Enabled = true;
            lblLoad.Text = "";
        }

        private void threadDetail_DoWork(object sender, DoWorkEventArgs e)
        {
            detail = orderService.findDetailByOrder(Convert.ToInt64(e.Argument));
        }

        private void threadDetail_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<DetailModel> lstDetail = new List<DetailModel>();
            foreach (var item in detail)
            {
                DetailModel model = new DetailModel();
                ProductSV.Product p = productService.findById(item.ProductId);
                model.SanPham = p.Name;
                model.SoLuong = item.Quantity.Value;
                model.DonGia = p.Price.Value;
                model.GiaGiam = p.PromotionPrice.HasValue ? p.PromotionPrice.Value : 0;
                model.Thanhtien = p.PromotionPrice.HasValue ? 
                    item.Quantity.Value * p.PromotionPrice.Value : item.Quantity.Value * p.Price.Value;
                lstDetail.Add(model);
            }
            gvDetail.DataSource = lstDetail;
        }

        private void gvOrder_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                menuDelete.Show(Cursor.Position);
            }
        }

        private void menuDelete_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            menuDelete.Close();
            int currentRow = gvOrder.CurrentRow.Index;
            long id = orders[gvOrder.CurrentRow.Index].MaHD;
            DialogResult rs = MessageBox.Show(null, "Chắc chắn huỷ đơn hàng mã số " + id, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == System.Windows.Forms.DialogResult.OK)
            {
                if (orderService.delete(id)) {
                    gvOrder.ClearSelection();
                    gvOrder.DataSource = null;
                    gvDetail.DataSource = null;
                    threadInit.RunWorkerAsync();
                }
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            lblLoad.Text = "Loading";
            gvOrder.DataSource = null;
            gvDetail.DataSource = null;
            threadInit.RunWorkerAsync();
        }
    }
}
