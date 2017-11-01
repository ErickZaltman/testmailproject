namespace MailProject
{
    partial class MainWindow
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonLogin = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupNewDocuments = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.navBarControlMain = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGrInnerMail = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemInnerIncoming = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemInnerOutgoing = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGrOutterMail = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemOuterIncomingMail = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemOuterOutgoingMail = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemTreatmentMail = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarInnerDocuments = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemServiceMail = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemOrders = new DevExpress.XtraNavBar.NavBarItem();
            this.tbLogInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonLogin});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(868, 143);
            // 
            // barButtonLogin
            // 
            this.barButtonLogin.Caption = "Войти в систему";
            this.barButtonLogin.Id = 5;
            this.barButtonLogin.Name = "barButtonLogin";
            this.barButtonLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonLogin_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupNewDocuments});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroupNewDocuments
            // 
            this.ribbonPageGroupNewDocuments.ItemLinks.Add(this.barButtonLogin);
            this.ribbonPageGroupNewDocuments.Name = "ribbonPageGroupNewDocuments";
            this.ribbonPageGroupNewDocuments.Text = "etc";
            // 
            // navBarControlMain
            // 
            this.navBarControlMain.ActiveGroup = this.navBarGrInnerMail;
            this.navBarControlMain.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGrInnerMail,
            this.navBarGrOutterMail,
            this.navBarInnerDocuments});
            this.navBarControlMain.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemInnerIncoming,
            this.navBarItemInnerOutgoing,
            this.navBarItemOuterIncomingMail,
            this.navBarItemOuterOutgoingMail,
            this.navBarItemTreatmentMail,
            this.navBarItemServiceMail,
            this.navBarItemOrders});
            this.navBarControlMain.Location = new System.Drawing.Point(0, 149);
            this.navBarControlMain.Name = "navBarControlMain";
            this.navBarControlMain.OptionsNavPane.ExpandedWidth = 199;
            this.navBarControlMain.Size = new System.Drawing.Size(199, 263);
            this.navBarControlMain.TabIndex = 1;
            this.navBarControlMain.Text = "navBarControl1";
            // 
            // navBarGrInnerMail
            // 
            this.navBarGrInnerMail.Caption = "Внутренняя Почта";
            this.navBarGrInnerMail.Expanded = true;
            this.navBarGrInnerMail.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemInnerIncoming),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemInnerOutgoing)});
            this.navBarGrInnerMail.Name = "navBarGrInnerMail";
            // 
            // navBarItemInnerIncoming
            // 
            this.navBarItemInnerIncoming.Caption = "Входящие";
            this.navBarItemInnerIncoming.Name = "navBarItemInnerIncoming";
            // 
            // navBarItemInnerOutgoing
            // 
            this.navBarItemInnerOutgoing.Caption = "Отправленные";
            this.navBarItemInnerOutgoing.Name = "navBarItemInnerOutgoing";
            // 
            // navBarGrOutterMail
            // 
            this.navBarGrOutterMail.Caption = "Внешняя корреспонденция";
            this.navBarGrOutterMail.Expanded = true;
            this.navBarGrOutterMail.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemOuterIncomingMail),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemOuterOutgoingMail),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemTreatmentMail)});
            this.navBarGrOutterMail.Name = "navBarGrOutterMail";
            // 
            // navBarItemOuterIncomingMail
            // 
            this.navBarItemOuterIncomingMail.Caption = "Входящие письма";
            this.navBarItemOuterIncomingMail.Name = "navBarItemOuterIncomingMail";
            // 
            // navBarItemOuterOutgoingMail
            // 
            this.navBarItemOuterOutgoingMail.Caption = "Исходящие письма";
            this.navBarItemOuterOutgoingMail.Name = "navBarItemOuterOutgoingMail";
            // 
            // navBarItemTreatmentMail
            // 
            this.navBarItemTreatmentMail.Caption = "Жалобы и обращения";
            this.navBarItemTreatmentMail.Name = "navBarItemTreatmentMail";
            // 
            // navBarInnerDocuments
            // 
            this.navBarInnerDocuments.Caption = "Служебные записки и приказы";
            this.navBarInnerDocuments.Expanded = true;
            this.navBarInnerDocuments.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarInnerDocuments.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemServiceMail),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemOrders)});
            this.navBarInnerDocuments.Name = "navBarInnerDocuments";
            // 
            // navBarItemServiceMail
            // 
            this.navBarItemServiceMail.Caption = "Служебные записки";
            this.navBarItemServiceMail.Name = "navBarItemServiceMail";
            // 
            // navBarItemOrders
            // 
            this.navBarItemOrders.Caption = "Приказы";
            this.navBarItemOrders.Name = "navBarItemOrders";
            // 
            // tbLogInfo
            // 
            this.tbLogInfo.Location = new System.Drawing.Point(0, 479);
            this.tbLogInfo.Multiline = true;
            this.tbLogInfo.Name = "tbLogInfo";
            this.tbLogInfo.Size = new System.Drawing.Size(868, 56);
            this.tbLogInfo.TabIndex = 5;
            // 
            // MainWindow
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 533);
            this.Controls.Add(this.tbLogInfo);
            this.Controls.Add(this.navBarControlMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainWindow";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNewDocuments;
        private DevExpress.XtraNavBar.NavBarControl navBarControlMain;
        private DevExpress.XtraNavBar.NavBarGroup navBarGrInnerMail;
        private DevExpress.XtraNavBar.NavBarItem navBarItemInnerIncoming;
        private DevExpress.XtraNavBar.NavBarItem navBarItemInnerOutgoing;
        private DevExpress.XtraNavBar.NavBarGroup navBarGrOutterMail;
        private DevExpress.XtraNavBar.NavBarItem navBarItemOuterIncomingMail;
        private DevExpress.XtraNavBar.NavBarItem navBarItemOuterOutgoingMail;
        private DevExpress.XtraNavBar.NavBarItem navBarItemTreatmentMail;
        private DevExpress.XtraNavBar.NavBarGroup navBarInnerDocuments;
        private DevExpress.XtraNavBar.NavBarItem navBarItemServiceMail;
        private DevExpress.XtraNavBar.NavBarItem navBarItemOrders;
        private DevExpress.XtraBars.BarButtonItem barButtonLogin;
        private System.Windows.Forms.TextBox tbLogInfo;
    }
}

