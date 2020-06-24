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

namespace DXApplicationPrintDemo
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
                    report.CreateDocument();
                    report.PrintingSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
                    report.PrintingSystem.PageSettings.BottomMargin = 0;
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
    }
}