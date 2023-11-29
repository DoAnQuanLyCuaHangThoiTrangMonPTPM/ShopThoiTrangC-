
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DTO;
using MySql.Data.MySqlClient;

namespace Shop_QuanAo
{
    public partial class frm_TrangChu : Form
    {
        ordersdetailBLL ordersdetailBLL = new ordersdetailBLL();
        ordersBLL ordersBLL = new ordersBLL();
        sizeBLL size = new sizeBLL();
        employeeBLL emp = new employeeBLL();
        customerBLL customer = new customerBLL();
        productsBLL products = new productsBLL();
        cartBLL cart = new cartBLL();
        DataTable dt = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private string SIZE = "";
        private string email;
        private bool admin;
        public frm_TrangChu(string Email, bool Admin) : this()
        {
            email = Email;
            admin = Admin;
        }
        public frm_TrangChu()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_body.Controls.Add(childForm);
            pn_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_BanQuanAo_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            color();
            btn_BanQuanAo.BackColor = Color.SteelBlue;
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_DoanhThu());
            color();
            btn_DoanhThu.BackColor = Color.SteelBlue;
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_SanPham());
            color();
            btn_SanPham.BackColor = Color.SteelBlue;
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_HoaDon());
            color();
            btn_HoaDon.BackColor = Color.SteelBlue;
        }


        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_NhanVien());
            color();
            btn_NhanVien.BackColor = Color.SteelBlue;
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_KhachHang());
            color();
            btn_KhachHang.BackColor = Color.SteelBlue;
        }

        private void btn_ThietLap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ThongTin(email));
            color();
            btn_ThietLap.BackColor = Color.SteelBlue;
        }
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            frm_DangNhap frm = new frm_DangNhap();
            this.Hide();
            frm.ShowDialog();
        }

        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
            loadgiohang();
            dgv_sanpham.DataSource = products.loadSanPham();
            load();
            LoadTenNV();
            btn_BanQuanAo.BackColor = Color.SteelBlue;
        }
        private void loadgiohang()
        {

            if (txt_idKH.Text != "")
            {
                double tongtien = 0;

                int customerid = Int32.Parse(txt_idKH.Text);
                dgv_giohang.DataSource = cart.loadcart(customerid);
                foreach(DataRow row in cart.loadcart(customerid).Rows)
                {
                    tongtien = tongtien + double.Parse(row["Quantity"].ToString()) * double.Parse(row["Price"].ToString());
                }
                lbl_tongtien.Text = tongtien.ToString();
            }
            else
            {
                int customerid = 0;
                dgv_giohang.DataSource = cart.loadcart(customerid);
            }
            
        }
        private void load()
        {
            txt_gia.Enabled = false;
            txt_tensp.Enabled = true;
            txt_tenkh.Enabled = false;
            txt_id.Enabled = false;
            btn_luu.Enabled = false;
            txt_idKH.Enabled = false;
            txt_soluongcart.Enabled = false;
            txt_maspcart.Enabled = false;
            if (!admin)
            {
                btn_DoanhThu.Visible = false;
                btn_SanPham.Visible = false;
                btn_HoaDon.Visible = false;
                btn_KhachHang.Visible = false;
                btn_NhanVien.Visible = false;
            }
        }
        private void LoadTenNV()
        {
            List<employee> list = new List<employee>();
            list = emp.Thongtin1nv(email);
            foreach (employee item in list)
            {
                lbl_ten.Text = item.Name;
                lbl_ngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
                if(item.IsAdmin == true)
                    lbl_quyen.Text = "admin";
                else
                    lbl_quyen.Text = "user";
            }
        }
        private void color()
        {
            btn_ThietLap.BackColor = Color.DeepSkyBlue;
            btn_KhachHang.BackColor = Color.DeepSkyBlue;
            btn_NhanVien.BackColor = Color.DeepSkyBlue;
            btn_DangXuat.BackColor = Color.DeepSkyBlue;
            btn_HoaDon.BackColor = Color.DeepSkyBlue;
            btn_SanPham.BackColor = Color.DeepSkyBlue;
            btn_DoanhThu.BackColor = Color.DeepSkyBlue;
            btn_BanQuanAo.BackColor = Color.DeepSkyBlue;
        }

        private void dgv_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_sanpham.Rows[e.RowIndex];
            txt_id.Text = row.Cells["Id"].Value.ToString();
            txt_tensp.Text = row.Cells["Name"].Value.ToString();
            txt_gia.Text = row.Cells["Price"].Value.ToString();
            pictureBox_sanpham.Image = new Bitmap(@"..\..\..\..\image\" + row.Cells["image"].Value.ToString());
            pictureBox_sanpham.SizeMode = PictureBoxSizeMode.StretchImage;
            cbo_size.DataSource = size.loadSizeTheoSP(Int32.Parse(txt_id.Text));
            cbo_size.DisplayMember = "Size_Name";
            cbo_size.ValueMember = "Size_Name";

        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            List<customer> list = new List<customer>();
            list = customer.Thongtin1kh(txt_sdt.Text);
            if (txt_sdt.Text != "")
            {
                foreach (customer item in list)
                {
                    txt_tenkh.Text = item.Name;
                    txt_idKH.Text = item.Id.ToString();
                }
            }
            else
            {
                txt_idKH.Text = "";
                txt_tenkh.Text = "";
            }
            loadgiohang();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_tenkh.Enabled = true;
            btn_luu.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            txt_tenkh.Enabled = false;
            btn_luu.Enabled = false;
            if(txt_sdt.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại");
                return;
            }
            else if (txt_tenkh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng");
                return;
            }
            else
            {
                bool kt = customer.ThemKH(txt_tenkh.Text, txt_sdt.Text);
                if(kt)
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Không thành công");
            }
            txt_sdt_TextChanged(sender, e);
        }

        private void btn_themgiohang_Click(object sender, EventArgs e)
        {
            if(txt_idKH.Text == "")
            {
                MessageBox.Show("Chưa có thông tin khách hàng");
                return;
            }    
            else if(txt_id.Text == "" || txt_gia.Text == "")
            {
                MessageBox.Show("Chưa chọn sản phẩm");
                return;
            }
            else if(cbo_size.Text == "")
            {
                MessageBox.Show("Chưa chọn size");
                return;
            }
            else
            {
                int customerid = Int32.Parse(txt_idKH.Text);
                int productid = Int32.Parse(txt_id.Text);
                int quantity = 1;
                string size = cbo_size.Text;
                int quan = 0;

                List<cart> list = new List<cart>();
                list = cart.Thongtin1sptrongcart(productid, size, customerid);
                foreach (cart item in list)
                {
                    quan = item.Quantity;
                }

                if(quan == 0)
                {
                    //MessageBox.Show(quan +" Thêm");
                    cart.addcart(customerid, productid, size, quantity);
                }
                else
                {
                    //MessageBox.Show(quan +" Update");
                    quan += 1;
                    cart.capnhatsoluong(productid, quan, customerid, size);
                }

                
            }
            loadgiohang();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(txt_maspcart.Text == "" || SIZE == "")
            {
                MessageBox.Show("Bạn chưa chọn sản phâm để xóa");
                return ;
            }
            else
            {
                int customerid = Int32.Parse(txt_idKH.Text);
                int productid = Int32.Parse(txt_maspcart.Text);
                cart.XoaSPCart(productid, customerid, SIZE);
                loadgiohang();
                txt_maspcart.Text = "";
                txt_soluongcart.Text = "";
                SIZE = "";
            }

        }

        private void btn_luucart_Click(object sender, EventArgs e)
        {
            if (txt_maspcart.Text == "" || SIZE == "")
            {
                MessageBox.Show("Bạn chưa chọn sản phâm để cập nhật");
                return;
            }
            else
            {
                int customerid = Int32.Parse(txt_idKH.Text);
                int productid = Int32.Parse(txt_maspcart.Text);
                int quantity = Int32.Parse(txt_soluongcart.Value.ToString());
                cart.capnhatsoluong(productid, quantity, customerid, SIZE);
                loadgiohang();
                txt_maspcart.Text = "";
                txt_soluongcart.Text = "";
                SIZE = "";
            }

        }

        private void dgv_giohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_giohang.Rows[e.RowIndex];
            txt_maspcart.Text = row.Cells["ProductId"].Value.ToString();
            txt_soluongcart.Text = row.Cells["Quantity"].Value.ToString();
            txt_soluongcart.Enabled = true;
            SIZE = row.Cells["Size"].Value.ToString();
        }

        private void btn_empty_Click(object sender, EventArgs e)
        {
            if(txt_idKH.Text != "")
            {
                int customerid = Int32.Parse(txt_idKH.Text);
                cart.EmptyCart(customerid);
                loadgiohang();
            }

        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            int orderid = 0;
            int customerid = Int32.Parse(txt_idKH.Text);
            int employeeid = 0;
            double total = Int32.Parse(lbl_tongtien.Text);
            if (txt_idKH.Text == null)
            {
                MessageBox.Show("Chưa có thông tin khách hàng");
                return;
            }


            //Lấy mã nhân viên
            List<employee> listemp = new List<employee>();
            listemp = emp.Thongtin1nv(email);
            foreach (employee item in listemp)
            {
                employeeid = item.Id;
            }

            //Thêm hóa đơn mới
            ordersBLL.new_orders(customerid, employeeid, total);

            //Tìm id của hóa đơn vừa thêm
            List<orders> list = new List<orders>();
            list = ordersBLL.Last_Id();
            foreach (orders item in list)
            {
                orderid = item.Id;
            }

            //Thêm từng sản phẩm vào chi tiết hóa đơn
            foreach (DataRow row in cart.loadcart(customerid).Rows)
            {
                int productid = 0;
                string size = "";
                double price = 0;
                int quantity = 0;

                productid = int.Parse(row["ProductId"].ToString());
                size = row["Size"].ToString();
                quantity = int.Parse(row["Quantity"].ToString());
                price = double.Parse(row["Price"].ToString());
                if(orderid != 0 && productid != 0 && size != "" &&  price != 0 && quantity != 0)
                {
                    ordersdetailBLL.new_ordersdetail(orderid, productid, size, price, quantity);
                }
            }
            btn_empty_Click(sender, e);

        }

        private void txt_tim_TextChanged(object sender, EventArgs e)
        {
            dgv_sanpham.DataSource = products.loadSanPhamTheoTen(txt_tim.Text);
        }

        private void btn_goi_y_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmr_AI_Goi_Y());
            color();
            btn_goi_y.BackColor = Color.SteelBlue;
        }
    }
}
