using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_QLTV.Model;
using DoAn_QLTV.Class;

namespace DoAn_QLTV.GUI
{
    public partial class Report_Muontra : Form
    {
        ModelQLTV dbcontext;
        public Report_Muontra()
        {
            dbcontext = new ModelQLTV();
            InitializeComponent();
        }

        private void Report_Muontra_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "Report_Muontra.rdlc";
            var reportDataSource = new ReportDataSource("DataSet_Muontra",
                ConvertNhanvien(dbcontext.CTPhieuMuons.ToList())); //đúng tên dataset trong thiết kế 
            this.reportViewer1.LocalReport.DataSources.Clear();  //clear  
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
        public List<Class_rpMuontra> ConvertNhanvien(List<CTPhieuMuon> cTPhieuMuons)
        {

            List<Class_rpMuontra> MTList = new List<Class_rpMuontra>();
            for (int i = 0; i < cTPhieuMuons.Count; i++)
            {
                Class_rpMuontra MT = new Class_rpMuontra();
                MT.MaPM = cTPhieuMuons[i].MaPM;
                MT.TenDG = cTPhieuMuons[i].PhieuMuon.DocGia.TenDG;
                MT.Nhanvien = cTPhieuMuons[i].PhieuMuon.NhanVien.TenNV;
                MT.Tailieu = cTPhieuMuons[i].TaiLieu.TenTaiLieu;
                MT.Ngaymuon = (DateTime)cTPhieuMuons[i].NgayMuon;
                MT.Ngaytra = (DateTime)cTPhieuMuons[i].NgayTra;
                MT.Tinhtrang = cTPhieuMuons[i].TinhTrang;
                MTList.Add(MT);
            }
            return MTList;

        }
    }
}
