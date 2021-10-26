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
    public partial class Report_Tacgia : Form
    {
        ModelQLTV dbcontext;
        public Report_Tacgia()
        {
            dbcontext = new ModelQLTV();
            InitializeComponent();
        }

        private void Report_Tacgia_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "Report_Tacgia.rdlc";
            var reportDataSource = new ReportDataSource("DataSetTacgia",
                ConvertTacgia(dbcontext.TacGias.ToList())); //đúng tên dataset trong thiết kế 
            this.reportViewer1.LocalReport.DataSources.Clear();  //clear  
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
        public List<Class_rpTacgia> ConvertTacgia(List<TacGia> tacGias)
        {
            List<Class_rpTacgia> TGList = new List<Class_rpTacgia>();
            for (int i = 0; i < tacGias.Count; i++)
            {
                Class_rpTacgia TG = new Class_rpTacgia();
                TG.MaTG = tacGias[i].MaTG;
                TG.TenTG = tacGias[i].TenTG;
                TGList.Add(TG);
            }
            return TGList;
        }
    }
}
