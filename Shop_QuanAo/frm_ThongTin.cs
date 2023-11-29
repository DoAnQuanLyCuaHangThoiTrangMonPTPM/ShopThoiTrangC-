using BLL;
using DTO;
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
    public partial class frm_ThongTin : Form
    {
        employeeBLL emp = new employeeBLL();
        private string email;
        private int id;
        private string password;
        public frm_ThongTin(string Email) : this()
        {
            email = Email;
        }
        public frm_ThongTin()
        {
            InitializeComponent();
        }

        private void frm_ThongTin_Load(object sender, EventArgs e)
        {
            LoadTenNV();
            btn_doi.Enabled = true;
            btn_luu.Enabled = false;
            txt_mkcu.Enabled = false;
            txt_mkmoi.Enabled = false;
            txt_xacnhan.Enabled = false;
        }

        private void LoadTenNV()
        {
            List<employee> list = new List<employee>();
            list = emp.Thongtin1nv(email);
            foreach (employee item in list)
            {
                id = item.Id;
                password = item.Password;
                lbl_hoten.Text = item.Name;
                lbl_email.Text = item.Email;
                if (item.IsAdmin == true)
                    lbl_quyen.Text = "admin";
                else
                    lbl_quyen.Text = "user";
            }
        }

        private void btn_doi_Click(object sender, EventArgs e)
        {
            btn_doi.Enabled = false;
            btn_luu.Enabled = true;
            txt_mkcu.Enabled = true;
            txt_mkmoi.Enabled = true;
            txt_xacnhan.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(txt_xacnhan.Text != "" && txt_mkmoi.Text != "" && txt_mkcu.Text != "")
            {
                if (txt_mkcu.Text == password)
                {
                    if (txt_mkmoi.Text == txt_xacnhan.Text)
                    {
                        emp.capnhatmatkhau(txt_mkmoi.Text, id);
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                        MessageBox.Show("Xác nhận mật khẩu không chính xác");
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }

            txt_xacnhan.Text = txt_mkmoi.Text = txt_mkcu.Text = "";
            btn_doi.Enabled = true;
            btn_luu.Enabled = false;
            txt_mkcu.Enabled = false;
            txt_mkmoi.Enabled = false;
            txt_xacnhan.Enabled = false;
        }

    }
}
