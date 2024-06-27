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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\QLbenhnhanABC.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        void loaddl()
        {
            SqlCommand cmd = new SqlCommand(@"select MaBN, HoTenBN, GioiTinhBN, NgaySinh, TinhTrangBenh, DiaChi, DoiTuong, Thuoc, GhiChu from QLbenhnhanABC", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"select MaBN, HoTenBN, GioiTinhBN, NgaySinh, TinhTrangBenh, DiaChi, DoiTuong, Thuoc, GhiChu from QLbenhnhanABC", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btht_Click(object sender, EventArgs e)
        {
            //Load Dữ Liệu
            loaddl();
        }

        private void btcn_Click(object sender, EventArgs e)
        {
            //Load Dữ Liệu
            loaddl();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            //Thêm Dữ Liệu
            SqlCommand cmd = new SqlCommand("insert into QLbenhnhanABC(MaBN, HoTenBN, GioiTinhBN, NgaySinh, TinhTrangBenh, DiaChi, DoiTuong, Thuoc, GhiChu) values(@MaBN, @HoTenBN, @GioiTinhBN, @NgaySinh, @TinhTrangBenh, @DiaChi, @DoiTuong, @Thuoc, @GhiChu)", con);
            cmd.Parameters.AddWithValue("@MaBN", txtmbn.Text);
            cmd.Parameters.AddWithValue("@HoTenBN", txtht.Text);
            cmd.Parameters.AddWithValue("@GioiTinhBN", txtgt.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dtns.Value);
            cmd.Parameters.AddWithValue("@TinhTrangBenh", txtttb.Text);
            cmd.Parameters.AddWithValue("@DiaChi", txtdc.Text);
            cmd.Parameters.AddWithValue("@DoiTuong", txtdt.Text);
            cmd.Parameters.AddWithValue("@Thuoc", txtthuoc.Text);
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

        private void btsua_Click(object sender, EventArgs e)
        {
            //Sửa Dữ Liệu
            int dc = 0;
            dc = dataGridView1.CurrentCellAddress.Y;
            if (dc >= 0)
            {
                SqlCommand cmd = new SqlCommand("update QLbenhnhanABC set MaBN = @MaBN, HoTenBN = @HoTenBN, GioiTinhBN = @GioiTinhBN, NgaySinh = @NgaySinh, TinhTrangBenh = @TinhTrangBenh, DiaChi = @DiaChi, DoiTuong = @DoiTuong, Thuoc = @Thuoc, GhiChu = @GhiChu where MaBN = @MaBNcu", con);
                cmd.Parameters.AddWithValue("@MaBN", txtmbn.Text);
                cmd.Parameters.AddWithValue("@HoTenBN", txtht.Text);
                cmd.Parameters.AddWithValue("@GioiTinhBN", txtgt.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtns.Value);
                cmd.Parameters.AddWithValue("@TinhTrangBenh", txtttb.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtdc.Text);
                cmd.Parameters.AddWithValue("@DoiTuong", txtdt.Text);
                cmd.Parameters.AddWithValue("@Thuoc", txtthuoc.Text);
                cmd.Parameters.AddWithValue("@GhiChu", txtgc.Text);
                cmd.Parameters.AddWithValue("@MaBNcu", dataGridView1.Rows[dc].Cells["MaBN"].Value.ToString());
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

        private void btxoa_Click(object sender, EventArgs e)
        {
            //Xóa Dữ Liệu
            int dc = 0;
            dc = dataGridView1.CurrentCellAddress.Y;
            if (dc >= 0)
            {
                SqlCommand cmd = new SqlCommand("delete from QLbenhnhanABC where MaBN = @MaBNcu", con);
                cmd.Parameters.AddWithValue("@MaBN", txtmbn.Text);
                cmd.Parameters.AddWithValue("@HoTenBN", txtht.Text);
                cmd.Parameters.AddWithValue("@GioiTinhBN", txtgt.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtns.Value);
                cmd.Parameters.AddWithValue("@TinhTrangBenh", txtttb.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtdc.Text);
                cmd.Parameters.AddWithValue("@DoiTuong", txtdt.Text);
                cmd.Parameters.AddWithValue("@Thuoc", txtthuoc.Text);
                cmd.Parameters.AddWithValue("@GhiChu", txtgc.Text);
                cmd.Parameters.AddWithValue("@MaBNcu", dataGridView1.Rows[dc].Cells["MaBN"].Value.ToString());
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int dc = 0;
            dc = dataGridView1.CurrentCellAddress.Y;
            if (dc >= 0)
            {
                txtmbn.Text = dataGridView1.Rows[dc].Cells["MaBN"].Value.ToString();
                txtht.Text = dataGridView1.Rows[dc].Cells["HoTenBN"].Value.ToString();
                txtgt.Text = dataGridView1.Rows[dc].Cells["GioiTinhBN"].Value.ToString();
                dtns.Value = DateTime.Parse(dataGridView1.Rows[dc].Cells["NgaySinh"].Value.ToString());
                txtttb.Text = dataGridView1.Rows[dc].Cells["TinhTrangBenh"].Value.ToString();
                txtdc.Text = dataGridView1.Rows[dc].Cells["DiaChi"].Value.ToString();
                txtdt.Text = dataGridView1.Rows[dc].Cells["DoiTuong"].Value.ToString();
                txtthuoc.Text = dataGridView1.Rows[dc].Cells["Thuoc"].Value.ToString();
                txtgc.Text = dataGridView1.Rows[dc].Cells["GhiChu"].Value.ToString();
            }
        }
    }
}
