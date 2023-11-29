namespace Shop_QuanAo
{
    partial class frm_SanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.pictureBox_sanpham = new System.Windows.Forms.PictureBox();
            this.cbo_loai = new System.Windows.Forms.ComboBox();
            this.cbo_S = new System.Windows.Forms.ComboBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_size = new System.Windows.Forms.TextBox();
            this.btn_themsize = new System.Windows.Forms.Button();
            this.btn_xoasize = new System.Windows.Forms.Button();
            this.btn_suasize = new System.Windows.Forms.Button();
            this.btn_luusize = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(212, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(636, 69);
            this.label7.TabIndex = 44;
            this.label7.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(881, 538);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(136, 42);
            this.btn_thoat.TabIndex = 39;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(675, 538);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(136, 42);
            this.btn_luu.TabIndex = 40;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(466, 538);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(136, 42);
            this.btn_sua.TabIndex = 41;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(258, 538);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(136, 42);
            this.btn_xoa.TabIndex = 42;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(49, 538);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(136, 42);
            this.btn_them.TabIndex = 43;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_product
            // 
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(44, 294);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.RowHeadersWidth = 51;
            this.dgv_product.RowTemplate.Height = 24;
            this.dgv_product.Size = new System.Drawing.Size(973, 229);
            this.dgv_product.TabIndex = 38;
            this.dgv_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellClick);
            // 
            // pictureBox_sanpham
            // 
            this.pictureBox_sanpham.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_sanpham.Location = new System.Drawing.Point(843, 89);
            this.pictureBox_sanpham.Name = "pictureBox_sanpham";
            this.pictureBox_sanpham.Size = new System.Drawing.Size(174, 149);
            this.pictureBox_sanpham.TabIndex = 37;
            this.pictureBox_sanpham.TabStop = false;

            // 
            // cbo_loai
            // 
            this.cbo_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_loai.FormattingEnabled = true;
            this.cbo_loai.Location = new System.Drawing.Point(623, 89);
            this.cbo_loai.Name = "cbo_loai";
            this.cbo_loai.Size = new System.Drawing.Size(191, 28);
            this.cbo_loai.TabIndex = 36;
            // 
            // cbo_S
            // 
            this.cbo_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_S.FormattingEnabled = true;
            this.cbo_S.Location = new System.Drawing.Point(623, 132);
            this.cbo_S.Name = "cbo_S";
            this.cbo_S.Size = new System.Drawing.Size(191, 28);
            this.cbo_S.TabIndex = 35;
            this.cbo_S.SelectedIndexChanged += new System.EventHandler(this.cbo_S_SelectedIndexChanged);
            // 
            // txt_gia
            // 
            this.txt_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gia.Location = new System.Drawing.Point(224, 218);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(191, 27);
            this.txt_gia.TabIndex = 33;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(623, 173);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(191, 27);
            this.txt_soluong.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(439, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Số Lượng:";
            // 
            // txt_mota
            // 
            this.txt_mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mota.Location = new System.Drawing.Point(224, 176);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(191, 27);
            this.txt_mota.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mô tả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(439, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Size:";
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.Location = new System.Drawing.Point(224, 132);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(191, 27);
            this.txt_ten.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tên Sản Phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(439, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Loại Sản Phẩm:";
            // 
            // txt_ma
            // 
            this.txt_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ma.Location = new System.Drawing.Point(224, 89);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(191, 27);
            this.txt_ma.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(40, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mã Sản Phẩm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(443, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Add Size:";
            // 
            // txt_size
            // 
            this.txt_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_size.Location = new System.Drawing.Point(623, 214);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(191, 27);
            this.txt_size.TabIndex = 32;
            // 
            // btn_themsize
            // 
            this.btn_themsize.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_themsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themsize.ForeColor = System.Drawing.Color.White;
            this.btn_themsize.Location = new System.Drawing.Point(443, 247);
            this.btn_themsize.Name = "btn_themsize";
            this.btn_themsize.Size = new System.Drawing.Size(104, 30);
            this.btn_themsize.TabIndex = 43;
            this.btn_themsize.Text = "Thêm size";
            this.btn_themsize.UseVisualStyleBackColor = false;
            this.btn_themsize.Click += new System.EventHandler(this.btn_themsize_Click);
            // 
            // btn_xoasize
            // 
            this.btn_xoasize.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_xoasize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoasize.ForeColor = System.Drawing.Color.White;
            this.btn_xoasize.Location = new System.Drawing.Point(595, 247);
            this.btn_xoasize.Name = "btn_xoasize";
            this.btn_xoasize.Size = new System.Drawing.Size(104, 30);
            this.btn_xoasize.TabIndex = 42;
            this.btn_xoasize.Text = "Xóa size";
            this.btn_xoasize.UseVisualStyleBackColor = false;
            this.btn_xoasize.Click += new System.EventHandler(this.btn_xoasize_Click);
            // 
            // btn_suasize
            // 
            this.btn_suasize.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_suasize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suasize.ForeColor = System.Drawing.Color.White;
            this.btn_suasize.Location = new System.Drawing.Point(753, 247);
            this.btn_suasize.Name = "btn_suasize";
            this.btn_suasize.Size = new System.Drawing.Size(104, 30);
            this.btn_suasize.TabIndex = 41;
            this.btn_suasize.Text = "Sửa size";
            this.btn_suasize.UseVisualStyleBackColor = false;
            this.btn_suasize.Click += new System.EventHandler(this.btn_suasize_Click);
            // 
            // btn_luusize
            // 
            this.btn_luusize.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_luusize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luusize.ForeColor = System.Drawing.Color.White;
            this.btn_luusize.Location = new System.Drawing.Point(913, 247);
            this.btn_luusize.Name = "btn_luusize";
            this.btn_luusize.Size = new System.Drawing.Size(104, 30);
            this.btn_luusize.TabIndex = 40;
            this.btn_luusize.Text = "Lưu size";
            this.btn_luusize.UseVisualStyleBackColor = false;
            this.btn_luusize.Click += new System.EventHandler(this.btn_luusize_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1057, 590);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_luusize);
            this.Controls.Add(this.btn_suasize);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoasize);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_themsize);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.pictureBox_sanpham);
            this.Controls.Add(this.cbo_loai);
            this.Controls.Add(this.cbo_S);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.txt_size);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label8);
            this.Name = "frm_SanPham";
            this.Text = "frm_SanPham";
            this.Load += new System.EventHandler(this.frm_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.PictureBox pictureBox_sanpham;
        private System.Windows.Forms.ComboBox cbo_loai;
        private System.Windows.Forms.ComboBox cbo_S;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_size;
        private System.Windows.Forms.Button btn_themsize;
        private System.Windows.Forms.Button btn_xoasize;
        private System.Windows.Forms.Button btn_suasize;
        private System.Windows.Forms.Button btn_luusize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}