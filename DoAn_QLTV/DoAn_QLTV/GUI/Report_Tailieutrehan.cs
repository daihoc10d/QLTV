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
    public partial class Report_Tailieutrehan : Form
    {
        ModelQLTV dbcontext;

        public Report_Tailieutrehan()
        {
            dbcontext = new ModelQLTV();

            InitializeComponent();
        }

        private void Report_Tailieutrehan_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "./GUI/Report_Tailieutrehan.rdlc";
            var reportDataSource = new ReportDataSource("DataSet_Tailieutrehan",
                ConvertTailieu(dbcontext.CTPhieuMuons.ToList())); //đúng tên dataset trong thiết kế 
            this.reportViewer1.LocalReport.DataSources.Clear();  //clear  
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }

        public List<Class_rpTailieu> ConvertTailieu(List<CTPhieuMuon> cTPhieuMuons)
        {
            List<Class_rpTailieu> TLList = new List<Class_rpTailieu>();
            DateTime ngayhnay = DateTime.Now;

            foreach (var item in cTPhieuMuons)
            {
                CTPhieuMuon com = dbcontext.CTPhieuMuons.FirstOrDefault(p => p.MaTaiLieu == item.MaTaiLieu.ToString());
                if (com.NgayTra < ngayhnay)
                {
                    Class_rpTailieu NV = new Class_rpTailieu();
                    NV.Matailieu = item.MaTaiLieu;
                    NV.Tentailieu = item.TaiLieu.TenTaiLieu;
                    NV.NamXB = (int)item.TaiLieu.NamXB;
                    NV.Theloai = item.TaiLieu.TheLoai.TenTheLoai;
                    NV.Tacgia = item.TaiLieu.TacGia.TenTG;
                    NV.NXB = item.TaiLieu.NhaXuatBan.TenNXB;
                    TLList.Add(NV);
                }
            }

            //for (int i = 0; i < cTPhieuMuons.Count; i++)
            //{
            //    CTPhieuMuon com = dbcontext.CTPhieuMuons.FirstOrDefault(p=>p.MaTaiLieu == cTPhieuMuons[i].MaTaiLieu.ToString());
            //    if (com.NgayTra.Date < ngayhnay.Date)
            //    {
            //        Class_rpTailieu NV = new Class_rpTailieu();
            //        NV.Matailieu = cTPhieuMuons[i].MaTaiLieu;
            //        NV.Tentailieu = cTPhieuMuons[i].TaiLieu.TenTaiLieu;
            //        NV.NamXB = (int)cTPhieuMuons[i].TaiLieu.NamXB;
            //        NV.Theloai = cTPhieuMuons[i].TaiLieu.TheLoai.TenTheLoai;
            //        NV.Tacgia = cTPhieuMuons[i].TaiLieu.TacGia.TenTG;
            //        NV.NXB = cTPhieuMuons[i].TaiLieu.NhaXuatBan.TenNXB;
            //        TLList.Add(NV);
            //    }
            //} 
            return TLList;
        }
    }
}
