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
    public partial class FormDocGia : Form
    {

        public FormDocGia()
        {
            InitializeComponent();
        }

        Themsuaxoa t = new Themsuaxoa();

        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from DocGia");
            label9.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                dgvDocGia.DataSource = dt;
            }
            dgvDocGia.Columns[0].HeaderText = "Mã độc giả";
            dgvDocGia.Columns[1].HeaderText = "Họ và tên";
            dgvDocGia.Columns[2].HeaderText = "Ngày sinh";
            dgvDocGia.Columns[3].HeaderText = "Giới tính";
            dgvDocGia.Columns[4].HeaderText = "Lớp";

            dgvDocGia.AutoResizeColumns();
            dgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvDocGia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btnXoa.Enabled = true;
            btnSua.Text = "Sửa";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            dgvDocGia.Enabled = true;
            txtmadocgia.Enabled = true;

            txttendocgia.Text = "";
            txtmadocgia.Text = "";
            txtlop.Text = "";
            comgioitinh.Text = "Nam";

            txttendocgia.Enabled = false;
            txtmadocgia.Enabled = false;
            txtlop.Enabled = false;
            ngaysinh.Enabled = false;
            comgioitinh.Enabled = false;

        }
        private void Enable()
        {
            txttendocgia.Enabled = true;
            txtmadocgia.Enabled = true;
            txtlop.Enabled = true;
            ngaysinh.Enabled = true;
            comgioitinh.Enabled = true;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtmadocgia.Text = "";
            txttendocgia.Text = "";
            txtlop.Text = "";
            btnLuu.Enabled = true;
            //sua.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Text = "hủy";
            btnThem.Enabled = false;
            dgvDocGia.Enabled = false;
            Enable();
        }

        private void btnSua_Click(object sender, EventArgs e)
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
                dgvDocGia.Enabled = true;
            }
            else
            {
                Enable();
                txtmadocgia.Enabled = false;
                btnSua.Enabled = true;
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Text = "Xóa";
                btnSua.Text = "hủy";
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
                dgvDocGia.Enabled = true;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa độc giả có mã số " + txtmadocgia.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from DocGia where MaDG='" + txtmadocgia.Text + "'") == true)
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
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngayhh = ngaysinh.Value.ToString("MM/dd/yyyy");
            if (dgvDocGia.Enabled == true)
            {
                if (txtmadocgia.Text == "" || txttendocgia.Text == "" || txtlop.Text == "")
                {
                    MessageBox.Show("Vui lòng không bỏ trống thông tin !!");

                }
                else if (t.thucthidulieu("update  DocGia set TenDG=N'" + txttendocgia.Text + "', NgaySinh='" + ngayhh + "', GioiTinh=N'" + comgioitinh.Text + "', Lop=N'" + txtlop.Text + "'where MaDG=N'" + txtmadocgia.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    btnSua.Text = "Sửa";
                    loaddata();
                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }
            else if (txtmadocgia.Text == "" || txttendocgia.Text == "" || txtlop.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!");
            }

            else if (t.thucthidulieu("INSERT INTO DocGia VALUES ('" + txtmadocgia.Text + "',N'" + txttendocgia.Text + "','" + ngayhh + "',N'" + comgioitinh.Text + "',N'" + txtlop.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi trùng khhóa");

                txtmadocgia.Focus();

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

        private void dgvDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvDocGia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmadocgia.Text = dgvDocGia.CurrentRow.Cells[0].Value.ToString();
            txttendocgia.Text = dgvDocGia.CurrentRow.Cells[1].Value.ToString();
            ngaysinh.Text = dgvDocGia.CurrentRow.Cells[2].Value.ToString();
            comgioitinh.Text = dgvDocGia.CurrentRow.Cells[3].Value.ToString();
            txtlop.Text = dgvDocGia.CurrentRow.Cells[4].Value.ToString();
        }

        private void FormDocGia_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }


}

