using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shop_QuanAo
{
    public partial class frm_KhachHang : Form
    {
        customerBLL customer = new customerBLL();
        public frm_KhachHang()
        {
            InitializeComponent();
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            load();
            dgv_khachhang.DataSource = customer.loadKhachHang();
        }
        private void load()
        {
            txt_email.Enabled = false;
            txt_makh.Enabled = false;
            txt_tenkh.Enabled = false;
            txt_sdt.Enabled = false;
            txt_email.Clear(); 
            txt_makh.Clear(); 
            txt_tenkh.Clear();
            txt_sdt.Clear();
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = true;
            btn_luu.Enabled = false;
            btn_thoat.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_email.Enabled = true;
            txt_makh.Enabled = false;
            txt_tenkh.Enabled = true;
            txt_sdt.Enabled = true;
            btn_luu.Enabled = true;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text != "")
            {
                bool kt = customer.xoa_khachhang(Int32.Parse(txt_makh.Text));
                if (kt == true)
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                MessageBox.Show("Bạn chưa chọn khách hàng");
            txt_email.Enabled = true;
            txt_makh.Enabled = false;
            txt_tenkh.Enabled = true;
            txt_sdt.Enabled = true;
            btn_luu.Enabled = true;
            frm_KhachHang_Load(sender, e);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_email.Enabled = true;
            txt_makh.Enabled = false;
            txt_tenkh.Enabled = true;
            txt_sdt.Enabled = true;
            btn_luu.Enabled = true;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string ten = txt_tenkh.Text;
            string email = txt_email.Text;
            string sdt = txt_sdt.Text;

            if (btn_them.Enabled == false)
            {
                if (customer.KT_email(email) == false)
                {
                    bool kt = customer.them_khachhang(ten, email, sdt);
                    if (kt == true)
                        MessageBox.Show("Thêm thành công");
                    else
                        MessageBox.Show("Thêm không thành công");
                }
                else
                {
                    MessageBox.Show("Đã tồn tại email");
                }
            }
            else
            {
                if (txt_makh.Text != "")
                {
                    bool kt = customer.sua_khachhang(ten, email, sdt, Int32.Parse(txt_makh.Text));
                    if (kt == true)
                        MessageBox.Show("Cập nhật thành công");
                    else
                        MessageBox.Show("Cập nhật không thành công");
                }
                else
                    MessageBox.Show("Bạn chưa chọn nhân viên");
            }
            frm_KhachHang_Load(sender, e);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_khachhang.Rows[e.RowIndex];
            txt_email.Text = row.Cells["Email"].Value.ToString();
            txt_makh.Text = row.Cells["Id"].Value.ToString();
            txt_tenkh.Text = row.Cells["Name"].Value.ToString();
            txt_sdt.Text = row.Cells["Phome"].Value.ToString();
            btn_xoa.Enabled = true;
        }
    }
}
