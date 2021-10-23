
namespace DoAn_QLTV
{
    partial class FormMuonTra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuonTra));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvPM = new System.Windows.Forms.DataGridView();
            this.comnhanvien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comdocgia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmaphieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.btnThoat2 = new System.Windows.Forms.Button();
            this.btnLoad2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.btnLuu2 = new System.Windows.Forms.Button();
            this.btnXoa2 = new System.Windows.Forms.Button();
            this.btnSua2 = new System.Windows.Forms.Button();
            this.btnThem2 = new System.Windows.Forms.Button();
            this.dgvCTPM = new System.Windows.Forms.DataGridView();
            this.ghichu = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ngaytra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.commasach = new System.Windows.Forms.ComboBox();
            this.commaphieumuon = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPM)).BeginInit();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(279, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lí Mượn Trả Sách";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Location = new System.Drawing.Point(14, 39);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 622);
            this.tabControl1.TabIndex = 23;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.btnLoad);
            this.tab1.Controls.Add(this.btnLuu);
            this.tab1.Controls.Add(this.btnThoat);
            this.tab1.Controls.Add(this.btnXoa);
            this.tab1.Controls.Add(this.btnSua);
            this.tab1.Controls.Add(this.btnThem);
            this.tab1.Controls.Add(this.dgvPM);
            this.tab1.Controls.Add(this.comnhanvien);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.comdocgia);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Controls.Add(this.txtmaphieu);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab1.Size = new System.Drawing.Size(811, 593);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Lập phiếu mượn";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(208, 189);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 30);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(46, 227);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(208, 227);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(127, 227);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(127, 189);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(46, 189);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvPM
            // 
            this.dgvPM.AllowUserToAddRows = false;
            this.dgvPM.AllowUserToDeleteRows = false;
            this.dgvPM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPM.Location = new System.Drawing.Point(318, 45);
            this.dgvPM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPM.Name = "dgvPM";
            this.dgvPM.Size = new System.Drawing.Size(451, 344);
            this.dgvPM.TabIndex = 26;
            this.dgvPM.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPM_CellMouseClick);
            // 
            // comnhanvien
            // 
            this.comnhanvien.FormattingEnabled = true;
            this.comnhanvien.Location = new System.Drawing.Point(173, 137);
            this.comnhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comnhanvien.Name = "comnhanvien";
            this.comnhanvien.Size = new System.Drawing.Size(140, 24);
            this.comnhanvien.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(7, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Người lập phiếu";
            // 
            // comdocgia
            // 
            this.comdocgia.FormattingEnabled = true;
            this.comdocgia.Location = new System.Drawing.Point(173, 99);
            this.comdocgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comdocgia.Name = "comdocgia";
            this.comdocgia.Size = new System.Drawing.Size(140, 24);
            this.comdocgia.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(7, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã độc giả";
            // 
            // txtmaphieu
            // 
            this.txtmaphieu.Location = new System.Drawing.Point(173, 58);
            this.txtmaphieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmaphieu.Name = "txtmaphieu";
            this.txtmaphieu.Size = new System.Drawing.Size(140, 23);
            this.txtmaphieu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(7, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(314, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "TẠO PHIẾU MƯỢN";
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.btnThoat2);
            this.tab2.Controls.Add(this.btnLoad2);
            this.tab2.Controls.Add(this.label12);
            this.tab2.Controls.Add(this.l);
            this.tab2.Controls.Add(this.btnLuu2);
            this.tab2.Controls.Add(this.btnXoa2);
            this.tab2.Controls.Add(this.btnSua2);
            this.tab2.Controls.Add(this.btnThem2);
            this.tab2.Controls.Add(this.dgvCTPM);
            this.tab2.Controls.Add(this.ghichu);
            this.tab2.Controls.Add(this.label11);
            this.tab2.Controls.Add(this.ngaytra);
            this.tab2.Controls.Add(this.label6);
            this.tab2.Controls.Add(this.ngaymuon);
            this.tab2.Controls.Add(this.commasach);
            this.tab2.Controls.Add(this.commaphieumuon);
            this.tab2.Controls.Add(this.label8);
            this.tab2.Controls.Add(this.label9);
            this.tab2.Controls.Add(this.label10);
            this.tab2.Controls.Add(this.label7);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab2.Size = new System.Drawing.Size(811, 593);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Chi tiết mượn-trả";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // btnThoat2
            // 
            this.btnThoat2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat2.Location = new System.Drawing.Point(650, 209);
            this.btnThoat2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat2.Name = "btnThoat2";
            this.btnThoat2.Size = new System.Drawing.Size(80, 30);
            this.btnThoat2.TabIndex = 20;
            this.btnThoat2.Text = "Thoát";
            this.btnThoat2.UseVisualStyleBackColor = true;
            this.btnThoat2.Click += new System.EventHandler(this.btnThoat2_Click);
            // 
            // btnLoad2
            // 
            this.btnLoad2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad2.Location = new System.Drawing.Point(650, 128);
            this.btnLoad2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad2.Name = "btnLoad2";
            this.btnLoad2.Size = new System.Drawing.Size(80, 30);
            this.btnLoad2.TabIndex = 18;
            this.btnLoad2.Text = "Load";
            this.btnLoad2.UseVisualStyleBackColor = true;
            this.btnLoad2.Click += new System.EventHandler(this.btnLoad2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(166, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(236, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tổng số quyển sách độc giả đang mượn";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.ForeColor = System.Drawing.Color.Red;
            this.l.Location = new System.Drawing.Point(405, 217);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(52, 16);
            this.l.TabIndex = 23;
            this.l.Text = "soluong";
            // 
            // btnLuu2
            // 
            this.btnLuu2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu2.Location = new System.Drawing.Point(650, 90);
            this.btnLuu2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu2.Name = "btnLuu2";
            this.btnLuu2.Size = new System.Drawing.Size(80, 30);
            this.btnLuu2.TabIndex = 17;
            this.btnLuu2.Text = "Lưu";
            this.btnLuu2.UseVisualStyleBackColor = true;
            this.btnLuu2.Click += new System.EventHandler(this.btnLuu2_Click);
            // 
            // btnXoa2
            // 
            this.btnXoa2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa2.Location = new System.Drawing.Point(650, 52);
            this.btnXoa2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa2.Name = "btnXoa2";
            this.btnXoa2.Size = new System.Drawing.Size(80, 30);
            this.btnXoa2.TabIndex = 16;
            this.btnXoa2.Text = "Trả sách";
            this.btnXoa2.UseVisualStyleBackColor = true;
            this.btnXoa2.Click += new System.EventHandler(this.btnXoa2_Click);
            // 
            // btnSua2
            // 
            this.btnSua2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua2.Location = new System.Drawing.Point(649, 166);
            this.btnSua2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua2.Name = "btnSua2";
            this.btnSua2.Size = new System.Drawing.Size(100, 35);
            this.btnSua2.TabIndex = 19;
            this.btnSua2.Text = "Sửa ngày trả";
            this.btnSua2.UseVisualStyleBackColor = true;
            this.btnSua2.Click += new System.EventHandler(this.btnSua2_Click);
            // 
            // btnThem2
            // 
            this.btnThem2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem2.Location = new System.Drawing.Point(650, 14);
            this.btnThem2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem2.Name = "btnThem2";
            this.btnThem2.Size = new System.Drawing.Size(80, 30);
            this.btnThem2.TabIndex = 15;
            this.btnThem2.Text = "Thêm ";
            this.btnThem2.UseVisualStyleBackColor = true;
            this.btnThem2.Click += new System.EventHandler(this.btnThem2_Click);
            // 
            // dgvCTPM
            // 
            this.dgvCTPM.AllowUserToAddRows = false;
            this.dgvCTPM.AllowUserToDeleteRows = false;
            this.dgvCTPM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCTPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPM.Location = new System.Drawing.Point(12, 247);
            this.dgvCTPM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCTPM.Name = "dgvCTPM";
            this.dgvCTPM.Size = new System.Drawing.Size(757, 171);
            this.dgvCTPM.TabIndex = 18;
            this.dgvCTPM.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCTPM_CellMouseClick);
            // 
            // ghichu
            // 
            this.ghichu.Location = new System.Drawing.Point(169, 128);
            this.ghichu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ghichu.Name = "ghichu";
            this.ghichu.Size = new System.Drawing.Size(457, 68);
            this.ghichu.TabIndex = 14;
            this.ghichu.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(8, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 24);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tình trạng sách";
            // 
            // ngaytra
            // 
            this.ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaytra.Location = new System.Drawing.Point(472, 86);
            this.ngaytra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ngaytra.Name = "ngaytra";
            this.ngaytra.Size = new System.Drawing.Size(140, 23);
            this.ngaytra.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(337, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày hẹn trả";
            // 
            // ngaymuon
            // 
            this.ngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaymuon.Location = new System.Drawing.Point(169, 86);
            this.ngaymuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ngaymuon.Name = "ngaymuon";
            this.ngaymuon.Size = new System.Drawing.Size(140, 23);
            this.ngaymuon.TabIndex = 12;
            this.ngaymuon.Value = new System.DateTime(2020, 8, 11, 23, 36, 38, 0);
            // 
            // commasach
            // 
            this.commasach.FormattingEnabled = true;
            this.commasach.Location = new System.Drawing.Point(472, 54);
            this.commasach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commasach.Name = "commasach";
            this.commasach.Size = new System.Drawing.Size(140, 24);
            this.commasach.TabIndex = 11;
            // 
            // commaphieumuon
            // 
            this.commaphieumuon.FormattingEnabled = true;
            this.commaphieumuon.Location = new System.Drawing.Point(169, 54);
            this.commaphieumuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commaphieumuon.Name = "commaphieumuon";
            this.commaphieumuon.Size = new System.Drawing.Size(140, 24);
            this.commaphieumuon.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(8, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ngày mượn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(378, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mã sách";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(7, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã phiếu mượn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(276, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Chi tiết mượn - trả  sách";
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX.Location = new System.Drawing.Point(747, 14);
            this.btnX.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(40, 35);
            this.btnX.TabIndex = 54;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // FormMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 466);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMuonTra";
            this.Text = "Mượn trả";
            this.Load += new System.EventHandler(this.FormMuonTra_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPM)).EndInit();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvPM;
        private System.Windows.Forms.ComboBox comnhanvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comdocgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmaphieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Button btnThoat2;
        private System.Windows.Forms.Button btnLoad2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Button btnLuu2;
        private System.Windows.Forms.Button btnXoa2;
        private System.Windows.Forms.Button btnSua2;
        private System.Windows.Forms.Button btnThem2;
        private System.Windows.Forms.DataGridView dgvCTPM;
        private System.Windows.Forms.RichTextBox ghichu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker ngaytra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ngaymuon;
        private System.Windows.Forms.ComboBox commasach;
        private System.Windows.Forms.ComboBox commaphieumuon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnX;
    }
}