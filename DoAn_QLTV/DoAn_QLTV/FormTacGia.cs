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
    public partial class FormTacGia : Form
    {
        public FormTacGia()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void FormTacGia_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from tacgia");

            if (dt != null)
            {
                dgvTacGia.DataSource = dt;
            }
            dgvTacGia.Columns[0].HeaderText = "Mã tác giả";
            dgvTacGia.Columns[1].HeaderText = "Tên tác giả";


            dgvTacGia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnXoa.Enabled = true;
            btnSua.Text = "Sửa";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            dgvTacGia.Enabled = true;
            txtmatacgia.Enabled = true;

            txtmatacgia.Text = "";
            txttentacgia.Text = "";

            txtmatacgia.Enabled = false;
            txttentacgia.Enabled = false;
        }
        private void Enable()
        {
            txtmatacgia.Enabled = true;
            txttentacgia.Enabled = true;
        }

        private void dgvTacGia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmatacgia.Text = dgvTacGia.CurrentRow.Cells[0].Value.ToString();
            txttentacgia.Text = dgvTacGia.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtmatacgia.Text = "";
            txttentacgia.Text = "";
            btnLuu.Enabled = true;
            //btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Text = "hủy";
            btnThem.Enabled = false;
            dgvTacGia.Enabled = false;
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
                dgvTacGia.Enabled = true;
            }
            else
            {
                Enable();
                txtmatacgia.Enabled = false;
                btnSua.Enabled = true;
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Text = "Xóa";
                btnSua.Text = "hủy";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvTacGia.Enabled == true)
            {
                if (txtmatacgia.Text == "" || txttentacgia.Text == "")
                {
                    MessageBox.Show("Vui lòng không bỏ trống thông tin !!");
                }
                else if (t.thucthidulieu("update  TacGia set TenTG=N'" + txttentacgia.Text + "'where MaTG=N'" + txtmatacgia.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    btnSua.Text = "Sửa";
                    loaddata();
                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }
            else if (txtmatacgia.Text == "" || txttentacgia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!");
            }
            else if (t.thucthidulieu("INSERT INTO TacGia VALUES (N'" + txtmatacgia.Text + "', '" + txttentacgia.Text + "')") == true)
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
                dgvTacGia.Enabled = true;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txtmatacgia.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        if (t.thucthidulieu("delete from tacgia where matacgia='" + txtmatacgia.Text + "'") == true)
                            MessageBox.Show("Xóa thành Công", "Thông báo");
                        else MessageBox.Show("Không thể xóa", "Thông báo");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Report_Tacgia form = new Report_Tacgia();
            form.Show();
        }
    }
}


