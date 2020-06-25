namespace DXApplicationPrintDemo
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barSubItemNavigation = new DevExpress.XtraBars.BarSubItem();
            this.skinDropDownButtonItem = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinPaletteRibbonGalleryBarItem = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupNavigation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.officeNavigationBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.printNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemPrintDirectly = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemPreview = new DevExpress.XtraNavBar.NavBarItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barEditItemBottomMargin = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEditBottomMargin = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditBottomMargin)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.skinRibbonGalleryBarItem,
            this.barSubItemNavigation,
            this.skinDropDownButtonItem,
            this.skinPaletteRibbonGalleryBarItem,
            this.barEditItemBottomMargin});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 47;
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditBottomMargin});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(922, 160);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Id = 14;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // barSubItemNavigation
            // 
            this.barSubItemNavigation.Caption = "Navigation";
            this.barSubItemNavigation.Id = 15;
            this.barSubItemNavigation.ImageOptions.ImageUri.Uri = "NavigationBar";
            this.barSubItemNavigation.Name = "barSubItemNavigation";
            // 
            // skinDropDownButtonItem
            // 
            this.skinDropDownButtonItem.Id = 46;
            this.skinDropDownButtonItem.Name = "skinDropDownButtonItem";
            // 
            // skinPaletteRibbonGalleryBarItem
            // 
            this.skinPaletteRibbonGalleryBarItem.Caption = "$newskinpalettename$";
            this.skinPaletteRibbonGalleryBarItem.Id = 47;
            this.skinPaletteRibbonGalleryBarItem.Name = "skinPaletteRibbonGalleryBarItem";
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupNavigation,
            this.ribbonPageGroup,
            this.ribbonPageGroup1});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "View";
            // 
            // ribbonPageGroupNavigation
            // 
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.barSubItemNavigation);
            this.ribbonPageGroupNavigation.Name = "ribbonPageGroupNavigation";
            this.ribbonPageGroupNavigation.Text = "Module";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.AllowTextClipping = false;
            this.ribbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup.ItemLinks.Add(this.skinDropDownButtonItem);
            this.ribbonPageGroup.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.Text = "Appearance";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 621);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(922, 24);
            // 
            // officeNavigationBar
            // 
            this.officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar.Location = new System.Drawing.Point(0, 574);
            this.officeNavigationBar.Name = "officeNavigationBar";
            this.officeNavigationBar.NavigationClient = this.navBarControl;
            this.officeNavigationBar.Size = new System.Drawing.Size(922, 47);
            this.officeNavigationBar.TabIndex = 1;
            this.officeNavigationBar.Text = "officeNavigationBar";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.printNavBarGroup;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.printNavBarGroup});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemPrintDirectly,
            this.navBarItemPreview});
            this.navBarControl.Location = new System.Drawing.Point(0, 160);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 192;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(192, 414);
            this.navBarControl.TabIndex = 0;
            this.navBarControl.Text = "navBarControl";
            this.navBarControl.ActiveGroupChanged += new DevExpress.XtraNavBar.NavBarGroupEventHandler(this.navBarControl_ActiveGroupChanged);
            // 
            // printNavBarGroup
            // 
            this.printNavBarGroup.Caption = "PrintDemo";
            this.printNavBarGroup.Expanded = true;
            this.printNavBarGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemPrintDirectly),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemPreview)});
            this.printNavBarGroup.Name = "printNavBarGroup";
            // 
            // navBarItemPrintDirectly
            // 
            this.navBarItemPrintDirectly.Caption = "PrintDirectly";
            this.navBarItemPrintDirectly.Name = "navBarItemPrintDirectly";
            this.navBarItemPrintDirectly.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemPrintDirectly_LinkClicked);
            // 
            // navBarItemPreview
            // 
            this.navBarItemPreview.Caption = "Preview";
            this.navBarItemPreview.Name = "navBarItemPreview";
            this.navBarItemPreview.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemPreview_LinkClicked);
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItemBottomMargin);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "SetMargin";
            // 
            // barEditItemBottomMargin
            // 
            this.barEditItemBottomMargin.Caption = "BottomMargin";
            this.barEditItemBottomMargin.Edit = this.repositoryItemTextEditBottomMargin;
            this.barEditItemBottomMargin.EditValue = "100";
            this.barEditItemBottomMargin.Id = 46;
            this.barEditItemBottomMargin.Name = "barEditItemBottomMargin";
            this.barEditItemBottomMargin.EditValueChanged += new System.EventHandler(this.barEditItemBottomMargin_EditValueChanged);
            // 
            // repositoryItemTextEditBottomMargin
            // 
            this.repositoryItemTextEditBottomMargin.AutoHeight = false;
            this.repositoryItemTextEditBottomMargin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditBottomMargin.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditBottomMargin.Name = "repositoryItemTextEditBottomMargin";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 645);
            this.Controls.Add(this.navBarControl);
            this.Controls.Add(this.officeNavigationBar);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditBottomMargin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNavigation;
        private DevExpress.XtraBars.BarSubItem barSubItemNavigation;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup printNavBarGroup;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem;
        private DevExpress.XtraNavBar.NavBarItem navBarItemPrintDirectly;
        private DevExpress.XtraNavBar.NavBarItem navBarItemPreview;
        private DevExpress.XtraBars.BarEditItem barEditItemBottomMargin;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditBottomMargin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}