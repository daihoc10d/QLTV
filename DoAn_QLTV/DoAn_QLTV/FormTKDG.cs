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
    public partial class FormTKDG : Form
    {
        public FormTKDG()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from DocGia");
            l.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                dgvTKDG.DataSource = dt;
            }
            dgvTKDG.Columns[0].HeaderText = "Mã độc giả";
            dgvTKDG.Columns[1].HeaderText = "Họ và tên";
            dgvTKDG.Columns[2].HeaderText = "Ngày sinh";
            dgvTKDG.Columns[3].HeaderText = "Giới tính";
            dgvTKDG.Columns[4].HeaderText = "Lớp";



            dgvTKDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvTKDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTKDG.Enabled = true;

        }

        private void FormTKDG_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("select * from DocGia where MaDG like N'%" + txttimkiem.Text + "%'");
            DataTable dt6 = t.docdulieu("select * from DocGia where TenDG like N'%" + txttimkiem.Text + "%'");
            if (ramasach.Checked == true)
            {
                dgvTKDG.DataSource = dt5;
            }
            else dgvTKDG.DataSource = dt6;
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
