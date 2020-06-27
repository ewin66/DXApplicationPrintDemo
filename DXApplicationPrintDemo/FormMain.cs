using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System.Drawing.Printing;

namespace DXApplicationPrintDemo
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int BottomMargin = 0;
        public FormMain()
        {
            InitializeComponent();
        }
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            ////navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
        }

        private void navBarItemPrintDirectly_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                using (XtraReportDemo report = new XtraReportDemo())
                {
                    ReportPrintTool printTool = new ReportPrintTool(report);
                   
                    report.Margins.Left = 0;    //work
                    report.Margins.Right = 0;   //work
                    report.Margins.Top = 200;     //not work
                    report.Margins.Bottom = 200;  //not work

                    PrinterSettings ps = new PrinterSettings(); //use PrinterName if the printer is not the default one  
                    ////ps.PrinterName = ""; //Specify PrinterName
                    using (Graphics g = ps.CreateMeasurementGraphics(ps.DefaultPageSettings))
                    {
                        var margins = DevExpress.XtraPrinting.Native.DeviceCaps.GetMinMargins(g); //in default report units; do conversion with the help PSUnitConverter when needed
                    }

                    report.CreateDocument();
                    report.PrintingSystem.ShowMarginsWarning = false;

                    printTool.Print();
                }
            }
            catch (OutOfMemoryException catchOutOfMemoryException)
            {
            }
            catch (Exception catchException)
            {
            }
            finally
            {
            }
        }

        private void navBarItemPreview_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                using (XtraReportDemo report = new XtraReportDemo())
                {
                    PrinterSettings ps = new PrinterSettings(); //use PrinterName if the printer is not the default one  
                    ////ps.PrinterName = ""; //Specify PrinterName
                    using (Graphics g = ps.CreateMeasurementGraphics(ps.DefaultPageSettings))
                    {
                        var margins = DevExpress.XtraPrinting.Native.DeviceCaps.GetMinMargins(g); //in default report units; do conversion with the help PSUnitConverter when needed
                    }

                    report.Margins.Left = 0;    //work
                    report.Margins.Right = 0;   //work
                    report.Margins.Top = 200;     //not work
                    report.Margins.Bottom = 200;  //not work

                    ReportPrintTool printTool = new ReportPrintTool(report);
                    //report.CreateDocument();
                    printTool.PrintingSystem.ShowMarginsWarning = false;
                    printTool.AutoShowParametersPanel = false;
                    printTool.ShowPreviewDialog();
                    printTool.Dispose();
                    //SetShowPreviewTools(report);
                }
            }
            catch (Exception catchException)
            {
            }
            finally
            {
            }
        }

        private void barEditItemBottomMargin_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}