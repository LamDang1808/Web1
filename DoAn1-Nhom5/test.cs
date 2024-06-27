using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_Nhom5
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.dataSet11.NHANVIEN);
            // TODO: This line of code loads data into the 'dataSet1.BACSI' table. You can move, or remove it, as needed.
            this.bACSITableAdapter.Fill(this.dataSet1.BACSI);

        }
    }
}
