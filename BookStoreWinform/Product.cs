﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreWinform.ProductSV;
using BookStoreWinform.CategoryService;
using System.Threading;
using System.Xml.Linq;
using System.Reflection;

namespace BookStoreWinform
{
    public partial class frmProduct : Form
    {
        ProductClient sv;
        CategoryClient svCat;
        Product[] products;

        Category[] categories;
        Product p = null;

        public frmProduct()
        {
            InitializeComponent();

            threadInit.RunWorkerAsync();
        }

        public void frmProductInit()
        {
            sv = new ProductClient();
            svCat = new CategoryClient();
            products = sv.findAll();
            categories = svCat.findAll();
            initComboBox();
            showProduct(0);
            bindData(products);
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            gvProduct.DataSource = null;
            cbLoai.DataSource = null;
            products = sv.findAll();
            bindData(products);
            cbLoai.SelectedIndex = 0;
        }

        private void gvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showProduct(e.RowIndex);
        }

        private void showProduct(long index)
        {
            resetField();
            p = products[index];
            if (p.Thumbnail != null)
                threadLoadImage.RunWorkerAsync();
            lblName.Text = (p.Name.Length <= 40) ? p.Name : p.Name.Substring(0,40) + "...";
            lblCreatedBy.Text = p.CreatedAt.Value.ToShortDateString() + " bởi " + p.CreatedBy;
            lblModified.Text = (p.ModifiedAt.HasValue) ? p.ModifiedAt.Value.ToShortDateString() + " bởi " + p.ModifiedBy : "";
            lblLoai.Text = categories.SingleOrDefault(c => c.id == p.Category).Name;
            if (p.Status.Value)
            {
                lblTinhtrang.Text = "Hoạt động";
                lblTinhtrang.ForeColor = Color.Green;
                lblTinhtrang.Text += (p.ShowOnHome.Value) ? " Hiện ngoài trang chủ" : " Ẩn ngoài trang chủ";
            }
            else
            {
                lblTinhtrang.Text = "Bị ẩn";
                lblTinhtrang.ForeColor = Color.Red;
            }
            foreach (var element in XElement.Parse(p.Description).Elements())
            {
                gvDescription.Rows.Add(element.Attribute("title").Value, element.Value);
            }
        }

        private void resetField()
        {
            pictureBox1.Image = null;
            lblName.Text = "";
            lblCreatedBy.Text = "";
            lblLoai.Text = "";
            lblTinhtrang.Text = "";
            while (gvDescription.Rows.Count > 0)
                gvDescription.Rows.RemoveAt(0);
                
        }

        private void bindData(Product[] products)
        {
            var arrDisplay = products.Select(a => new { a.Name, a.Price, a.Quantity, a.PromotionPrice, a.Promotion }).ToArray();
            gvProduct.DataSource = arrDisplay;
        }

        private void initComboBox()
        {
            cbLoai.Items.Add("Chọn loại sản phẩm");
            cbLoai.SelectedIndex = 0;
            foreach (var item in categories)
                cbLoai.Items.Add(item.Name);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddProduct frmAdd = new AddProduct(1);
            frmAdd.Show();
            frmAdd.FormClosed += frmAdd_FormClosed;
        }

        void frmAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmProductInit();
        }

        private void gvProduct_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuGridView.Show(Cursor.Position);
            }
        }

        private void menuGridView_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            long id = products[gvProduct.CurrentRow.Index].id;
            menuGridView.Hide();
            switch (e.ClickedItem.ToString())
            {
                case "Chỉnh sửa":
                    AddProduct frm = new AddProduct(2, id);
                    frm.Show();
                    break;
                case "Xoá":
                    DialogResult rs = MessageBox.Show("Bạn chắc chắn xoá?", "Thông báo", MessageBoxButtons.OKCancel);
                    if (rs == DialogResult.OK)
                    {
                        ProductClient sv = new ProductClient();
                        if (sv.delete(id)) {
                            MessageBox.Show("Thành công");
                        }
                        else
                            MessageBox.Show("Thất bại");
                    }
                    break;
            }
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoai.SelectedIndex > 0)
            {
                gvProduct.DataSource = null;
                products = sv.findProductsByCategory(categories[cbLoai.SelectedIndex - 1].id);
                bindData(products);
            }
        }

        private void lblName_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void threadInit_DoWork(object sender, DoWorkEventArgs e)
        {
            sv = new ProductClient();
            svCat = new CategoryClient();
            products = sv.findAll();
            threadInit.ReportProgress(60);
            categories = svCat.findAll();
            threadInit.ReportProgress(100);
        }

        private void threadInit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            initComboBox();
            showProduct(0);
            bindData(products);
        }

        private void threadInit_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbLoadInitForm.Value = e.ProgressPercentage;
        }

        private void threadLoadImage_DoWork(object sender, DoWorkEventArgs e)
        {
            pictureBox1.Load(p.Thumbnail);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            gvProduct.DataSource = null;
            string search = txtSearch.Text;
            Product[] temps = products;
            temps = products.Where(p => p.Name.Contains(search)).ToArray();
            bindData(temps);
        }

    }
}
