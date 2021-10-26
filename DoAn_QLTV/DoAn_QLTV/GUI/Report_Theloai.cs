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
    public partial class Report_Theloai : Form
    {
        ModelQLTV dbcontext;

        public Report_Theloai()
        {
            dbcontext = new ModelQLTV();

            InitializeComponent();
        }

        private void Report_Theloai_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "Report_Theloai.rdlc";
            var reportDataSource = new ReportDataSource("DataSetTheloai",
                ConvertTheloai(dbcontext.TheLoais.ToList())); //đúng tên dataset trong thiết kế 
            this.reportViewer1.LocalReport.DataSources.Clear();  //clear  
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
        public List<Class_rpTheloai> ConvertTheloai(List<TheLoai> theLoais)
        {

            List<Class_rpTheloai> TLList = new List<Class_rpTheloai>();
            for (int i = 0; i < theLoais.Count; i++)
            {
                Class_rpTheloai TL = new Class_rpTheloai();
                TL.MaTL = theLoais[i].MaTheLoai;
                TL.TenTL = theLoais[i].TenTheLoai;
                TLList.Add(TL);

            }
            return TLList;

        }
    }
}
