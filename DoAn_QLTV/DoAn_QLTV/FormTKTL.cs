using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class FormTKTL : Form
    {
        public FormTKTL()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from TaiLieu");

            if (dt != null)
            {
                dgvTKTL.DataSource = dt;
            }
            dgvTKTL.Columns[0].HeaderText = "Mã sách";
            dgvTKTL.Columns[1].HeaderText = "Tên sách";
            dgvTKTL.Columns[2].HeaderText = "Năm xuất bản";
            dgvTKTL.Columns[3].HeaderText = "Mã nhà xuất bản";
            dgvTKTL.Columns[4].HeaderText = "Mã thể loại";
            dgvTKTL.Columns[5].HeaderText = "Mã tác giả";
            dgvTKTL.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvTKTL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTKTL.Enabled = true;

        }
        private void FormTKTL_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("select * from TaiLieu where MaTaiLieu like N'%" + txttimkiem.Text + "%'");
            DataTable dt6 = t.docdulieu("select * from TaiLieu where TenTaiLieu like N'%" + txttimkiem.Text + "%'");
            if (ramasach.Checked == true)
            {
                dgvTKTL.DataSource = dt5;
            }
            else dgvTKTL.DataSource = dt6;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
