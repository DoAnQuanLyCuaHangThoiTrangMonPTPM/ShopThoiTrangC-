using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Shop_QuanAo
{
    public partial class frm_NhanVien : Form
    {
        employeeBLL emp = new employeeBLL();
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            load();
            load_quyen();
            dgv_nhanvien.DataSource = emp.loadNhanVien();
        }
        private void load_quyen()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("maquyen");
            dt.Columns.Add("tenquyen");
            DataRow row = dt.NewRow();
            row["maquyen"] = "false";
            row["tenquyen"] = "user";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["maquyen"] = "true";
            row["tenquyen"] = "admin";
            dt.Rows.Add(row);
            cbo_quyen.DataSource = dt;
            cbo_quyen.DisplayMember = "tenquyen";
            cbo_quyen.ValueMember = "maquyen";
        }

        private void load()
        {
            txt_email.Enabled = false;
            txt_manv.Enabled = false;
            txt_tennv.Enabled = false;
            txt_email.Clear(); txt_manv.Clear(); txt_tennv.Clear();
            cbo_quyen.Enabled = false;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = true;
            btn_luu.Enabled = false;
            btn_thoat.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_email.Enabled = true;
            txt_manv.Enabled = false;
            txt_tennv.Enabled = true;
            cbo_quyen.Enabled = true;
            btn_luu.Enabled = true;
            btn_them.Enabled = false;
            btn_sua.Enabled=true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text != "")
            {
                bool kt = emp.xoa_nhanvien(Int32.Parse(txt_manv.Text));
                if (kt == true)
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                MessageBox.Show("Bạn chưa chọn nhân viên");
            txt_email.Enabled = true;
            txt_manv.Enabled = false;
            txt_tennv.Enabled = true;
            cbo_quyen.Enabled = true;
            btn_luu.Enabled = true;
            frm_NhanVien_Load(sender, e);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_email.Enabled = true;
            txt_manv.Enabled = false;
            txt_tennv.Enabled = true;
            cbo_quyen.Enabled = true;
            btn_luu.Enabled = true;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string ten = txt_tennv.Text;
            string email = txt_email.Text;
            string pass = "123";
            bool quyen = bool.Parse(cbo_quyen.SelectedValue.ToString());
            
            if (btn_them.Enabled == false)
            {
                if(emp.KT_email(email) == false)
                {
                    bool kt = emp.them_nhanvien(ten, email, pass, quyen);
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
                if (txt_manv.Text != "")
                {
                    bool kt = emp.sua_nhanvien(ten, email, quyen, Int32.Parse(txt_manv.Text));
                    if (kt == true)
                        MessageBox.Show("Cập nhật thành công");
                    else
                        MessageBox.Show("Cập nhật không thành công");
                }
                else
                    MessageBox.Show("Bạn chưa chọn nhân viên");
            }
            frm_NhanVien_Load(sender, e);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_nhanvien.Rows[e.RowIndex];
            txt_email.Text = row.Cells["Email"].Value.ToString();
            txt_manv.Text = row.Cells["Id"].Value.ToString();
            txt_tennv.Text = row.Cells["Name"].Value.ToString();
            bool quyen = bool.Parse(row.Cells["IsAdmin"].Value.ToString());
            if (quyen == true)
                cbo_quyen.Text = "admin";
            else
                cbo_quyen.Text="user";

            btn_xoa.Enabled = true;
        }

    }
}
