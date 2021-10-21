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
    public partial class FormTaiLieu : Form
    {
        public FormTaiLieu()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void FormTaiLieu_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from TaiLieu");

            if (dt != null)
            {
                dgvTaiLieu.DataSource = dt;
            }
            dgvTaiLieu.Columns[0].HeaderText = "Mã tài liệu ";
            dgvTaiLieu.Columns[0].Width = 80;
            dgvTaiLieu.Columns[3].Width = 180;


            dgvTaiLieu.Columns[1].HeaderText = "Tên tài liệu";
            dgvTaiLieu.Columns[2].HeaderText = "Năm xuất bản";
            dgvTaiLieu.Columns[3].HeaderText = "Mã tác giả";
            dgvTaiLieu.Columns[4].HeaderText = "Mã thể loại";
            dgvTaiLieu.Columns[5].HeaderText = "Mã nhà xuất bản";
            //dgvTaiLieu.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btnXoa.Enabled = true;
            btnSua.Text = "Sửa";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            dgvTaiLieu.Enabled = true;

            txttensach.Text = "";
            txtmasach.Text = "";
            txtnamxb.Text = "";
            comnhaxb.Text = "";
            commatacgia.Text = "";
            comtheloai.Text = "";

            txttensach.Enabled = false;
            txtmasach.Enabled = false;
            txtnamxb.Enabled = false;
            comnhaxb.Enabled = false;
            commatacgia.Enabled = false;
            comtheloai.Enabled = false;

            btnLoad.Enabled = true;
        }
        private void Enable()
        {
            txttensach.Enabled = true;
            txtmasach.Enabled = true;
            txtnamxb.Enabled = true;
            comnhaxb.Enabled = true;
            commatacgia.Enabled = true;
            comtheloai.Enabled = true;

            btnLoad.Enabled = false;
        }
        private void loadcombo()
        {
            DataTable dt = t.docdulieu("select * from NhaXuatBan");
            DataTable dt1 = t.docdulieu("select * from TheLoai");
            DataTable dt2 = t.docdulieu("select * from TacGia");


            comnhaxb.DataSource = dt;
            comnhaxb.DisplayMember = "TenNXB";
            comnhaxb.ValueMember = "MaNXB";
            //comnhaxb.DisplayMember = "tennxb";
            //comnhaxb.ValueMember = "manxb";
            comtheloai.DataSource = dt1;
            comtheloai.DisplayMember = "TenTheLoai";
            comtheloai.ValueMember = "MaTheLoai";
            commatacgia.DataSource = dt2;
            commatacgia.DisplayMember = "TenTG";
            commatacgia.ValueMember = "MaTG";



        }

        private void dgvTaiLieu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmasach.Text = dgvTaiLieu.CurrentRow.Cells[0].Value.ToString();
            txttensach.Text = dgvTaiLieu.CurrentRow.Cells[1].Value.ToString();
            txtnamxb.Text = dgvTaiLieu.CurrentRow.Cells[2].Value.ToString();
            commatacgia.Text = dgvTaiLieu.CurrentRow.Cells[3].Value.ToString();
            comtheloai.Text = dgvTaiLieu.CurrentRow.Cells[4].Value.ToString();
            comnhaxb.Text = dgvTaiLieu.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtmasach.Text = "";
            txttensach.Text = "";

            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Text = "hủy";
            btnThem.Enabled = false;
            dgvTaiLieu.Enabled = false;
            loadcombo();
            Enable();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            loadcombo();
            if (btnSua.Text == "hủy")
            {
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXoa.Text = "Xóa";
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                loaddata();
                dgvTaiLieu.Enabled = true;
            }
            else
            {
                Enable();
                btnSua.Enabled = true;
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Text = "Xóa";
                btnSua.Text = "hủy";
                txtmasach.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvTaiLieu.Enabled == true)
            {
                if (txtmasach.Text == "" || txttensach.Text == "" || txtnamxb.Text == "")
                {
                    MessageBox.Show("Vui lòng không bỏ trống thông tin !!");
                    txttensach.Focus();
                }
                // else if (t.thucthidulieu("update  SACH set tensach=N'" + txttensach.Text + "', namxb=N'" + txtnamxb.Text + "', manxb='" + comnhaxb.Text + "', matheloai='" + comtheloai.SelectedValue.ToString() + "', matacgia='" + commatacgia.SelectedValue.ToString() + "'where masach=N'" + txtmasach.Text + "'") == true)
                else if (t.thucthidulieu("UPDATE TaiLieu SET TenTaiLieu=N'" + txttensach.Text + "', NamXB=N'" + txtnamxb.Text + "', MaTG='" + commatacgia.SelectedValue.ToString() + "', MaTheLoai='" + comtheloai.SelectedValue.ToString() + "', MaNXB='" + comnhaxb.SelectedValue.ToString() + "'where MaTaiLieu=N'" + txtmasach.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    btnSua.Text = "Sửa";
                    loaddata();

                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }
            else if (txtmasach.Text == "" || txttensach.Text == "" || txtnamxb.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!");
            }
            else if (t.thucthidulieu("INSERT INTO TaiLieu VALUES ('" + txtmasach.Text + "',N'" + txttensach.Text + "','" + txtnamxb.Text + "','" + commatacgia.SelectedValue.ToString() + "','" + comtheloai.SelectedValue.ToString() + "','" + comnhaxb.SelectedValue.ToString() + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();
            }
            else MessageBox.Show("Lỗi");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "hủy")
            {

                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXoa.Text = "Xóa";
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                loaddata();
                dgvTaiLieu.Enabled = true;

            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa sách có mã số " + txtmasach.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        t.thucthidulieu("delete from TaiLieu where MaTaiLieu='" + txtmasach.Text + "'");
                        MessageBox.Show("Xóa thành Công", "Thông báo");
                        loaddata();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo");
                        throw;
                    }

                }
                else loaddata();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loaddata();
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
