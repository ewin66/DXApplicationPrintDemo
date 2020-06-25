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
                    report.PrintingSystem.PageSettings.BottomMargin = int.Parse(barEditItemBottomMargin.EditValue.ToString());
                    ReportPrintTool printTool = new ReportPrintTool(report);
                    //report.CreateDocument();
                    printTool.PrintingSystem.ShowMarginsWarning = false;
                    printTool.AutoShowParametersPanel = false;
                    printTool.Report.;
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