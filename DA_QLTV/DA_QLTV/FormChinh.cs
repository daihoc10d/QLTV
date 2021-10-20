using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_QLTV.FormsChild;

namespace DA_QLTV
{
    public partial class FormChinh : Form
    {
        private Button currentButton; 
        private Random random;  // vòng lặp vô hạn 
        private int tempIndex;
        private Form activeForm;

        public FormChinh()
        {
            InitializeComponent();
            random = new Random();
            hideSubMenu();
            btnCloseFormsChild.Visible = false;

        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            } 
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTieude.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseFormsChild.Visible = true;

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(255, 236, 1);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        //=====================================
        private void hideSubMenu()
        {
            panelHethong.Visible = false;
            panelDanhmuc.Visible = false;
            panelMuontra.Visible = false;
            panelTimkiem.Visible = false;
            panelBaocao.Visible = false;
            panelTrogiup.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;

            }
            else
                subMenu.Visible = false;

        }
        //=====================================

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHethong); // show ra menu con
            ActivateButton(sender);
        }

        private void btnDanhmuc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDanhmuc);// show ra menu con
            ActivateButton(sender);

        }

        private void btnMuontra_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMuontra);// show ra menu con
            ActivateButton(sender);

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTimkiem);// show ra menu con
            ActivateButton(sender);

        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBaocao);// show ra menu con
            ActivateButton(sender);

        }

        private void btnTrogiup_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTrogiup);// show ra menu con
            ActivateButton(sender);

        }

        private void FormChinh_Load(object sender, EventArgs e)
        {

        }
        //======================================================================================================
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            //ActivateButton(btnSender); //hiện màu nút nhấn các forms con
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelForms.Controls.Add(childForm);
            this.panelForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTieude.Text = childForm.Text;
            btnCloseFormsChild.Visible = true;

        }

        //======================================================================================================
        #region các button con của Hệ thống
        private void btnDangxuat_Click(object sender, EventArgs e)
        {

            //hideSubMenu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            //hideSubMenu();

        }
        #endregion

        #region các button con của Danh mục
        private void btnDocgia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsChild.Docgia(), sender); // mở forms 

            //hideSubMenu();

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsChild.Nhanvien(), sender);// mở forms 
            //hideSubMenu();

        }

        private void btnQualyTL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsChild.Quanlytailieu(), sender);// mở forms 
            //hideSubMenu();

        }

        private void btnTheloai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsChild.Theloai(), sender);// mở forms 
            //hideSubMenu();

        }

        private void btnTacgia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsChild.Tacgia(), sender);// mở forms 
            //hideSubMenu();

        }

        private void btnNhaxuatban_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsChild.Nhaxuatban(), sender);// mở forms 
            //hideSubMenu();

        }
        #endregion

        #region các button con của Mượn trả tài liệu
        private void btnLapphieumuon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsChild.Lapphieumuon(), sender);
            //hideSubMenu();

        }

        private void btnChitietphieumuon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsChild.Chitietphieumuon(), sender);
            //hideSubMenu();

        }
        #endregion

        #region các button con của Tìm kiếm
        private void btnTKTailieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsChild.Timkiemtailieu(), sender);
           // hideSubMenu();

        }

        private void btnTKDocgia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsChild.Timkiemdocgia(), sender);
            //hideSubMenu();

        }
        #endregion

        #region các button con của Báo cáo thống kê
        private void btnBCTailieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsChild.Baocaotailieu(), sender);
            //hideSubMenu();

        }

        private void BtnBCTacgia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsChild.Baocaotacgia(), sender);
            //hideSubMenu();

        }
        #endregion

        #region các button con của Trợ giúp
        private void btnLienlac_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsChild.Lienlac(), sender);
            //hideSubMenu();

        }

        private void btnQuydinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsChild.Quydinh(), sender);
            //hideSubMenu();

        }

        #endregion

        private void panelForms_Paint(object sender, PaintEventArgs e)
        {
            //if()
            //{
            //    Formtest frm = new Formtest();
            //    frm.Show();
            //}    
        }

        private void btnCloseFormsChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lbTieude.Text = "HOME";
            panelTieude.BackColor = Color.FromArgb(0, 99, 205);
            panelLogo.BackColor = Color.White;
            currentButton = null;
            btnCloseFormsChild.Visible = false;
        }
    }
}
