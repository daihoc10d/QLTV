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
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
        }

        Themsuaxoa t = new Themsuaxoa();

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = t.docdulieu("select * from Account where TenAccount=N'" + txtTenTK.Text + "' and MKAccount=N'" + txtMK.Text + "'");
                if (txtTenTK.Text == "" || txtMK.Text == "" || txtMKagain.Text == "")
                {
                    MessageBox.Show("Vui lòng không bỏ trống thông tin !!", "Thông báo");
                    txtTenTK.Focus();
                }
                else if (dt.Rows.Count == 1)
                {
                    if(txtMKagain.Text != txtMKAgain2.Text)
                    {
                        MessageBox.Show("Nhập lại mật khẩu mới không khớp !!", "Thông báo");
                    }
                    else
                    if (txtMK.Text != txtMKagain.Text)
                    {
                        if (t.thucthidulieu("update Account set MKAccount=N'" + txtMKagain.Text + "' where TenAccount=N'" + txtTenTK.Text + "'") == true)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công !!", "Thông báo");
                            setNull();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới trùng với mật khẩu cũ !!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại hoặc mật khẩu sai !!", "Thông báo");
                    txtTenTK.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void setNull()
        {
            txtTenTK.Text = "";
            txtMK.Text = "";
            txtMKagain.Text = "";
            txtMKAgain2.Text = "";
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
