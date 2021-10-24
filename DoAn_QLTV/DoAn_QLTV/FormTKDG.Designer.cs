
namespace DoAn_QLTV
{
    partial class FormTKDG
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
            this.label2 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.ramasach = new System.Windows.Forms.RadioButton();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.ratensach = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTKDG = new System.Windows.Forms.DataGridView();
            this.btnX = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tổng số độc giả là";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.ForeColor = System.Drawing.Color.Red;
            this.l.Location = new System.Drawing.Point(179, 175);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(46, 16);
            this.l.TabIndex = 43;
            this.l.Text = "tongso";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.ramasach);
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Controls.Add(this.ratensach);
            this.groupBox1.Location = new System.Drawing.Point(22, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(765, 121);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(544, 74);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 32);
            this.btnThoat.TabIndex = 39;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.Location = new System.Drawing.Point(544, 32);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(87, 32);
            this.btnTim.TabIndex = 38;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // ramasach
            // 
            this.ramasach.AutoSize = true;
            this.ramasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ramasach.Location = new System.Drawing.Point(48, 36);
            this.ramasach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ramasach.Name = "ramasach";
            this.ramasach.Size = new System.Drawing.Size(122, 28);
            this.ramasach.TabIndex = 33;
            this.ramasach.TabStop = true;
            this.ramasach.Text = "Mã độc giả";
            this.ramasach.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(197, 44);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(341, 23);
            this.txttimkiem.TabIndex = 37;
            // 
            // ratensach
            // 
            this.ratensach.AutoSize = true;
            this.ratensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ratensach.Location = new System.Drawing.Point(48, 78);
            this.ratensach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ratensach.Name = "ratensach";
            this.ratensach.Size = new System.Drawing.Size(130, 28);
            this.ratensach.TabIndex = 35;
            this.ratensach.TabStop = true;
            this.ratensach.Text = "Tên độc giả";
            this.ratensach.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(275, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "TÌM KIẾM ĐỘC GIẢ";
            // 
            // dgvTKDG
            // 
            this.dgvTKDG.AllowUserToAddRows = false;
            this.dgvTKDG.AllowUserToDeleteRows = false;
            this.dgvTKDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTKDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKDG.Location = new System.Drawing.Point(22, 195);
            this.dgvTKDG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTKDG.Name = "dgvTKDG";
            this.dgvTKDG.Size = new System.Drawing.Size(765, 258);
            this.dgvTKDG.TabIndex = 45;
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX.Location = new System.Drawing.Point(747, 14);
            this.btnX.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(40, 35);
            this.btnX.TabIndex = 56;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // FormTKDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 466);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.dgvTKDG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTKDG";
            this.Text = "Tìm kiếm độc giả";
            this.Load += new System.EventHandler(this.FormTKDG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.RadioButton ramasach;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.RadioButton ratensach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTKDG;
        private System.Windows.Forms.Button btnX;
    }
}