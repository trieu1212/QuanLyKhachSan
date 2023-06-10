using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    public partial class phieuthue : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public phieuthue()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string query = "SELECT KHACHHANG.TenKhach, LOAIKHACH.TenLoaiKhach, KHACHHANG.CMND, KHACHHANG.DiaChi " +
                           "FROM KHACHHANG " +
                           "JOIN LOAIKHACH ON KHACHHANG.MaLoaiKhach = LOAIKHACH.MaLoaiKhach";
            dataAdapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void ClearForm()
        {
            txttenkhach.Text = "";
            txtcmnd.Text = "";
            txtdiachi.Text = "";
            cmbloaikhach.Text = "";
        }
        private void LoadTenLoaiKhach()
        {
            string query = "SELECT TenLoaiKhach FROM LOAIKHACH";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            cmbloaikhach.Items.Clear();
            while (reader.Read())
            {
                string tenLoaiKhach = reader["TenLoaiKhach"].ToString();
                cmbloaikhach.Items.Add(tenLoaiKhach);
            }
            reader.Close();
        }
        private void LoadLoaiPhong()
        {
            string query = "SELECT TenLoaiPhong FROM LOAIPHONG";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            cmbloaiphong.Items.Clear();
            while (reader.Read())
            {
                string tenLoaiPhong = reader["TenLoaiPhong"].ToString();
                cmbloaiphong.Items.Add(tenLoaiPhong);
            }
            reader.Close();
        }
        private void phieutheu_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HEOCUTE;Initial Catalog=QLKS;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
            LoadTenLoaiKhach();
            LoadLoaiPhong();
            LoadData();
           
        }

        private void btnthemkhach_Click(object sender, EventArgs e)
        {
            string tenKhach = txttenkhach.Text;
            string cmnd = txtcmnd.Text;
            string diaChi = txtdiachi.Text;
            string tenLoaiKhach = cmbloaikhach.Text;
            if (string.IsNullOrEmpty(tenKhach) || string.IsNullOrEmpty(cmnd) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(tenLoaiKhach))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string insertQuery = "INSERT INTO KHACHHANG (TenKhach, CMND, DiaChi, MaLoaiKhach) " +
                                 "VALUES (@TenKhach, @CMND, @DiaChi, (SELECT MaLoaiKhach FROM LOAIKHACH WHERE TenLoaiKhach = @TenLoaiKhach))";

            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@TenKhach", tenKhach);
                command.Parameters.AddWithValue("@CMND", cmnd);
                command.Parameters.AddWithValue("@DiaChi", diaChi);
                command.Parameters.AddWithValue("@TenLoaiKhach", tenLoaiKhach);

                command.ExecuteNonQuery();
            }
            LoadData();
            ClearForm();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int cmnd = Convert.ToInt32(selectedRow.Cells["CMND"].Value);
                string deleteQuery = "DELETE FROM KHACHHANG WHERE CMND = @CMND";
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@CMND", cmnd);
                    command.ExecuteNonQuery();
                }
                LoadData();
                MessageBox.Show("Đã xóa thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnnhanphong_Click(object sender, EventArgs e)
        {
            string maPhong = txtmaphong.Text;
            string loaiPhong = cmbloaiphong.SelectedItem.ToString();
            decimal donGia = Convert.ToDecimal(txtdongia.Text);
            DateTime ngayBatDau = dateTimePicker1.Value;
            string insertPhieuThueQuery = "INSERT INTO PHIEUTHUE (MaPhong,  NgayBDThue) " +
                                          "VALUES (@maPhong,  @ngayBatDau)";
            SqlCommand insertPhieuThueCommand = new SqlCommand(insertPhieuThueQuery, connection);
            insertPhieuThueCommand.Parameters.AddWithValue("@maPhong", maPhong);
            insertPhieuThueCommand.Parameters.AddWithValue("@ngayBatDau", ngayBatDau);
            insertPhieuThueCommand.ExecuteNonQuery();
            MessageBox.Show("Đã nhận phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ResetFormControls()
        {
            txttenkhach.Text = "";
            txtcmnd.Text = "";
            txtdiachi.Text = "";
            cmbloaikhach.SelectedIndex = -1;
            txtmaphong.Text = ""; ;
            cmbloaiphong.SelectedIndex = -1;
            txtdongia.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void cmbloaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbloaiphong.SelectedIndex != -1)
            {
                string loaiPhong = cmbloaiphong.SelectedItem.ToString();
                string query = "SELECT DonGia FROM LOAIPHONG WHERE TenLoaiPhong = @TenLoaiPhong";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenLoaiPhong", loaiPhong);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        txtdongia.Text = result.ToString();
                    }
                    else
                    {
                        txtdongia.Text = string.Empty;
                    }
                }
            }
            else
            {
                txtdongia.Text = string.Empty;
            }
        }
        
    }
}
