namespace Shop_QuanAo
{
    partial class frm_DangNhap
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
            this.ctrl_DangNhap1 = new Shop_QuanAo.ctrl_DangNhap();
            this.SuspendLayout();
            // 
            // ctrl_DangNhap1
            // 
            this.ctrl_DangNhap1.Location = new System.Drawing.Point(14, 4);
            this.ctrl_DangNhap1.Name = "ctrl_DangNhap1";
            this.ctrl_DangNhap1.Size = new System.Drawing.Size(425, 522);
            this.ctrl_DangNhap1.TabIndex = 0;
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 538);
            this.Controls.Add(this.ctrl_DangNhap1);
            this.Name = "frm_DangNhap";
            this.Text = "Shop Quần Áo";
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrl_DangNhap ctrl_DangNhap1;
    }
}