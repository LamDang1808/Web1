namespace DoAn1_Nhom5
{
    partial class btHienThi
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
            System.Windows.Forms.Button btSua;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmbn = new System.Windows.Forms.TextBox();
            this.txtht = new System.Windows.Forms.TextBox();
            this.txtgt = new System.Windows.Forms.TextBox();
            this.txtttb = new System.Windows.Forms.TextBox();
            this.txtthuoc = new System.Windows.Forms.TextBox();
            this.txtgc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.dtns = new System.Windows.Forms.DateTimePicker();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinhBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoiTuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSua
            // 
            btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            btSua.Location = new System.Drawing.Point(913, 196);
            btSua.Name = "btSua";
            btSua.Size = new System.Drawing.Size(128, 29);
            btSua.TabIndex = 18;
            btSua.Text = "Sửa Thông Tin";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Thông Tin Bệnh Nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Bệnh Nhân: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(21, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Và Tên: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(21, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(21, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(21, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tình Trạng Bệnh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(21, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thuốc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(21, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ghi Chú:";
            // 
            // txtmbn
            // 
            this.txtmbn.Location = new System.Drawing.Point(138, 62);
            this.txtmbn.Multiline = true;
            this.txtmbn.Name = "txtmbn";
            this.txtmbn.Size = new System.Drawing.Size(586, 25);
            this.txtmbn.TabIndex = 8;
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(138, 120);
            this.txtht.Multiline = true;
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(586, 25);
            this.txtht.TabIndex = 9;
            // 
            // txtgt
            // 
            this.txtgt.Location = new System.Drawing.Point(138, 178);
            this.txtgt.Multiline = true;
            this.txtgt.Name = "txtgt";
            this.txtgt.Size = new System.Drawing.Size(586, 25);
            this.txtgt.TabIndex = 10;
            // 
            // txtttb
            // 
            this.txtttb.Location = new System.Drawing.Point(138, 289);
            this.txtttb.Multiline = true;
            this.txtttb.Name = "txtttb";
            this.txtttb.Size = new System.Drawing.Size(586, 25);
            this.txtttb.TabIndex = 12;
            // 
            // txtthuoc
            // 
            this.txtthuoc.Location = new System.Drawing.Point(138, 463);
            this.txtthuoc.Multiline = true;
            this.txtthuoc.Name = "txtthuoc";
            this.txtthuoc.Size = new System.Drawing.Size(586, 25);
            this.txtthuoc.TabIndex = 13;
            // 
            // txtgc
            // 
            this.txtgc.Location = new System.Drawing.Point(138, 521);
            this.txtgc.Multiline = true;
            this.txtgc.Name = "txtgc";
            this.txtgc.Size = new System.Drawing.Size(586, 25);
            this.txtgc.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBN,
            this.HoTenBN,
            this.GioiTinhBN,
            this.NgaySinh,
            this.TinhTrangBenh,
            this.DiaChi,
            this.DoiTuong,
            this.Thuoc,
            this.GhiChu});
            this.dataGridView1.Location = new System.Drawing.Point(86, 567);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(942, 332);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(913, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Hiển Thị Dữ Liệu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.Location = new System.Drawing.Point(913, 132);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(128, 29);
            this.btThem.TabIndex = 17;
            this.btThem.Text = "Thêm Bệnh Nhân";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Location = new System.Drawing.Point(913, 260);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(128, 29);
            this.btXoa.TabIndex = 19;
            this.btXoa.Text = "Xóa Bệnh Nhân";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // dtns
            // 
            this.dtns.Location = new System.Drawing.Point(138, 236);
            this.dtns.Name = "dtns";
            this.dtns.Size = new System.Drawing.Size(586, 20);
            this.dtns.TabIndex = 21;
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(138, 347);
            this.txtdc.Multiline = true;
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(586, 25);
            this.txtdc.TabIndex = 25;
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(138, 405);
            this.txtdt.Multiline = true;
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(586, 25);
            this.txtdt.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(21, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Địa Chỉ: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(21, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Đối Tượng: ";
            // 
            // MaBN
            // 
            this.MaBN.DataPropertyName = "MaBN";
            this.MaBN.HeaderText = "Mã Bệnh Nhân";
            this.MaBN.Name = "MaBN";
            // 
            // HoTenBN
            // 
            this.HoTenBN.DataPropertyName = "HoTenBN";
            this.HoTenBN.HeaderText = "Họ Tên";
            this.HoTenBN.Name = "HoTenBN";
            // 
            // GioiTinhBN
            // 
            this.GioiTinhBN.DataPropertyName = "GioiTinhBN";
            this.GioiTinhBN.HeaderText = "Giới Tính";
            this.GioiTinhBN.Name = "GioiTinhBN";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // TinhTrangBenh
            // 
            this.TinhTrangBenh.DataPropertyName = "TinhTrangBenh";
            this.TinhTrangBenh.HeaderText = "Tình Trạng Bệnh";
            this.TinhTrangBenh.Name = "TinhTrangBenh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // DoiTuong
            // 
            this.DoiTuong.DataPropertyName = "DoiTuong";
            this.DoiTuong.HeaderText = "Đối Tượng";
            this.DoiTuong.Name = "DoiTuong";
            // 
            // Thuoc
            // 
            this.Thuoc.DataPropertyName = "Thuoc";
            this.Thuoc.HeaderText = "Thuốc";
            this.Thuoc.Name = "Thuoc";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // btHienThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 911);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.txtdt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtns);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtgc);
            this.Controls.Add(this.txtthuoc);
            this.Controls.Add(this.txtttb);
            this.Controls.Add(this.txtgt);
            this.Controls.Add(this.txtht);
            this.Controls.Add(this.txtmbn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "btHienThi";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmbn;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.TextBox txtgt;
        private System.Windows.Forms.TextBox txtttb;
        private System.Windows.Forms.TextBox txtthuoc;
        private System.Windows.Forms.TextBox txtgc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DateTimePicker dtns;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinhBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoiTuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}

