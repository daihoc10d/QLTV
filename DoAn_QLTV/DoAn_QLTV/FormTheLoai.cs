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
    public partial class FormTheLoai : Form
    {
        public FormTheLoai()
        {
            InitializeComponent();
        }

        private void FormTheLoai_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from theloai");

            if (dt != null)
            {
                dgvTheLoai.DataSource = dt;
            }
            dgvTheLoai.Columns[0].HeaderText = "Mã thể loại";
            dgvTheLoai.Columns[1].HeaderText = "Tên thể loại";
            dgvTheLoai.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnXoa.Enabled = true;
            btnSua.Text = "Sửa";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            dgvTheLoai.Enabled = true;
            txtmatheloai.Enabled = true;

            txtmatheloai.Text = "";
            txttentheloai.Text = "";

            txtmatheloai.Enabled = false;
            txttentheloai.Enabled = false;
        }

        private void Enable()
        {
            txtmatheloai.Enabled = true;
            txttentheloai.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtmatheloai.Text = "";
            txttentheloai.Text = "";
            btnLuu.Enabled = true;
            //btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Text = "hủy";
            btnThem.Enabled = false;
            dgvTheLoai.Enabled = false;
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
                dgvTheLoai.Enabled = true;


            }
            else
            {
                Enable();
                txtmatheloai.Enabled = false;
                btnSua.Enabled = true;
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Text = "Xóa";
                btnSua.Text = "hủy";
            }

            }

        private void bnLuu_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.Enabled == true)
            {
                if (txtmatheloai.Text == "" || txttentheloai.Text == "")
                {
                    MessageBox.Show("Vui lòng không bỏ trống thông tin !!");
                }

                else if (t.thucthidulieu("update  TheLoai set TenTheLoai=N'" + txttentheloai.Text + "'where MaTheLoai=N'" + txtmatheloai.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    btnSua.Text = "Sửa";
                    loaddata();
                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }

            else if (txtmatheloai.Text == "" || txttentheloai.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!");
            }
            else if (t.thucthidulieu("INSERT INTO TheLoai VALUES ('" + txtmatheloai.Text + "', N'" + txttentheloai.Text + "')") == true)
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
                dgvTheLoai.Enabled = true;

            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txtmatheloai.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        t.thucthidulieu("delete from theloai where matheloai='" + txtmatheloai.Text + "'");
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

        private void dgvTheLoai_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmatheloai.Text = dgvTheLoai.CurrentRow.Cells[0].Value.ToString();
            txttentheloai.Text = dgvTheLoai.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report_Theloai form = new Report_Theloai();
            form.Show();
        }
    }
}
