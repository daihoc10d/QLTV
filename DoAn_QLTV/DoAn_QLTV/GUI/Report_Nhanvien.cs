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
using DoAn_QLTV;
using DoAn_QLTV.Model;
using Microsoft.Reporting.WinForms;
using DoAn_QLTV.Class;

namespace DoAn_QLTV.GUI
{
    public partial class Report_Nhanvien : Form
    {
        ModelQLTV dbcontext;
        public Report_Nhanvien()
        {
            dbcontext = new ModelQLTV();
            InitializeComponent();
        }

        private void Report_Nhanvien_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "Report_Nhanvien.rdlc";
            var reportDataSource = new ReportDataSource("DataSetNhanvien",
                ConvertNhanvien(dbcontext.NhanViens.ToList())); //đúng tên dataset trong thiết kế 
            this.reportViewer1.LocalReport.DataSources.Clear();  //clear  
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
        public List<Class_rpNhanvien> ConvertNhanvien(List<NhanVien> nhanViens)
        {

            List<Class_rpNhanvien> NVList = new List<Class_rpNhanvien>();
            for (int i = 0; i < nhanViens.Count; i++)
            {
                Class_rpNhanvien NV = new Class_rpNhanvien();
                NV.MaNV = nhanViens[i].MaNV;
                NV.TenNV = nhanViens[i].TenNV;
                NV.Ngaysinh = (DateTime)nhanViens[i].NgaySinh;
                NV.Gioitinh = nhanViens[i].GioiTinh;
                NV.Diachi = nhanViens[i].DiaChi;
                NV.SDT = nhanViens[i].SDT;
                NVList.Add(NV);

            }
            return NVList;

        }
    }
}
