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
    public partial class FormThemTK : Form
    {
        public FormThemTK()
        {
            InitializeComponent();
        }

        Themsuaxoa t = new Themsuaxoa();

        private void FormThemTK_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenTK.Text == "" || txtMK.Text == "" || txtMKagain.Text == "" || txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK);
                txtTenTK.Focus();
            }
            else if (txtMK.Text != txtMKagain.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp nhau !!", "Thông báo", MessageBoxButtons.OK);
            }
            else if (t.thucthidulieu("INSERT INTO Account VALUES (N'" + txtTenTK.Text + "','" + txtMK.Text + "','" + txtMaNV.Text + "')") == true)
            {
                MessageBox.Show("Thêm thành công !!", "Thông báo", MessageBoxButtons.OK);
                setNull();
            }
            else
            {
                MessageBox.Show("Thêm thất bại, vui lòng nhập tên tài khoản và mã nhân viên hợp lệ !!", "Thông báo", MessageBoxButtons.OK);
                setNull();
                txtTenTK.Focus();
            }
        }
        private void setNull()
        {
            txtTenTK.Text = "";
            txtMK.Text = "";
            txtMKagain.Text = "";
            txtMaNV.Text = "";
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
