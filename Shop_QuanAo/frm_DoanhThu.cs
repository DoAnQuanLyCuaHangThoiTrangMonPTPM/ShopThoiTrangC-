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
    public partial class frm_DoanhThu : Form
    {
        ordersBLL ordersBLL = new ordersBLL();
        public frm_DoanhThu()
        {
            InitializeComponent();
        }

        private void frm_DoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void txt_nam_TextChanged(object sender, EventArgs e)
        {
            if(txt_nam.Text != "")
            {
                DataTable dt_HD = ordersBLL.HD_Thang(Int32.Parse(txt_nam.Text));
                try
                {
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                    chart1.ChartAreas["ChartArea1"].AxisY.Title = "VND";
                    for (int i = 0; i < dt_HD.Rows.Count; i++)
                    {
                        int thang = Int32.Parse(dt_HD.Rows[i]["Month"].ToString());

                        chart1.Series["Tổng Tiền"].Points.AddXY(thang, dt_HD.Rows[i]["Total"]);
                    }
                    chart1.Series["Tổng Tiền"].IsValueShownAsLabel = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
