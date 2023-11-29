using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using MySql.Data.MySqlClient;
using DTO;
using Mysqlx.Crud;
using System.Xml.Linq;

namespace Shop_QuanAo
{
    public partial class ctrl_DangNhap : UserControl
    {
        public string mail;
        employeeBLL emp = new employeeBLL();
        public ctrl_DangNhap()
        {
            InitializeComponent();
        }


        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string matkhau = txt_password.Text;
            if (email.Trim() == "")
                MessageBox.Show("bạn chưa nhập email");
            else if (matkhau.Trim() == "")
                MessageBox.Show("bạn chưa nhập mật khẩu");
            else
            {
                var kt = emp.KT_dangnhap(email, matkhau);
                if (kt == false)
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                else
                {
                    bool admin = emp.KT_admin(email, matkhau);
                    frm_TrangChu frm = new frm_TrangChu(email, admin);
                    frm.ShowDialog();
                }

            }
        }
    }
}
