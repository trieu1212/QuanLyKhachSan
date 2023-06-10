namespace QuanLyKhachSan
{
    partial class hoadon
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.lbltenphong = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblngaythanhtoan = new System.Windows.Forms.Label();
            this.txttenkhachhang = new System.Windows.Forms.TextBox();
            this.lbltenkhach = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btntrigia = new System.Windows.Forms.Button();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLKSDataSet = new QuanLyKhachSan.QLKSDataSet();
            this.qLKSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.txttenphong);
            this.groupBox1.Controls.Add(this.lbltenphong);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phòng Thanh Toán";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(269, 124);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(95, 51);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(125, 44);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(220, 31);
            this.txttenphong.TabIndex = 1;
            // 
            // lbltenphong
            // 
            this.lbltenphong.AutoSize = true;
            this.lbltenphong.Location = new System.Drawing.Point(7, 44);
            this.lbltenphong.Name = "lbltenphong";
            this.lbltenphong.Size = new System.Drawing.Size(112, 23);
            this.lbltenphong.TabIndex = 0;
            this.lbltenphong.Text = "Tên phòng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.lblngaythanhtoan);
            this.groupBox2.Controls.Add(this.txttenkhachhang);
            this.groupBox2.Controls.Add(this.lbltenkhach);
            this.groupBox2.Location = new System.Drawing.Point(436, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Khách Thanh Toán";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(195, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(372, 31);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lblngaythanhtoan
            // 
            this.lblngaythanhtoan.AutoSize = true;
            this.lblngaythanhtoan.Location = new System.Drawing.Point(24, 111);
            this.lblngaythanhtoan.Name = "lblngaythanhtoan";
            this.lblngaythanhtoan.Size = new System.Drawing.Size(164, 23);
            this.lblngaythanhtoan.TabIndex = 2;
            this.lblngaythanhtoan.Text = "Ngày thanh toán:";
            // 
            // txttenkhachhang
            // 
            this.txttenkhachhang.Location = new System.Drawing.Point(194, 44);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.Size = new System.Drawing.Size(373, 31);
            this.txttenkhachhang.TabIndex = 1;
            // 
            // lbltenkhach
            // 
            this.lbltenkhach.AutoSize = true;
            this.lbltenkhach.Location = new System.Drawing.Point(24, 50);
            this.lbltenkhach.Name = "lbltenkhach";
            this.lbltenkhach.Size = new System.Drawing.Size(164, 23);
            this.lbltenkhach.TabIndex = 0;
            this.lbltenkhach.Text = "Tên Khách Hàng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btntrigia);
            this.groupBox3.Controls.Add(this.btnthanhtoan);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(13, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1036, 420);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Phiếu Thuê";
            // 
            // btntrigia
            // 
            this.btntrigia.Location = new System.Drawing.Point(47, 365);
            this.btntrigia.Name = "btntrigia";
            this.btntrigia.Size = new System.Drawing.Size(133, 49);
            this.btntrigia.TabIndex = 2;
            this.btntrigia.Text = "Trị giá";
            this.btntrigia.UseVisualStyleBackColor = true;
            this.btntrigia.Click += new System.EventHandler(this.btntrigia_Click);
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Location = new System.Drawing.Point(843, 365);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(147, 49);
            this.btnthanhtoan.TabIndex = 1;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPhong,
            this.SoNgayThue,
            this.DonGia,
            this.ThanhTien});
            this.dataGridView1.DataSource = this.qLKSDataSet;
            this.dataGridView1.Location = new System.Drawing.Point(36, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(977, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên phòng:";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Width = 230;
            // 
            // SoNgayThue
            // 
            this.SoNgayThue.DataPropertyName = "SoNgayThue";
            this.SoNgayThue.HeaderText = "Số ngày thuê:";
            this.SoNgayThue.MinimumWidth = 6;
            this.SoNgayThue.Name = "SoNgayThue";
            this.SoNgayThue.Width = 230;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá:";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 230;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền:";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 230;
            // 
            // qLKSDataSet
            // 
            this.qLKSDataSet.DataSetName = "QLKSDataSet";
            this.qLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLKSDataSetBindingSource
            // 
            this.qLKSDataSetBindingSource.DataSource = this.qLKSDataSet;
            this.qLKSDataSetBindingSource.Position = 0;
            // 
            // hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1061, 647);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "hoadon";
            this.Text = "hoadon";
            this.Load += new System.EventHandler(this.hoadon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.Label lbltenphong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblngaythanhtoan;
        private System.Windows.Forms.TextBox txttenkhachhang;
        private System.Windows.Forms.Label lbltenkhach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntrigia;
        private System.Windows.Forms.Button btnthanhtoan;
        private QLKSDataSet qLKSDataSet;
        private System.Windows.Forms.BindingSource qLKSDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}