using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_Nhom5
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\qlbenhnhanmoi.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }
        void loaddl()
        {
            SqlCommand cmd = new SqlCommand(@"select MaNV, HoTen, ChucVu from NHANVIEN", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into NHANVIEN(MaNV, HoTen, ChucVu) values(@MaNV, @HoTen, @ChucVu)", con);
            cmd.Parameters.AddWithValue("@MaNV", txtnv.Text);
            cmd.Parameters.AddWithValue("@HoTen", txtht.Text);
            cmd.Parameters.AddWithValue("@ChucVu", txtcv.Text);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm Thành Công!");
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại!");
            }
            loaddl();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"select MaNV, HoTen, ChucVu from NHANVIEN", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dc = 0;
            dc = dataGridView1.CurrentCellAddress.Y;
            if (dc >= 0)
            {
                SqlCommand cmd = new SqlCommand("update NHANVIEN set MaNV = @MaNV, HoTen = @HoTen, ChucVu = @ChucVu where MaNV = @MaNVcu", con);
                cmd.Parameters.AddWithValue("@MaNV", txtnv.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtht.Text);
                cmd.Parameters.AddWithValue("@ChucVu", txtcv.Text);
                cmd.Parameters.AddWithValue("@MaBNcu", dataGridView1.Rows[dc].Cells["MaNV"].Value.ToString());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa Thông Tin Bệnh Nhân Thành Công!");
                }
                else
                {
                    MessageBox.Show("Sửa Thông Tin Bệnh Nhân Thất Bại!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dc = 0;
            dc = dataGridView1.CurrentCellAddress.Y;
            if (dc >= 0)
            {
                SqlCommand cmd = new SqlCommand("delete from NHANVIEN where MaNV = @MaNVcu", con);
                cmd.Parameters.AddWithValue("@MaNV", txtnv.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtht.Text);
                cmd.Parameters.AddWithValue("@ChucVu", txtcv.Text);
                cmd.Parameters.AddWithValue("@MaBNcu", dataGridView1.Rows[dc].Cells["MaNV"].Value.ToString());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đã Xóa Thông Tin Bệnh Nhân Thành Công!");
                }
                else
                {
                    MessageBox.Show("Đã Xóa Thông Tin Bệnh Nhân Thất Bại!");
                }
            }
        }
    }
}
