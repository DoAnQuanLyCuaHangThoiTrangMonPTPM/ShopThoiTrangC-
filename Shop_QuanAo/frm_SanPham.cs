using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Shop_QuanAo
{
    public partial class frm_SanPham : Form
    {
        sizeBLL size = new sizeBLL();
        productsBLL products = new productsBLL();
        categoryBLL categoryBLL = new categoryBLL();
        string img = "";
        public frm_SanPham()
        {
            InitializeComponent();
        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            load();
            dgv_product.DataSource = products.loadSanPham();
            cbo_loai.DataSource = categoryBLL.loadCategory();
            cbo_loai.DisplayMember = "Categry_Name";
            cbo_loai.ValueMember = "Id";
        }
        private void load()
        {
            txt_gia.Enabled = false;
            txt_ma.Enabled = false;
            txt_mota.Enabled = false;
            txt_size.Enabled = false;
            txt_soluong.Enabled = false; 
            txt_ten.Enabled = false;
            cbo_loai.Enabled = false;
            cbo_S.Enabled = true;
            txt_gia.Clear(); txt_ma.Clear(); txt_mota.Clear();
            txt_size.Clear(); txt_soluong.Clear(); txt_ten.Clear();
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = true;
            btn_luu.Enabled = false;
            btn_themsize.Enabled = true;
            btn_xoasize.Enabled = true;
            btn_suasize.Enabled = true;
            btn_luusize.Enabled = false;
            btn_thoat.Enabled = true;
        }


        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_product.Rows[e.RowIndex];
            txt_ma.Text = row.Cells["Id"].Value.ToString();
            txt_ten.Text = row.Cells["Name"].Value.ToString();
            txt_gia.Text = row.Cells["Price"].Value.ToString();
            txt_mota.Text = row.Cells["Description"].Value.ToString();
            cbo_loai.Text = row.Cells["Categry_Name"].Value.ToString();
            img = row.Cells["Image"].Value.ToString();
            pictureBox_sanpham.Image = new Bitmap(@"..\..\..\..\image\" + row.Cells["image"].Value.ToString());
            pictureBox_sanpham.SizeMode = PictureBoxSizeMode.StretchImage;
            cbo_S.DataSource = size.loadSizeTheoSP(Int32.Parse(row.Cells["Id"].Value.ToString()));
            cbo_S.DisplayMember = "Size_Name";
            cbo_S.ValueMember = "Size_Name";
            txt_soluong.Text = size.loadSoLuong(Int32.Parse(txt_ma.Text), cbo_S.Text).ToString();
            btn_xoa.Enabled = true;
        }

        private void cbo_S_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_soluong.Text = size.loadSoLuong(Int32.Parse(txt_ma.Text), cbo_S.Text).ToString();
        }
        public string luu_anh()
        {
            string fileName = "image.jpg";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files |*.png;*.jpg;*.jpeg;*.gif";
                openFileDialog.Title = "Chọn ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Lấy đường dẫn tập tin được chọn
                        string selectedFilePath = openFileDialog.FileName;

                        // Đường dẫn đến thư mục hình ảnh của bạn
                        string destinationFolderPath = Path.Combine(Application.StartupPath, @"..\..\..\..\image");

                        // Kiểm tra thư mục có tồn tại
                        if (!Directory.Exists(destinationFolderPath))
                        {
                            Directory.CreateDirectory(destinationFolderPath);
                        }

                        int i = 1;
                        // Đường dẫn đầy đủ đến thư mục đích
                        string destinationFilePath = Path.Combine(destinationFolderPath, fileName);
                        while (File.Exists(destinationFilePath))
                        {
                            fileName = "image-" + i + ".jpg";
                            destinationFilePath = Path.Combine(destinationFolderPath, fileName);
                            i++;
                        }
                        // Kiểm tra xem tập tin đã tồn tại trong thư mục chưa
                        if (File.Exists(destinationFilePath))
                        {
                            MessageBox.Show("File already exists in the destination folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // Sao chép tập tin vào thư mục đích
                            File.Copy(selectedFilePath, destinationFilePath);

                            MessageBox.Show("Image added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return fileName;
        }

        //public void xoa_anh(string fileName)
        //{
        //    try
        //    {
        //        // Lấy đường dẫn tập tin được chọn
        //        string destinationFolderPath = Path.Combine(Application.StartupPath, @"..\..\..\..\image");

        //        // Đường dẫn đầy đủ đến thư mục đích
        //        string destinationFilePath = Path.Combine(destinationFolderPath, fileName);

        //        // Kiểm tra xem tập tin có tồn tại không
        //        if (File.Exists(destinationFilePath))
        //        {
        //            // Xóa tập tin khỏi thư mục
        //            File.Delete(destinationFilePath);

        //            MessageBox.Show("Image removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Selected image does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_gia.Clear(); txt_ma.Clear(); txt_mota.Clear();
            txt_ten.Clear();
            txt_gia.Enabled = true;
            txt_ma.Enabled = false;
            txt_mota.Enabled = true;
            txt_ten.Enabled = true;
            cbo_loai.Enabled = true;
            btn_luu.Enabled = true;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = Int32.Parse(txt_ma.Text);
            if (id == 0 || img == "")
            {
                MessageBox.Show("bạn chưa chọn sản phẩm để xóa");
                return;
            }
            size.delete_size_cua_sp(id);
            bool kq = products.delete_product(id);
            if (kq)
                MessageBox.Show("Xoa thành công");
            else
                MessageBox.Show("Xoa thành công");
            //xoa_anh(img);
            txt_gia.Enabled = true;
            txt_ma.Enabled = false;
            txt_mota.Enabled = true;
            txt_ten.Enabled = true;
            cbo_loai.Enabled = true;
            btn_luu.Enabled = true;
            frm_SanPham_Load(sender, e);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_gia.Enabled = true;
            txt_ma.Enabled = false;
            txt_mota.Enabled = true;
            txt_ten.Enabled = true;
            cbo_loai.Enabled = true;
            btn_luu.Enabled = true;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

            if (btn_them.Enabled == false)
            {
                string name = ""; name = txt_ten.Text;
                string descripttion = ""; descripttion = txt_mota.Text;
                double price = 0; price = double.Parse(txt_gia.Text);
                string image = ""; image = luu_anh();
                int categoryid = 0; categoryid = Int32.Parse(cbo_loai.SelectedValue.ToString());

                if (name != null && descripttion != null && price != 0 && image !=null && categoryid != 0)
                {
                    bool kt = products.new_product(name, descripttion, price, image, categoryid);
                    if (kt == true)
                        MessageBox.Show("Thêm sản phẩm thành công");
                    else
                        MessageBox.Show("Thêm không thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
            }
            else
            {
                int id = 0; id = Int32.Parse(txt_ma.Text);
                string name = ""; name = txt_ten.Text;
                string descripttion = ""; descripttion = txt_mota.Text;
                double price = 0; price = double.Parse(txt_gia.Text);
                int categoryid = 0; categoryid = Int32.Parse(cbo_loai.SelectedValue.ToString());
                string image = ""; 

                DialogResult result = MessageBox.Show("Bạn muốn thay đổi hình ảnh sản phẩm không", "Message", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    
                    image = luu_anh();

                    if (name != null && descripttion != null && price != 0 && image != "" && categoryid != 0 && id != 0)
                    {
                        bool kt = products.edit_product(name, descripttion, price, image, categoryid, id);
                        //pictureBox_sanpham.Image = new Bitmap(@"..\..\..\..\image\" + image);
                        //pictureBox_sanpham.SizeMode = PictureBoxSizeMode.StretchImage;
                        //xoa_anh(img);
                        if (kt == true)
                            MessageBox.Show("Sửa sản phẩm thành công");
                        else
                            MessageBox.Show("Sửa không thành công");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    }
                }
                else
                {
                    if (name != null && descripttion != null && price != 0 && img != "" && categoryid != 0 && id != 0)
                    {
                        bool kt = products.edit_product(name, descripttion, price, img, categoryid, id);
                        if (kt == true)
                            MessageBox.Show("Sửa sản phẩm thành công");
                        else
                            MessageBox.Show("Sửa không thành công");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    }
                }

            }
            frm_SanPham_Load(sender, e);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_themsize_Click(object sender, EventArgs e)
        {
            txt_size.Enabled = true;
            txt_soluong.Enabled = true;
            btn_luusize.Enabled = true;
            btn_themsize.Enabled = false;
            btn_suasize.Enabled = true;
        }

        private void btn_xoasize_Click(object sender, EventArgs e)
        {
            int productid = 0;
            productid = Int32.Parse(cbo_S.SelectedValue.ToString());
            string size_name = "";
            size_name = txt_size.Text;
            if(productid != 0 && size_name != "")
            {
                size.delete_size(productid, size_name);
            }
            else
            {
                MessageBox.Show("bạn cần chọn sản phẩm size để xóa");
                return;
            }
            txt_size.Enabled = true;
            txt_soluong.Enabled = true;
            btn_luusize.Enabled = true;
            frm_SanPham_Load(sender, e);
        }

        private void btn_suasize_Click(object sender, EventArgs e)
        {
            txt_size.Enabled = true;
            txt_soluong.Enabled = true;
            btn_luusize.Enabled = true;
            btn_suasize.Enabled = false;
            btn_themsize.Enabled = true;
        }

        private void btn_luusize_Click(object sender, EventArgs e)
        {
            if (txt_ma.Text != "" && txt_size.Text != "" && txt_soluong.Text != "")
            {
                if (btn_themsize.Enabled == false)
                {
                    int productid = 0;
                    productid = Int32.Parse(txt_ma.Text);
                    string size_name = "";
                    size_name = txt_size.Text;
                    int quantity = 0;
                    quantity = Int32.Parse(txt_soluong.Text);

                    if (productid != 0 && size_name != "" && quantity != 0)
                    {
                        bool kt = size.KT_size(productid, size_name);
                        if (kt)
                        {
                            MessageBox.Show("Size này đã tồn tại");
                            return;
                        }
                        else
                        {
                            bool kq = size.new_size(productid, size_name, quantity);
                            if (kq)
                                MessageBox.Show("Thêm size thành công");
                            else
                                MessageBox.Show("Thêm size không thành công");
                        }
                    }
                    else
                    {
                        MessageBox.Show("bạn cần nhập đầy đủ thông tin để thêm:"+ productid+""+size_name+""+quantity);
                        return;
                    }
                }
                else
                {
                    int productid = 0;
                    productid = Int32.Parse(txt_ma.Text);
                    string size_name = "";
                    size_name = cbo_S.Text;
                    int quantity = 0;
                    if (productid != 0 && size_name != "")
                    {
                        bool kq = size.edit_size(productid, size_name, quantity);
                        if (kq)
                            MessageBox.Show("Cập nhật số lượng thành công");
                        else
                            MessageBox.Show("Cập nhật số lượng không thành công");
                    }
                    else
                    {
                        MessageBox.Show("bạn cần nhập đầy đủ thông tin để thêm");
                        return;
                    }
                }
                frm_SanPham_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
            }

        }

    }
}
