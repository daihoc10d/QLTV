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
    public partial class Report_Docgia : Form
    {
        ModelQLTV dbcontext;
        public Report_Docgia()
        {
            dbcontext = new ModelQLTV();

            InitializeComponent();
        }

        private void Report_Docgia_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "Report_Docgia.rdlc";
            var reportDataSource = new ReportDataSource("DataSet_Docgia",
                ConvertNhanvien(dbcontext.DocGias.ToList())); //đúng tên dataset trong thiết kế 
            this.reportViewer1.LocalReport.DataSources.Clear();  //clear  
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
        public List<Class_rpDocgia> ConvertNhanvien(List<DocGia> docGias)
        {

            List<Class_rpDocgia> DGList = new List<Class_rpDocgia>();
            for (int i = 0; i < docGias.Count; i++)
            {
                Class_rpDocgia DG = new Class_rpDocgia();
                DG.MaDG = docGias[i].MaDG;
                DG.TenDG = docGias[i].TenDG;
                DG.Ngaysinh = (DateTime)docGias[i].NgaySinh;
                DG.Gioitinh = docGias[i].GioiTinh;
                DG.Lop = docGias[i].Lop;
                DGList.Add(DG);

            }
            return DGList;

        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
