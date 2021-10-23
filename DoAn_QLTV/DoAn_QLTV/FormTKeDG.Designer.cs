
namespace DoAn_QLTV
{
    partial class FormTKeDG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTKeDG));
            this.dgvTKeDG = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.tuychon = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKeDG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTKeDG
            // 
            this.dgvTKeDG.AllowUserToAddRows = false;
            this.dgvTKeDG.AllowUserToDeleteRows = false;
            this.dgvTKeDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTKeDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKeDG.Location = new System.Drawing.Point(12, 150);
            this.dgvTKeDG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTKeDG.Name = "dgvTKeDG";
            this.dgvTKeDG.Size = new System.Drawing.Size(775, 303);
            this.dgvTKeDG.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXuatExcel);
            this.groupBox1.Controls.Add(this.tuychon);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(775, 80);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn thống kê";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExcel.Location = new System.Drawing.Point(493, 24);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(87, 32);
            this.btnXuatExcel.TabIndex = 41;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // tuychon
            // 
            this.tuychon.FormattingEnabled = true;
            this.tuychon.Items.AddRange(new object[] {
            "Tất cả độc giả",
            "Độc giả trễ hạn"});
            this.tuychon.Location = new System.Drawing.Point(100, 30);
            this.tuychon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tuychon.Name = "tuychon";
            this.tuychon.Size = new System.Drawing.Size(237, 24);
            this.tuychon.TabIndex = 40;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(588, 25);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 32);
            this.btnThoat.TabIndex = 39;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThongKe.Location = new System.Drawing.Point(390, 25);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(87, 32);
            this.btnThongKe.TabIndex = 38;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(245, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "BÁO CÁO THỐNG KÊ ĐỘC GIẢ";
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX.Location = new System.Drawing.Point(747, 14);
            this.btnX.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(40, 35);
            this.btnX.TabIndex = 58;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // FormTKeDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 466);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.dgvTKeDG);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTKeDG";
            this.Text = "Thống kê độc giả";
            this.Load += new System.EventHandler(this.FormTKeDG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKeDG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTKeDG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.ComboBox tuychon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnX;
    }
}