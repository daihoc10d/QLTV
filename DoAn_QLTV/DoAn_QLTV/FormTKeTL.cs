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
    public partial class FormTKeTL : Form
    {
        public FormTKeTL()
        {
            InitializeComponent();
        }

        private void FormTKeTL_Load(object sender, EventArgs e)
        {
            tuychon.Text = "Tất cả tài liệu";

            loaddata();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select TaiLieu.MaTaiLieu, TaiLieu.TenTaiLieu, NhaXuatBan.TenNXB,TaiLieu.NamXB,TheLoai.TenTheLoai,TacGia.TenTG from TaiLieu, NhaXuatBan, TheLoai,TacGia where (TaiLieu.MaNXB=NhaXuatBan.MaNXB and TaiLieu.MaTheLoai=TheLoai.MaTheLoai and TacGia.MaTG=TaiLieu.MaTG)");

            if (dt != null)
            {
                dgvTKeTL.DataSource = dt;
            }
            dgvTKeTL.Columns[0].HeaderText = "Mã tài liệu";
            dgvTKeTL.Columns[1].HeaderText = "Tên tài liệu";
            dgvTKeTL.Columns[2].HeaderText = "Nhà xuất bản";
            dgvTKeTL.Columns[3].HeaderText = "Năm xuất bản";
            dgvTKeTL.Columns[4].HeaderText = "Thể loại";
            dgvTKeTL.Columns[5].HeaderText = "Tác giả";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            dgvTKeTL.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvTKeTL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTKeTL.Enabled = true;

        }
        private void loaddata1()
        {
            DataTable dt = t.docdulieu("select TaiLieu.MaTaiLieu,TaiLieu.TenTaiLieu, NhaXuatBan.TenNXB,TaiLieu.NamXB,TheLoai.TenTheLoai,TacGia.TenTG from TaiLieu, NhaXuatBan,CTPhieuMuon, TheLoai,TacGia where (TaiLieu.MaNXB=NhaXuatBan.MaNXB and TaiLieu.MaTheLoai=TheLoai.MaTheLoai and TaiLieu.MaTaiLieu=CTPhieuMuon.MaTaiLieu and TacGia.MaTG=TaiLieu.MaTG)");

            if (dt != null)
            {
                dgvTKeTL.DataSource = dt;
            }
            dgvTKeTL.Columns[0].HeaderText = "Mã tài liệu";
            dgvTKeTL.Columns[1].HeaderText = "Tên tài liệu";
            dgvTKeTL.Columns[2].HeaderText = "Nhà xuất bản";
            dgvTKeTL.Columns[3].HeaderText = "Năm xuất bản";
            dgvTKeTL.Columns[4].HeaderText = "Thể loại";
            dgvTKeTL.Columns[5].HeaderText = "Tác giả";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            dgvTKeTL.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvTKeTL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTKeTL.Enabled = true;

        }
        private void loaddata2()
        {
            DataTable dt = t.docdulieu("select TaiLieu.MaTaiLieu,TaiLieu.TenTaiLieu, NhaXuatBan.TenNXB,TaiLieu.NamXB,TheLoai.TenTheLoai,TacGia.TenTG from TaiLieu, NhaXuatBan,CTPhieuMuon, TheLoai,TacGia where (TaiLieu.MaNXB=NhaXuatBan.MaNXB and TaiLieu.MaTheLoai=TheLoai.MaTheLoai and TaiLieu.MaTaiLieu=CTPhieuMuon.MaTaiLieu and TacGia.MaTG=TaiLieu.MaTG and CTPhieuMuon.NgayTra<GETDATE())");

            if (dt != null)
            {
                dgvTKeTL.DataSource = dt;
            }
            dgvTKeTL.Columns[0].HeaderText = "Mã tài liệu";
            dgvTKeTL.Columns[1].HeaderText = "Tên tài liệu";
            dgvTKeTL.Columns[2].HeaderText = "Nhà xuất bản";
            dgvTKeTL.Columns[3].HeaderText = "Năm xuất bản";
            dgvTKeTL.Columns[4].HeaderText = "Thể loại";
            dgvTKeTL.Columns[5].HeaderText = "Tác giả";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            dgvTKeTL.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvTKeTL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTKeTL.Enabled = true;

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (tuychon.Text == "Tất cả tài liệu")
                loaddata();
            else if (tuychon.Text == "Tài liệu đang mượn")
                loaddata1();
            else loaddata2();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();

            DataTable dt = (DataTable)dgvTKeTL.DataSource;
            excel.Export(dt, "Tài liệu", "Thống kê tài liệu");
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
