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
using QuanLyKhachSan.danhsachphieuthue;
namespace QuanLyKhachSan
{
    public partial class hoadon : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public hoadon()
        {
            InitializeComponent();
        }

        private void hoadon_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HEOCUTE;Initial Catalog=QLKS;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
            connection.Close();
        }

        private void LoadDataToDataGridView()
        {
                string query = "SELECT PT.NgayBDThue FROM PHIEUTHUE PT JOIN PHONG P ON PT.MaPhong = P.MaPhong WHERE P.TenPhong = @TenPhong";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
        }
        private DateTime GetNgayBDThueFromDatabase(string tenPhong)
        {
            DateTime ngayBDThue = DateTime.MinValue;
                string query = "SELECT PT.NgayBDThue FROM PHIEUTHUE PT JOIN PHONG P ON PT.MaPhong = P.MaPhong WHERE P.TenPhong = @TenPhong";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenPhong", tenPhong);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ngayBDThue = reader.GetDateTime(0);
                    }
                }
            return ngayBDThue;
        }
        private decimal GetDonGiaFromDatabase(string tenPhong)
        {
            decimal donGia = 0;
                string query = "SELECT P.DonGia FROM LOAIPHONG P JOIN PHONG PH ON P.MaLoaiPhong = PH.MaLoaiPhong WHERE PH.TenPhong = @TenPhong";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenPhong", tenPhong);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        donGia = reader.GetDecimal(0);
                    }
                }
            return donGia;
        }
          
        
        private List<PhieuThue> danhsachphieuthue;
        private void btnthem_Click(object sender, EventArgs e)
        {
            connection.Open();
           
            string tenPhong = txttenphong.Text;
            DateTime ngayThanhToan = dateTimePicker1.Value;
            DateTime ngayBDThue = GetNgayBDThueFromDatabase(tenPhong); 
            int soNgayThue = (int)(ngayThanhToan - ngayBDThue).TotalDays + 1;
            decimal donGia = GetDonGiaFromDatabase(tenPhong);
            decimal thanhTien = donGia * soNgayThue;
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("TenPhong");
                dataTable.Columns.Add("SoNgayThue");
                dataTable.Columns.Add("DonGia");
                dataTable.Columns.Add("ThanhTien");
                DataRow row = dataTable.NewRow();
                row["TenPhong"] = txttenphong.Text;
                row["SoNgayThue"] = soNgayThue;
                row["DonGia"] = donGia;
                row["ThanhTien"] = thanhTien;
                dataTable.Rows.Add(row);
                dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        private void btntrigia_Click(object sender, EventArgs e)
        {
            connection.Open();
            decimal tongThanhTien = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                decimal thanhTien = Convert.ToDecimal(dataGridView1.Rows[i].Cells["ThanhTien"].Value);
                tongThanhTien += thanhTien;
            }
            MessageBox.Show("Tổng thành tiền: " + tongThanhTien.ToString());
            connection.Close();
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string tenPhong = dataGridView1.SelectedRows[0].Cells["TenPhong"].Value.ToString();
                string maPhieuThue = GetMaPhieuThueByTenPhong(tenPhong);
                string query = "DELETE FROM PHIEUTHUE WHERE MaPhieuThue = @MaPhieuThue";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaPhieuThue", maPhieuThue);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã thanh toán và xóa phiếu thuê có mã " + maPhieuThue);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phiếu thuê để xóa");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu thuê để thanh toán");
            }
        }
        private string GetMaPhieuThueByTenPhong(string tenPhong)
        {
            string maPhieuThue = string.Empty;
            string query = "SELECT MaPhieuThue FROM PHIEUTHUE WHERE TenPhong = @TenPhong";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenPhong", tenPhong);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        maPhieuThue = reader.GetString(0);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            return maPhieuThue;
        }
    }
}
