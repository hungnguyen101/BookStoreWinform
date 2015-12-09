using System;
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
using System.Xml.Linq;
using System.IO;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json.Linq;

namespace BookStoreWinform
{
    public partial class AddProduct : Form
    {
        private int mode;
        ProductSV.Product entity = new ProductSV.Product();
        Category[] cats = null;
        string filename = "";
        string existThumbnail = "";
        string sBtn = "";
        CategoryService.CategoryClient catSV;

        public AddProduct(int mode, long product = 0)
        {
            InitializeComponent();
            
            catSV = new CategoryClient();
            initLoaiSP();

            this.mode = mode;
            if (mode == 1)
                sBtn = "Thêm sản phẩm";
            if (mode == 2)
            {
                entity.id = product;
                sBtn = "Cập nhật sản phẩm";
                ProductClient sv = new ProductClient();
                Product p = sv.findById(product);
                if (p.Thumbnail != null)
                {
                    existThumbnail = p.Thumbnail;
                    threadLoadImage.RunWorkerAsync(p.Thumbnail);
                }
                    
                txtName.Text = p.Name;
                txtDongia.Text = p.Price.Value.ToString();
                txtGiagiam.Text = p.PromotionPrice.HasValue ? p.PromotionPrice.Value.ToString() : "";
                numSoluong.Value = p.Quantity.Value;
                chbHienthi.Checked = p.ShowOnHome.Value;
                chbHoatdong.Checked = p.Status.Value;

                for (int i = 0; i < cats.Length; i++)
                {
                    if (cats[i].id == p.Category)
                    {
                        cbLoai.SelectedIndex = i;
                        break;
                    }
                }

                foreach (var element in XElement.Parse(p.Description).Elements())
                {
                    gvDescription.Rows.Add(element.Attribute("title").Value, element.Value);
                }

            }
            btnUpdate.Text = sBtn;
        }

        private void initLoaiSP()
        {
            cats = catSV.findAll();
            List<string> catName = new List<string>();
            foreach (Category c in cats)
                catName.Add(c.Name);
            cbLoai.DataSource = catName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            ProductClient sv;
            switch (mode)
            {
                case 1:
                    // Thêm sản phẩm
                    LoadEntity();
                    if (filename != "")
                        entity.Thumbnail = UploadImage();
                    sv = new ProductClient();

                    if (sv.insert(entity) > -1)
                        MessageBox.Show("Thành công");
                    else
                        MessageBox.Show("Thất bại");
                    btnUpdate.Enabled = true;
                    break;
                case 2:
                    LoadEntity();
                    entity.ModifiedAt = DateTime.Now;
                    entity.ModifiedBy = CurrentUser.Username;
                    if (filename != "")
                        entity.Thumbnail = UploadImage();
                    sv = new ProductClient();
                    if (sv.update(entity))
                        MessageBox.Show("Thành công");
                    else
                        MessageBox.Show("Thất bại");
                    btnUpdate.Enabled = true;
                    break;
            }
        }

        private void LoadEntity()
        {
            entity.Category = cats[cbLoai.SelectedIndex].id;
            entity.Name = txtName.Text;
            entity.Price = Convert.ToDecimal(txtDongia.Text);
            entity.PromotionPrice = (txtGiagiam.Text.Length > 0) ? Convert.ToDecimal(txtGiagiam.Text) : 0;
            entity.Quantity = Convert.ToInt32(numSoluong.Value);
            entity.Status = chbHoatdong.Checked;
            entity.ShowOnHome = chbHienthi.Checked;
            entity.CreatedAt = DateTime.Now;
            entity.CreatedBy = CurrentUser.Username;
            entity.Thumbnail = (existThumbnail.Trim().Length > 0) ? existThumbnail : null;

            StringBuilder sb = new StringBuilder();
            sb.Append("<detail>");
            for (int i = 0; i < gvDescription.Rows.Count - 1; i++)
                sb.Append(String.Format("<item title='{0}'>{1}</item>",
                    gvDescription.Rows[i].Cells[0].Value.ToString(),
                    gvDescription.Rows[i].Cells[1].Value.ToString()));
            sb.Append("</detail>");

            entity.Description = sb.ToString();
            XElement xmlTree = XElement.Parse(sb.ToString());
            //entity.DescriptionXML = xmlTree;
        }

        private void picThumbnail_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            dialog.Multiselect = false;
            DialogResult rs = dialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                filename = dialog.FileName;
                picThumbnail.SizeMode = PictureBoxSizeMode.Zoom;
                picThumbnail.Image = Image.FromFile(filename);
            }
        }

        private string UploadImage()
        {
            string url = @"https://api.imgur.com/3/image";
            string key = @"Client-ID 453ed82ac0c751b";
            WebRequest req = WebRequest.Create(url);
            req.Headers.Add(HttpRequestHeader.Authorization, key);
            req.Method = "POST";
            byte[] data = File.ReadAllBytes(filename);
            using (var stream = req.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)req.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            JObject json = JObject.Parse(responseString);
            string link = json["data"]["link"].ToString();
            return link;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCategory frm = new AddCategory();
            frm.Show();
            frm.FormClosed += frm_FormClosed;
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbLoai.DataSource = null;
            initLoaiSP();
            cbLoai.SelectedIndex = cbLoai.Items.Count - 1;
        }

        private void threadLoadImage_DoWork(object sender, DoWorkEventArgs e)
        {
            picThumbnail.Load(e.Argument.ToString());
        }

        private void threadUpload_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void threadUpload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }
    }
}
