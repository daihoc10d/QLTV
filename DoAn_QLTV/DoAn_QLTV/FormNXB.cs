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
    public partial class FormNXB : Form
    {
        public FormNXB()
        {
            InitializeComponent();
        }

        private void FormNXB_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from NhaXuatBan");

            if (dt != null)
            {
                dgvNXB.DataSource = dt;
            }
            dgvNXB.Columns[0].HeaderText = "Mã nhà XB";
            dgvNXB.Columns[1].HeaderText = "Tên nhà XB";
            dgvNXB.Columns[2].HeaderText = "Địa chỉ";
            dgvNXB.Columns[3].HeaderText = "Điện thoại";
            dgvNXB.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvNXB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnXoa.Enabled = true;
            btnSua.Text = "Sửa";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            dgvNXB.Enabled = true;
            txtmanhaxb.Enabled = true;

            txtmanhaxb.Text = "";
            txttennhaxb.Text = "";
            txtdiachi.Text = "";
            txtphone.Text = "";

            txtmanhaxb.Enabled = false;
            txttennhaxb.Enabled = false;
            txtdiachi.Enabled = false;
            txtphone.Enabled = false;
        }

        private void Enable()
        {
            txtmanhaxb.Enabled = true;
            txttennhaxb.Enabled = true;
            txtdiachi.Enabled = true;
            txtphone.Enabled = true;
        }

        private void dgvNXB_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmanhaxb.Text = dgvNXB.CurrentRow.Cells[0].Value.ToString();
            txttennhaxb.Text = dgvNXB.CurrentRow.Cells[1].Value.ToString();
            txtdiachi.Text = dgvNXB.CurrentRow.Cells[2].Value.ToString();
            txtphone.Text = dgvNXB.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtmanhaxb.Text = "";
            txttennhaxb.Text = "";
            txtdiachi.Text = "";
            txtphone.Text = "";
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Text = "hủy";
            btnThem.Enabled = false;
            dgvNXB.Enabled = false;
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
                dgvNXB.Enabled = true;
            }
            else
            {
                Enable();
                txtmanhaxb.Enabled = false;
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
            if (dgvNXB.Enabled == true)
            {
                if (txtmanhaxb.Text == "" || txttennhaxb.Text == "" || txtdiachi.Text == "" || txtphone.Text == "")
                {
                    MessageBox.Show("Vui lòng không bỏ trống thông tin !!");

                }
                else if (t.thucthidulieu("update  NhaXuatBan set TenNXB=N'" + txttennhaxb.Text + "', DiaChi=N'" + txtdiachi.Text + "', SDT='" + txtphone.Text + "'where MaNXB=N'" + txtmanhaxb.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    btnSua.Text = "Sửa";
                    loaddata();
                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }
            else if (txtmanhaxb.Text == "" || txttennhaxb.Text == "" || txtdiachi.Text == "" || txtphone.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!");

            }
            else if (t.thucthidulieu("INSERT INTO NhaXuatBan VALUES ('" + txtmanhaxb.Text + "',N'" + txttennhaxb.Text + "',N'" + txtdiachi.Text + "','" + txtphone.Text + "')") == true)
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
                dgvNXB.Enabled = true;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txtmanhaxb.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        if (t.thucthidulieu("delete from nhaxb where manxb='" + txtmanhaxb.Text + "'") == true)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
