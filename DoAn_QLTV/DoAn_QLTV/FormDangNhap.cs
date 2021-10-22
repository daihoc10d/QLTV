using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DoAn_QLTV
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        Themsuaxoa t = new Themsuaxoa();

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = t.docdulieu("select * from Account where TenAccount=N'" + txtTaiKhoan.Text + "' and MKAccount=N'" + txtMatKhau.Text + "'");
            //DataTable dt1 = t.docdulieu("select * from Account where MaAccount=N'" + txtMatKhau.Text + "'");
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
                txtTaiKhoan.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                txtMatKhau.Focus();
            }
            else if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                Form f = new MainForm();
                f.Show();
            }
            else { MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai"); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
