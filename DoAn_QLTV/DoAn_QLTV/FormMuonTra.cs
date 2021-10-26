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
    public partial class FormMuonTra : Form
    {
        public FormMuonTra()
        {
            InitializeComponent();
        }

        Themsuaxoa t = new Themsuaxoa();
        public DateTime date1, date2;
        public TimeSpan time;
        public int day;

        private void FormMuonTra_Load(object sender, EventArgs e)
        {
            loaddata();
            loaddata2();
        }
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from PhieuMuon");
            //l.Text = dt.Rows.Count.ToString();
            loadcombo();
            if (dt != null)
            {
                dgvPM.DataSource = dt;
            }
            dgvPM.Columns[0].HeaderText = "Mã phiếu mượn";
            dgvPM.Columns[1].HeaderText = "Mã độc giả";
            dgvPM.Columns[2].HeaderText = "Mã nhân viên";
            dgvPM.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvPM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnXoa.Enabled = true;
            btnSua.Text = "Sửa";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            dgvPM.Enabled = true;

            txtmaphieu.Text = "";
            comnhanvien.Text = "";
            comdocgia.Text = "";

            txtmaphieu.Enabled = false;
            comnhanvien.Enabled = false;
            comdocgia.Enabled = false;
        }
        private void Enable()
        {
            txtmaphieu.Enabled = true;
            comnhanvien.Enabled = true;
            comdocgia.Enabled = true;
        }
        private void Enable1()
        {
            commaphieumuon.Enabled = true;
            commasach.Enabled = true;
            ngaymuon.Enabled = true;
            ngaytra.Enabled = true;
            ghichu.Enabled = true;
        }
        private void loadcombo()
        {
            DataTable dt = t.docdulieu("select * from DocGia");
            DataTable dt1 = t.docdulieu("select * from NhanVien");
            DataTable dt2 = t.docdulieu("select * from PhieuMuon");
            DataTable dt3 = t.docdulieu("select * from TaiLieu");



            comdocgia.DataSource = dt;
            comdocgia.DisplayMember = "TenDG";
            comdocgia.ValueMember = "MaDG";

            comnhanvien.DataSource = dt1;
            comnhanvien.DisplayMember = "TenNV";
            comnhanvien.ValueMember = "MaNV";

            commaphieumuon.DataSource = dt2;
            commaphieumuon.DisplayMember = "MaPM";
            commaphieumuon.ValueMember = "MaPM";

            commasach.DataSource = dt3;
            commasach.DisplayMember = "MaTaiLieu";
            commasach.ValueMember = "MaTaiLieu";
        }
        private void loaddata2()
        {
            DataTable dt = t.docdulieu("select * from CTPhieuMuon");
            l.Text = dt.Rows.Count.ToString();
            //l.Text = dt.Rows.Count.ToString();
            //loadcombo();
            if (dt != null)
            {
                dgvCTPM.DataSource = dt;
            }
            dgvCTPM.Columns[0].HeaderText = "Mã phiếu mượn";
            dgvCTPM.Columns[1].HeaderText = "Mã sách";
            dgvCTPM.Columns[2].HeaderText = "Ngày mượn";
            dgvCTPM.Columns[3].HeaderText = "Ngày trả";
            dgvCTPM.Columns[4].HeaderText = "Ghi chú";

            dgvCTPM.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvCTPM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnXoa2.Enabled = true;
            btnSua2.Text = "Sửa ngày hẹn trả";
            btnThem2.Enabled = true;
            btnSua2.Enabled = true;
            btnXoa2.Enabled = true;
            btnLuu2.Enabled = false;
            dgvCTPM.Enabled = true;

            commaphieumuon.Enabled = false;
            commasach.Enabled = false;
            //ngaymuon.Enabled = false;
            //ngaytra.Enabled = false;
            ghichu.Enabled = false;

            commaphieumuon.Text = "";
            commasach.Text = "";
            ghichu.Text = "";

        }
        private int CheckID(string idNew)
        {
            int countRow = dgvPM.Rows.Count;
            for (int i = 0; i < countRow; i++)
            {
                if (dgvPM.Rows[i].Cells[0].Value != null)
                    if (dgvPM.Rows[i].Cells[0].ToString() == idNew)
                        return i;
            }
            return -1;
        }

        private void dgvPM_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmaphieu.Text = dgvPM.CurrentRow.Cells[0].Value.ToString();
            comdocgia.Text = dgvPM.CurrentRow.Cells[1].Value.ToString();
            comnhanvien.Text = dgvPM.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Enable();
            DataTable dt = t.docdulieu("select * from PhieuMuon");
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Text = "hủy";
            btnThem.Enabled = false;
            dgvPM.Enabled = false;
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
                dgvPM.Enabled = true;
            }
            else
            {
                Enable();
                dgvPM.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Text = "Xóa";
                btnSua.Text = "hủy";
                txtmaphieu.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvPM.Enabled == true)
            {
                if (comdocgia.Text == "" || comnhanvien.Text == "" || txtmaphieu.Text == "")
                {
                    MessageBox.Show("Vui lòng không để trống thông tin!");
                    txtmaphieu.Focus();
                }
                else if (t.thucthidulieu("update  PhieuMuon set MaDG=N'" + comdocgia.Text + "', MaNV=N'" + comnhanvien.Text + "'where MaPM=N'" + txtmaphieu.Text + "'") == true ||
                    t.thucthidulieu("update  PhieuMuon set MaDG=N'" + comdocgia.SelectedValue.ToString() + "', MaNV=N'" + comnhanvien.SelectedValue.ToString() + "'where MaPM=N'" + txtmaphieu.Text + "'") == true)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    btnSua.Text = "Sửa";
                    loaddata();
                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }
            else if (comdocgia.Text == "" || comnhanvien.Text == "" || txtmaphieu.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống thông tin!");
                txtmaphieu.Focus();
            }
            else if (CheckID(txtmaphieu.Text) == -1)
            {
                if (t.thucthidulieu("INSERT INTO PhieuMuon VALUES (N'" + txtmaphieu.Text + "','" + comdocgia.Text + "','" + comnhanvien.Text + "')") == true ||
                    t.thucthidulieu("INSERT INTO PhieuMuon VALUES (N'" + txtmaphieu.Text + "','" + comdocgia.SelectedValue.ToString() + "','" + comnhanvien.SelectedValue.ToString() + "')") == true)
                {
                    MessageBox.Show("Thêm thành công");
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Lỗi trùng khóa");
                }
            }
            else
            {
                MessageBox.Show("Lỗi không thể thêm");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPM.Rows.Count > 0 && txtmaphieu.Text != "")
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa phiếu mượn có mã số " + txtmaphieu.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from PhieuMuon where MaPM='" + txtmaphieu.Text + "'") == true)
                        {
                            MessageBox.Show("Xóa thành Công", "Thông báo");
                            loaddata();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại, vui lòng kiểm tra độc giả đã trả hết sách hay chưa !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            loaddata();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo");
                        throw;
                    }
                }
                else loaddata();
            }
            else
            {
                MessageBox.Show("Không có đối tượng để xóa", "Thông báo");
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

        private void dgvCTPM_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            commaphieumuon.Text = dgvCTPM.CurrentRow.Cells[0].Value.ToString();
            commasach.Text = dgvCTPM.CurrentRow.Cells[1].Value.ToString();
            ngaymuon.Text = dgvCTPM.CurrentRow.Cells[2].Value.ToString();
            ngaytra.Text = dgvCTPM.CurrentRow.Cells[3].Value.ToString();
            ghichu.Text = dgvCTPM.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            Enable1();
            ngaymuon.Text = "";
            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(-3));//lay ngay hien tai tang them 3 ngay
            ngaytra.Value = result;


            btnLuu2.Enabled = true;

            btnXoa2.Enabled = false;
            btnSua2.Text = "hủy";
            btnThem2.Enabled = false;
            dgvCTPM.Enabled = false;
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            if (dgvCTPM.Rows.Count > 0 && commaphieumuon.Text != "")
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn trả sách có mã " + commasach.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        t.thucthidulieu("delete from CTPhieuMuon where MaTaiLieu='" + commasach.Text + "'");
                        MessageBox.Show("Đã trả sách có mã " + commasach.Text + "", "Thông báo");
                        loaddata2();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể trả sách", "Thông báo");
                        throw;
                    }

                }
                else loaddata2();
            }
            else
            {
                MessageBox.Show("Không tìm thấy mục tiêu để trả sách", "Thông báo");
            }
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {
            string ngayhh = ngaymuon.Value.ToString("MM/dd/yyyy");//dịnh dạng ngày để insert vào sql
            string ngayhhh = ngaytra.Value.ToString("MM/dd/yyyy");
            date1 = Convert.ToDateTime(ngaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
            date2 = Convert.ToDateTime(ngaytra.Text);
            time = date2.Subtract(date1);
            day = time.Days;

            DataTable dt = t.docdulieu("select * from CTPhieuMuon where MaTaiLieu= N'" + commasach.Text + "'");

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Sách đã được mượn, vui lòng chọn cuốn khác", "Thông báo");
                commasach.Focus();
            }
            else if (day < 0)
            {
                MessageBox.Show("Lỗi, ngày hẹn trả không hợp lý", "Thông báo");
                ngaytra.Focus();

            }
            else if (t.thucthidulieu("INSERT INTO CTPhieuMuon VALUES (N'" + commaphieumuon.Text + "','" + commasach.Text + "','" + ngayhh + "','" + ngayhhh + "','" + ghichu.Text + "')") == true ||
                t.thucthidulieu("INSERT INTO CTPhieuMuon VALUES (N'" + commaphieumuon.SelectedValue.ToString() + "','" + commasach.SelectedValue.ToString() + "','" + ngayhh + "','" + ngayhhh + "','" + ghichu.Text + "')") == true)
            {
                MessageBox.Show("Thêm thành công");
                loaddata2();
            }
            else
            {
                MessageBox.Show("Lỗi không thể thực hiện được");
            }
        }

        private void btnLoad2_Click(object sender, EventArgs e)
        {
            loaddata2();
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            string ngayhhh = ngaytra.Value.ToString("MM/dd/yyyy");
            date1 = Convert.ToDateTime(ngaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
            date2 = Convert.ToDateTime(ngaytra.Text);
            time = date2.Subtract(date1);
            day = time.Days;
            if (btnSua2.Text == "hủy")
            {
                btnLuu2.Enabled = false;
                btnSua2.Enabled = true;
                btnXoa2.Enabled = true;
                btnSua2.Text = "Sửa ngày hẹn trả";
                btnThem2.Enabled = true;
                loaddata2();
                dgvCTPM.Enabled = true;
            }
            else if (dgvCTPM.Rows.Count > 0 && commaphieumuon.Text != "")
            {

                if (day < 0)
                {
                    MessageBox.Show("Lỗi, ngày hẹn trả không hợp lý", "Thông báo");
                    ngaytra.Focus();

                }
                else if (t.thucthidulieu("update  CTPhieuMuon set NgayTra=N'" + ngayhhh + "'where MaTaiLieu=N'" + commasach.Text + "'") == true)
                {
                    MessageBox.Show("Sửa ngày hẹn trả thành công");
                    loaddata2();
                }
                else MessageBox.Show("Không thể gia hạn sách");
            }
            else
            {
                MessageBox.Show("Không tìm thấy mục tiêu để sửa ngày hẹn trả", "Thông báo");
            }
        }

        private void btnThoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report_Muontra form = new Report_Muontra();
            form.Show();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
