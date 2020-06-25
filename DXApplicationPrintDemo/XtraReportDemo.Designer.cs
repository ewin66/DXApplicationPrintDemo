namespace DXApplicationPrintDemo
{
    partial class XtraReportDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // XtraReportDemo
            // 
            this.Version = "19.2";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.XtraReportDemo_BeforePrint);
            this.AfterPrint += new System.EventHandler(this.XtraReportDemo_AfterPrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion


    }
}
