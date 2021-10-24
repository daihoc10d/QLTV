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
    public partial class FormTKeDG : Form
    {
        public FormTKeDG()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void FormTKeDG_Load(object sender, EventArgs e)
        {
            loaddata();
            tuychon.Text = "Tất cả độc giả";
        }
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from DocGia");

            if (dt != null)
            {
                dgvTKeDG.DataSource = dt;
            }
            dgvTKeDG.Columns[0].HeaderText = "Mã độc giả";
            dgvTKeDG.Columns[1].HeaderText = "Tên độc giả";
            dgvTKeDG.Columns[2].HeaderText = "Ngày sinh";
            dgvTKeDG.Columns[3].HeaderText = "Giới";
            dgvTKeDG.Columns[4].HeaderText = "Lớp";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            dgvTKeDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvTKeDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTKeDG.Enabled = true;
        }
        private void loaddata2()
        {
            DataTable dt = t.docdulieu("select distinct DocGia.MaDG,DocGia.TenDG, DocGia.NgaySinh,DocGia.GioiTinh, DocGia.Lop from DocGia, PhieuMuon,CTPhieuMuon where (DocGia.MaDG=PhieuMuon.MaDG and PhieuMuon.MaPM=CTPhieuMuon.MaPM and CTPhieuMuon.NgayTra<GETDATE())");

            if (dt != null)
            {
                dgvTKeDG.DataSource = dt;
            }
            dgvTKeDG.Columns[0].HeaderText = "Mã độc giả";
            dgvTKeDG.Columns[1].HeaderText = "Tên độc giả";
            dgvTKeDG.Columns[2].HeaderText = "Ngày sinh";
            dgvTKeDG.Columns[3].HeaderText = "Giới";
            dgvTKeDG.Columns[4].HeaderText = "Lớp";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            dgvTKeDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvTKeDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTKeDG.Enabled = true;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (tuychon.Text == "Tất cả độc giả")
                loaddata();
            else loaddata2();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();
            DataTable dt = (DataTable)dgvTKeDG.DataSource;
            excel.Export(dt, "Độc giả", "Thống kê độc giả");
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
