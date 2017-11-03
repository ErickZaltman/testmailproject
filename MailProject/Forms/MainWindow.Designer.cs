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
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupNewDocuments = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnTestGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.btnClearLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonLogin,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
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
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "СписокПользователей";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Текущий Пользователь";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Входящая почта";
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Исходящая почта";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 10;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 11;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupNewDocuments,
            this.rbnTestGroup});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroupNewDocuments
            // 
            this.ribbonPageGroupNewDocuments.ItemLinks.Add(this.barButtonLogin);
            this.ribbonPageGroupNewDocuments.Name = "ribbonPageGroupNewDocuments";
            this.ribbonPageGroupNewDocuments.Text = "etc";
            // 
            // rbnTestGroup
            // 
            this.rbnTestGroup.ItemLinks.Add(this.barButtonItem1);
            this.rbnTestGroup.ItemLinks.Add(this.barButtonItem2);
            this.rbnTestGroup.ItemLinks.Add(this.barButtonItem3);
            this.rbnTestGroup.ItemLinks.Add(this.barButtonItem4);
            this.rbnTestGroup.ItemLinks.Add(this.barButtonItem5);
            this.rbnTestGroup.ItemLinks.Add(this.barButtonItem6);
            this.rbnTestGroup.Name = "rbnTestGroup";
            this.rbnTestGroup.Text = "Проверочная Группа";
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
            this.navBarControlMain.Location = new System.Drawing.Point(0, 140);
            this.navBarControlMain.Name = "navBarControlMain";
            this.navBarControlMain.OptionsNavPane.ExpandedWidth = 199;
            this.navBarControlMain.Size = new System.Drawing.Size(199, 272);
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
            this.tbLogInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogInfo.Location = new System.Drawing.Point(0, 460);
            this.tbLogInfo.Multiline = true;
            this.tbLogInfo.Name = "tbLogInfo";
            this.tbLogInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLogInfo.Size = new System.Drawing.Size(868, 75);
            this.tbLogInfo.TabIndex = 5;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(746, 25);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 7;
            this.btnClearLog.Text = "Очистить";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // MainWindow
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 533);
            this.Controls.Add(this.btnClearLog);
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
        private System.Windows.Forms.Button btnClearLog;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnTestGroup;
    }
}
