using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_QLTV.GUI;

namespace DoAn_QLTV
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        Themsuaxoa t = new Themsuaxoa();

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from NhanVien");
            label9.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                dgvNhanVien.DataSource = dt;
            }
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Họ và tên";
            dgvNhanVien.Columns[2].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[3].HeaderText = "Giới tính";
            dgvNhanVien.Columns[4].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[5].HeaderText = "Điện thoại";

            dgvNhanVien.AutoResizeColumns();
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvNhanVien.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btnXoa.Enabled = true;
            btnSua.Text = "Sửa";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            dgvNhanVien.Enabled = true;

            txttennhanvien.Text = "";
            txtmanhanvien.Text = "";
            txtdienthoai.Text = "";
            txtdiachi.Text = "";
            comgioitinh.Text = "Nam";

            txttennhanvien.Enabled = false;
            txtmanhanvien.Enabled = false;
            txtdienthoai.Enabled = false;
            txtdiachi.Enabled = false;
            comgioitinh.Enabled = false;
            ngaysinh.Enabled = false;

        }
        private void Enable()
        {
            txttennhanvien.Enabled = true;
            txtmanhanvien.Enabled = true;
            txtdienthoai.Enabled = true;
            txtdiachi.Enabled = true;
            comgioitinh.Enabled = true;
            ngaysinh.Enabled = true;
        }
        private void btnbtnThem_Click(object sender, EventArgs e)
        {
            txtmanhanvien.Text = "";
            txttennhanvien.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            btnLuu.Enabled = true;
            //btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Text = "hủy";
            btnThem.Enabled = false;
            dgvNhanVien.Enabled = false;
            Enable();
        }

        private void btnbtnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "hủy")
            {
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXoa.Text = "Xóa";
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                loaddata();
                dgvNhanVien.Enabled = true;
            }
            else
            {
                Enable();
                txtmanhanvien.Enabled = false;
                btnSua.Enabled = true;
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Text = "Xóa";
                btnSua.Text = "hủy";
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
                loaddata();
        }

        private void btnbtnLuu_Click(object sender, EventArgs e)
        {
            string ngayhh = ngaysinh.Value.ToString("MM/dd/yyyy");
            if (dgvNhanVien.Enabled == true)
            {
                if (txtmanhanvien.Text == "" || txttennhanvien.Text == "" || txtdiachi.Text == "" || txtdienthoai.Text == "")
                {
                    MessageBox.Show("Vui lòng không bỏ trống thông tin !!");

                }
                else if (t.thucthidulieu("UPDATE  NhanVien SET TenNV=N'" + txttennhanvien.Text + "', NgaySinh='" + ngayhh + "',GioiTinh=N'" + comgioitinh.Text + "', DiaChi=N'" + txtdiachi.Text + "', SDT=N'" + txtdienthoai.Text + "' WHERE MaNV=N'" + txtmanhanvien.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    btnSua.Text = "Sửa";
                    loaddata();
                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }
            else if (txtmanhanvien.Text == "" || txttennhanvien.Text == "" || txtdiachi.Text == "" || txtdienthoai.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else if (t.thucthidulieu("INSERT INTO NhanVien VALUES ('" + txtmanhanvien.Text + "',N'" + txttennhanvien.Text + "','" + ngayhh + "',N'" + comgioitinh.Text + "',N'" + txtdiachi.Text + "',N'" + txtdienthoai.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi trùng khhóa");
                txtmanhanvien.Focus();
            }
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
                dgvNhanVien.Enabled = true;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa nhân viên có mã số " + txtmanhanvien.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from nhanvien where manv='" + txtmanhanvien.Text + "'") == true)
                            MessageBox.Show("Xóa thành Công", "Thông báo");
                        else MessageBox.Show("Lỗi không thể xóa dữ liệu", "Thông báo");
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmanhanvien.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txttennhanvien.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            ngaysinh.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            comgioitinh.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtdiachi.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtdienthoai.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report_Nhanvien form = new Report_Nhanvien();
            form.Show();
        }
    }
}
