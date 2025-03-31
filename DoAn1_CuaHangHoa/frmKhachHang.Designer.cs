namespace DoAn1_CuaHangHoa
{
    partial class frmKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grbKhachHang = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.textTim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgKH = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.grbKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 47);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quản lý thông tin khách hàng";
            // 
            // grbKhachHang
            // 
            this.grbKhachHang.BackColor = System.Drawing.Color.White;
            this.grbKhachHang.Controls.Add(this.btnSua);
            this.grbKhachHang.Controls.Add(this.btnXoa);
            this.grbKhachHang.Controls.Add(this.btnXem);
            this.grbKhachHang.Controls.Add(this.btnTimKH);
            this.grbKhachHang.Controls.Add(this.textTim);
            this.grbKhachHang.Controls.Add(this.label8);
            this.grbKhachHang.Controls.Add(this.label3);
            this.grbKhachHang.Controls.Add(this.btnThem);
            this.grbKhachHang.Controls.Add(this.txtSDT);
            this.grbKhachHang.Controls.Add(this.txtDiaChi);
            this.grbKhachHang.Controls.Add(this.txtTenKH);
            this.grbKhachHang.Controls.Add(this.txtMaKH);
            this.grbKhachHang.Controls.Add(this.label4);
            this.grbKhachHang.Controls.Add(this.label2);
            this.grbKhachHang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKhachHang.Location = new System.Drawing.Point(12, 65);
            this.grbKhachHang.Name = "grbKhachHang";
            this.grbKhachHang.Size = new System.Drawing.Size(1177, 184);
            this.grbKhachHang.TabIndex = 0;
            this.grbKhachHang.TabStop = false;
            this.grbKhachHang.Text = "Thông tin khách hàng";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(325, 118);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 35);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(451, 118);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 35);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXem.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnXem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(574, 118);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(87, 35);
            this.btnXem.TabIndex = 17;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            // 
            // btnTimKH
            // 
            this.btnTimKH.BackColor = System.Drawing.Color.Pink;
            this.btnTimKH.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKH.Location = new System.Drawing.Point(970, 118);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(53, 39);
            this.btnTimKH.TabIndex = 16;
            this.btnTimKH.Text = "🔍";
            this.btnTimKH.UseVisualStyleBackColor = false;
            // 
            // textTim
            // 
            this.textTim.Location = new System.Drawing.Point(754, 127);
            this.textTim.Name = "textTim";
            this.textTim.Size = new System.Drawing.Size(210, 26);
            this.textTim.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(631, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(631, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số điện thoại:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(198, 118);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 35);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(754, 18);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(210, 26);
            this.txtSDT.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(754, 60);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(210, 26);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(352, 60);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(210, 26);
            this.txtTenKH.TabIndex = 4;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(352, 18);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(210, 26);
            this.txtMaKH.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng:";
            // 
            // dgKH
            // 
            this.dgKH.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKH.Location = new System.Drawing.Point(13, 256);
            this.dgKH.Name = "dgKH";
            this.dgKH.RowHeadersWidth = 51;
            this.dgKH.RowTemplate.Height = 24;
            this.dgKH.Size = new System.Drawing.Size(1165, 329);
            this.dgKH.TabIndex = 14;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 572);
            this.Controls.Add(this.dgKH);
            this.Controls.Add(this.grbKhachHang);
            this.Controls.Add(this.panel1);
            this.Name = "frmKhachHang";
            this.Text = "Quản lý khách hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbKhachHang.ResumeLayout(false);
            this.grbKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbKhachHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTim;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dgKH;
    }
}