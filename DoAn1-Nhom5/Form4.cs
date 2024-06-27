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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn1_Nhom5
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\qlbenhnhanmoi.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        public Form4()
        {
            InitializeComponent();
        }
        void loaddl()
        {
            SqlCommand cmd = new SqlCommand(@"select MaDV, MaLoaiDV, TenDV, Gia, DonVi, GhiChu from DICHVU", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into DICHVU(MaDV, MaLoaiDV, TenDV, Gia, DonVi, GhiChu) values(@MaDV, @MaLoaiDV, @TenDV, @Gia, @DonVi, @GhiChu)", con);
            cmd.Parameters.AddWithValue("@MaDV", txtmdv.Text);
            cmd.Parameters.AddWithValue("@MaLoaiDV", cb1.Text);
            cmd.Parameters.AddWithValue("@TenDV", txttdv.Text);
            cmd.Parameters.AddWithValue("@Gia", txtg.Text);
            cmd.Parameters.AddWithValue("@DonVi", txtdv.Text);
            cmd.Parameters.AddWithValue("@GhiChu", txtgc.Text);
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

        private void Form4_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"select MaDV, MaLoaiDV, TenDV, Gia, DonVi, GhiChu from DICHVU", con);
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
                SqlCommand cmd = new SqlCommand("update DICHVU set MaDV = @MaDV, MaLoaiDV = @MaLoaiDV, TenDV = @TenDV, Gia = @Gia, DonVi = @DOnVi, GhiChu = @GhiChu  where MaDV = @MaDVcu", con);
                cmd.Parameters.AddWithValue("@MaDV", txtmdv.Text);
                cmd.Parameters.AddWithValue("@MaLoaiDV", cb1.Text);
                cmd.Parameters.AddWithValue("@TenDV", txttdv.Text);
                cmd.Parameters.AddWithValue("@Gia", txtg.Text);
                cmd.Parameters.AddWithValue("@DonVi", txtdv.Text);
                cmd.Parameters.AddWithValue("@GhiChu", txtgc.Text);
                cmd.Parameters.AddWithValue("@MaDVcu", dataGridView1.Rows[dc].Cells["MaDV"].Value.ToString());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa Thông Tin Dịch Vụ Thành Công!");
                }
                else
                {
                    MessageBox.Show("Sửa Thông Tin Dịch Vụ Thất Bại!");
                }
            }
        }
    }
}
