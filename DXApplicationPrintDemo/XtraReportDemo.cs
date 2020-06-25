using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DXApplicationPrintDemo
{
    public partial class XtraReportDemo : DXApplicationPrintDemo.XtraReportBase
    {
        public XtraReportDemo()
        {
            InitializeComponent();
        }

        private void XtraReportDemo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(this.Margins.Bottom.ToString());
        }

        private void XtraReportDemo_AfterPrint(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(this.Margins.Bottom.ToString());
        }
    }
}
