namespace QuanLyKhachSan
{
    partial class phieuthue
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
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthemkhach = new System.Windows.Forms.Button();
            this.cmbloaikhach = new System.Windows.Forms.ComboBox();
            this.lblloaikhach = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.lblcmnd = new System.Windows.Forms.Label();
            this.txttenkhach = new System.Windows.Forms.TextBox();
            this.lbltenkhach = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnnhanphong = new System.Windows.Forms.Button();
            this.cmbloaiphong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.lblloaiphong = new System.Windows.Forms.Label();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.lblmaphong = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblngaythue = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnthemkhach);
            this.groupBox1.Controls.Add(this.cmbloaikhach);
            this.groupBox1.Controls.Add(this.lblloaikhach);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.lbldiachi);
            this.groupBox1.Controls.Add(this.txtcmnd);
            this.groupBox1.Controls.Add(this.lblcmnd);
            this.groupBox1.Controls.Add(this.txttenkhach);
            this.groupBox1.Controls.Add(this.lbltenkhach);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(303, 343);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(107, 50);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthemkhach
            // 
            this.btnthemkhach.Location = new System.Drawing.Point(48, 343);
            this.btnthemkhach.Name = "btnthemkhach";
            this.btnthemkhach.Size = new System.Drawing.Size(107, 50);
            this.btnthemkhach.TabIndex = 8;
            this.btnthemkhach.Text = "Thêm";
            this.btnthemkhach.UseVisualStyleBackColor = true;
            this.btnthemkhach.Click += new System.EventHandler(this.btnthemkhach_Click);
            // 
            // cmbloaikhach
            // 
            this.cmbloaikhach.FormattingEnabled = true;
            this.cmbloaikhach.Location = new System.Drawing.Point(27, 306);
            this.cmbloaikhach.Name = "cmbloaikhach";
            this.cmbloaikhach.Size = new System.Drawing.Size(409, 31);
            this.cmbloaikhach.TabIndex = 7;
            // 
            // lblloaikhach
            // 
            this.lblloaikhach.AutoSize = true;
            this.lblloaikhach.Location = new System.Drawing.Point(23, 280);
            this.lblloaikhach.Name = "lblloaikhach";
            this.lblloaikhach.Size = new System.Drawing.Size(164, 23);
            this.lblloaikhach.TabIndex = 6;
            this.lblloaikhach.Text = "Loại khách hàng:";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(27, 232);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(409, 31);
            this.txtdiachi.TabIndex = 5;
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(23, 206);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(78, 23);
            this.lbldiachi.TabIndex = 4;
            this.lbldiachi.Text = "Địa chỉ:";
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(27, 154);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(409, 31);
            this.txtcmnd.TabIndex = 3;
            // 
            // lblcmnd
            // 
            this.lblcmnd.AutoSize = true;
            this.lblcmnd.Location = new System.Drawing.Point(23, 128);
            this.lblcmnd.Name = "lblcmnd";
            this.lblcmnd.Size = new System.Drawing.Size(76, 23);
            this.lblcmnd.TabIndex = 2;
            this.lblcmnd.Text = "CMND: ";
            // 
            // txttenkhach
            // 
            this.txttenkhach.Location = new System.Drawing.Point(27, 78);
            this.txttenkhach.Name = "txttenkhach";
            this.txttenkhach.Size = new System.Drawing.Size(409, 31);
            this.txttenkhach.TabIndex = 1;
            // 
            // lbltenkhach
            // 
            this.lbltenkhach.AutoSize = true;
            this.lbltenkhach.Location = new System.Drawing.Point(23, 52);
            this.lbltenkhach.Name = "lbltenkhach";
            this.lbltenkhach.Size = new System.Drawing.Size(168, 23);
            this.lbltenkhach.TabIndex = 0;
            this.lbltenkhach.Text = "Tên Khách Hàng: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnnhanphong);
            this.groupBox2.Controls.Add(this.cmbloaiphong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtdongia);
            this.groupBox2.Controls.Add(this.lblloaiphong);
            this.groupBox2.Controls.Add(this.txtmaphong);
            this.groupBox2.Controls.Add(this.lblmaphong);
            this.groupBox2.Location = new System.Drawing.Point(13, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Phòng:";
            // 
            // btnnhanphong
            // 
            this.btnnhanphong.Location = new System.Drawing.Point(318, 279);
            this.btnnhanphong.Name = "btnnhanphong";
            this.btnnhanphong.Size = new System.Drawing.Size(132, 50);
            this.btnnhanphong.TabIndex = 11;
            this.btnnhanphong.Text = "Nhận phòng";
            this.btnnhanphong.UseVisualStyleBackColor = true;
            this.btnnhanphong.Click += new System.EventHandler(this.btnnhanphong_Click);
            // 
            // cmbloaiphong
            // 
            this.cmbloaiphong.FormattingEnabled = true;
            this.cmbloaiphong.Location = new System.Drawing.Point(27, 152);
            this.cmbloaiphong.Name = "cmbloaiphong";
            this.cmbloaiphong.Size = new System.Drawing.Size(409, 31);
            this.cmbloaiphong.TabIndex = 10;
            this.cmbloaiphong.SelectedIndexChanged += new System.EventHandler(this.cmbloaiphong_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Đơn giá: ";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(27, 240);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(409, 31);
            this.txtdongia.TabIndex = 8;
            // 
            // lblloaiphong
            // 
            this.lblloaiphong.AutoSize = true;
            this.lblloaiphong.Location = new System.Drawing.Point(27, 126);
            this.lblloaiphong.Name = "lblloaiphong";
            this.lblloaiphong.Size = new System.Drawing.Size(110, 23);
            this.lblloaiphong.TabIndex = 7;
            this.lblloaiphong.Text = "Loại phòng";
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(27, 70);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(409, 31);
            this.txtmaphong.TabIndex = 6;
            // 
            // lblmaphong
            // 
            this.lblmaphong.AutoSize = true;
            this.lblmaphong.Location = new System.Drawing.Point(27, 44);
            this.lblmaphong.Name = "lblmaphong";
            this.lblmaphong.Size = new System.Drawing.Size(109, 23);
            this.lblmaphong.TabIndex = 0;
            this.lblmaphong.Text = "Mã Phòng: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.lblngaythue);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(495, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(740, 750);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phiếu Thuê Khách Sạn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(378, 31);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblngaythue
            // 
            this.lblngaythue.AutoSize = true;
            this.lblngaythue.Location = new System.Drawing.Point(89, 37);
            this.lblngaythue.Name = "lblngaythue";
            this.lblngaythue.Size = new System.Drawing.Size(107, 23);
            this.lblngaythue.TabIndex = 1;
            this.lblngaythue.Text = "Ngày thuê:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKhach,
            this.TenLoaiKhach,
            this.CMND,
            this.DiaChi});
            this.dataGridView1.DataSource = this.qLKSDataSet;
            this.dataGridView1.Location = new System.Drawing.Point(35, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(662, 640);
            this.dataGridView1.TabIndex = 0;
            // 
            // TenKhach
            // 
            this.TenKhach.DataPropertyName = "TenKhach";
            this.TenKhach.HeaderText = "Tên khách:";
            this.TenKhach.MinimumWidth = 6;
            this.TenKhach.Name = "TenKhach";
            this.TenKhach.Width = 150;
            // 
            // TenLoaiKhach
            // 
            this.TenLoaiKhach.DataPropertyName = "TenLoaiKhach";
            this.TenLoaiKhach.HeaderText = "Loại khách:";
            this.TenLoaiKhach.MinimumWidth = 6;
            this.TenLoaiKhach.Name = "TenLoaiKhach";
            this.TenLoaiKhach.Width = 150;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND:";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            this.CMND.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ:";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 150;
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
            // phieuthue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1247, 775);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "phieuthue";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.phieutheu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthemkhach;
        private System.Windows.Forms.ComboBox cmbloaikhach;
        private System.Windows.Forms.Label lblloaikhach;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.Label lblcmnd;
        private System.Windows.Forms.TextBox txttenkhach;
        private System.Windows.Forms.Label lbltenkhach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnnhanphong;
        private System.Windows.Forms.ComboBox cmbloaiphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label lblloaiphong;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.Label lblmaphong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblngaythue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource qLKSDataSetBindingSource;
        private QLKSDataSet qLKSDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.Button btnxoa;
    }
}

