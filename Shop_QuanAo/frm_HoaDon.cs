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
using Aspose.Words;
using Aspose.Words.Tables;


namespace Shop_QuanAo
{
    public partial class frm_HoaDon : Form
    {
        ordersdetailBLL ordersdetailBLL = new ordersdetailBLL();
        ordersBLL ordersBLL = new ordersBLL();
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            dgv_hoadon.DataSource = ordersBLL.loadhoadon();
            load();
            
        }
        private void load()
        {
            txt_dongia.Enabled = false;
            txt_mahd.Enabled = false;
            txt_makh.Enabled = false;
            txt_manv.Enabled = false;
            txt_ngay.Enabled = false;
            txt_sdt.Enabled = false;
            txt_size.Enabled = false;
            txt_soluong.Enabled = false;
            txt_tenkh.Enabled = false;
            txt_tennv.Enabled = false;
            txt_tensp.Enabled = false;
            txt_tongtien.Enabled = false;
            txt_thanhtien.Enabled = false;
        }

        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_hoadon.Rows[e.RowIndex];
            txt_mahd.Text = row.Cells["Id"].Value.ToString();
            txt_ngay.Text = row.Cells["Date"].Value.ToString();
            txt_manv.Text = row.Cells["EmployeeId"].Value.ToString();
            txt_tennv.Text = row.Cells["TenNV"].Value.ToString();
            txt_makh.Text = row.Cells["CustomerId"].Value.ToString();
            txt_tenkh.Text = row.Cells["TenKH"].Value.ToString();
            txt_sdt.Text = row.Cells["Phome"].Value.ToString();
            txt_tongtien.Text = row.Cells["Total"].Value.ToString();
            dgv_chitiethoadon.DataSource = ordersdetailBLL.loadchitiethoadon(Int32.Parse(txt_mahd.Text));
        }

        private void dgv_chitiethoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_chitiethoadon.Rows[e.RowIndex];
            txt_tensp.Text = row.Cells["Name"].Value.ToString();
            txt_size.Text = row.Cells["Size"].Value.ToString();
            txt_soluong.Text = row.Cells["Quantity"].Value.ToString();
            txt_dongia.Text = row.Cells["Price"].Value.ToString();
            float thanhtien = float.Parse(txt_dongia.Text)*float.Parse(txt_soluong.Text);
            txt_thanhtien.Text = thanhtien.ToString();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_tim_ma_hoa_don.Text != "")
            {
                dgv_hoadon.DataSource = ordersBLL.timkiemhoadon(Int32.Parse(txt_tim_ma_hoa_don.Text));
            }
            else
            {
                frm_HoaDon_Load(sender, e);
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            var ngay = DateTime.Parse(txt_ngay.Text);
            //Bước 1: Nạp file mẫu
            Document baoCao = new Document("..\\..\\Template\\Mau_Bao_Cao.doc");

            //Bước 2: Điền các thông tin cố định
            baoCao.MailMerge.Execute(new[] { "ngay" }, new[] { string.Format("TP.HCM, ngày {0} tháng {1} năm {2}", ngay.Day, ngay.Month, ngay.Year) });
            baoCao.MailMerge.Execute(new[] { "tennhanvien" }, new[] { txt_tennv.Text });
            baoCao.MailMerge.Execute(new[] { "tenkhachhang" }, new[] { txt_tenkh.Text });
            baoCao.MailMerge.Execute(new[] { "sdtkhachhang" }, new[] { txt_sdt.Text });
            baoCao.MailMerge.Execute(new[] { "mahoadon" }, new[] { txt_mahd.Text });

            //Bước 3: Điền thông tin lên bảng
            Table bangsanpham = baoCao.GetChild(NodeType.Table, 0, true) as Table;//Lấy bảng thứ 2 trong file mẫu
            int hangHienTai = 1;
            bangsanpham.InsertRows(hangHienTai, hangHienTai, 5);
            int i = 1;
            foreach (DataRow row in ordersdetailBLL.loadchitiethoadon(Int32.Parse(txt_mahd.Text)).Rows)
            {

                bangsanpham.PutValue(hangHienTai, 0, i.ToString());//Cột STT
                bangsanpham.PutValue(hangHienTai, 1, row["Name"].ToString());
                bangsanpham.PutValue(hangHienTai, 2, row["Size"].ToString());
                bangsanpham.PutValue(hangHienTai, 3, row["Quantity"].ToString());
                bangsanpham.PutValue(hangHienTai, 4, row["Price"].ToString());
                float thanhtien = Int32.Parse(row["Quantity"].ToString()) * float.Parse(row["Price"].ToString());
                bangsanpham.PutValue(hangHienTai, 5, thanhtien.ToString());
                hangHienTai++;
                i++;
            }

            baoCao.SaveAndOpenFile("BaoCao.doc");
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
