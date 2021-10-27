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
    public partial class Report_Docgiatrehan : Form
    {
        ModelQLTV dbcontext;

        public Report_Docgiatrehan()
        {
            dbcontext = new ModelQLTV();

            InitializeComponent();
        }

        private void Report_Docgiatrehan_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "Report_Docgiatrehan.rdlc";
            var reportDataSource = new ReportDataSource("DataSet_Docgiatrehan",
                ConvertDocgia(dbcontext.CTPhieuMuons.ToList())); //đúng tên dataset trong thiết kế 
            this.reportViewer1.LocalReport.DataSources.Clear();  //clear  
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
        public List<Class_rpDocgia> ConvertDocgia(List<CTPhieuMuon> cTPhieuMuons)
        {
            List<Class_rpDocgia> TLList = new List<Class_rpDocgia>();
            DateTime ngayhnay = DateTime.Now;

            for (int i = 0; i < cTPhieuMuons.Count; i++)
            {
                CTPhieuMuon com = dbcontext.CTPhieuMuons.FirstOrDefault(p => p.MaTaiLieu == cTPhieuMuons[i].MaTaiLieu.ToString());
                if (com.NgayTra.Date < ngayhnay.Date)
                {
                    Class_rpDocgia DG = new Class_rpDocgia();
                    DG.MaDG = cTPhieuMuons[i].PhieuMuon.MaDG;
                    DG.TenDG = cTPhieuMuons[i].PhieuMuon.DocGia.TenDG;
                    DG.Ngaysinh = (DateTime)cTPhieuMuons[i].PhieuMuon.DocGia.NgaySinh;
                    DG.Gioitinh = cTPhieuMuons[i].PhieuMuon.DocGia.GioiTinh;
                    DG.Lop = cTPhieuMuons[i].PhieuMuon.DocGia.Lop;
                    TLList.Add(DG);
                }
            }
            return TLList;
        }
    }
}
