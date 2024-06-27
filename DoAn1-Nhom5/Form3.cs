using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_Nhom5
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\qlbenhnhanmoi.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        public Form3()
        {
            InitializeComponent();
        }
        void loaddl()
        {
            SqlCommand cmd = new SqlCommand(@"select MaBS, HoTen, TrinhDo, ChuyenMon, ChucVu, TenPhongKham from BACSI", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"select MaBS, HoTen, TrinhDo, ChuyenMon, ChucVu, TenPhongKham from BACSI", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into BACSI(MaBS, HoTen, TrinhDo, ChuyenMon, ChucVu, TenPhongKham) values(@MaBS, @HoTen, @TrinhDo, @ChuyenMon, @ChucVu, @TenPhongKham)", con);
            cmd.Parameters.AddWithValue("@MaBS", textBox1.Text);
            cmd.Parameters.AddWithValue("@HoTen", textBox2.Text);
            cmd.Parameters.AddWithValue("@TrinhDo", textBox3.Text);
            cmd.Parameters.AddWithValue("@ChuyenMon", textBox4.Text);
            cmd.Parameters.AddWithValue("@ChucVu", textBox5.Text);
            cmd.Parameters.AddWithValue("@TenPhongKham", textBox6.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            int dc = 0;
            dc = dataGridView1.CurrentCellAddress.Y;
            if (dc >= 0)
            {
                SqlCommand cmd = new SqlCommand("update BACSI set MaBS = @MaBS, HoTen = @HoTen, TrinhDo = @TrinhDo, ChuyenMon = @ChuyenMon, ChucVu = @ChucVu, TenPhongKham = @TenPhongKham where MaBS = @MaBScu", con);
                cmd.Parameters.AddWithValue("@MaNV", textBox1.Text);
                cmd.Parameters.AddWithValue("@HoTen", textBox2.Text);
                cmd.Parameters.AddWithValue("@TrinhDo", textBox3.Text);
                cmd.Parameters.AddWithValue("@ChuyenMon", textBox4.Text);
                cmd.Parameters.AddWithValue("@ChucVu", textBox5.Text);
                cmd.Parameters.AddWithValue("@TenPhongKham", textBox6.Text);
                cmd.Parameters.AddWithValue("@MaBScu", dataGridView1.Rows[dc].Cells["MaBS"].Value.ToString());
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
                SqlCommand cmd = new SqlCommand("delete from BACSI where MaBS = @MaBScu", con);
                cmd.Parameters.AddWithValue("@MaNV", textBox1.Text);
                cmd.Parameters.AddWithValue("@HoTen", textBox2.Text);
                cmd.Parameters.AddWithValue("@TrinhDo", textBox3.Text);
                cmd.Parameters.AddWithValue("@ChuyenMon", textBox4.Text);
                cmd.Parameters.AddWithValue("@ChucVu", textBox5.Text);
                cmd.Parameters.AddWithValue("@TenPhongKham", textBox6.Text);
                cmd.Parameters.AddWithValue("@MaBScu", dataGridView1.Rows[dc].Cells["MaBS"].Value.ToString());
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
