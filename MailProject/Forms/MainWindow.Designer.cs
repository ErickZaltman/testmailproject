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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
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
            this.ribbonControl1.MaxItemId = 18;
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
            this.barButtonItem1.Id = 12;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 13;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 14;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Id = 15;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Id = 16;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Id = 17;
            this.barButtonItem6.Name = "barButtonItem6";
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
            this.navBarItemInnerIncoming.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemInnerIncoming_LinkClicked);
            // 
            // navBarItemInnerOutgoing
            // 
            this.navBarItemInnerOutgoing.Caption = "Отправленные";
            this.navBarItemInnerOutgoing.Name = "navBarItemInnerOutgoing";
            this.navBarItemInnerOutgoing.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemInnerOutgoing_LinkClicked);
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
            this.navBarItemOuterIncomingMail.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemOuterIncomingMail_LinkClicked);
            // 
            // navBarItemOuterOutgoingMail
            // 
            this.navBarItemOuterOutgoingMail.Caption = "Исходящие письма";
            this.navBarItemOuterOutgoingMail.Name = "navBarItemOuterOutgoingMail";
            this.navBarItemOuterOutgoingMail.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemOuterOutgoingMail_LinkClicked);
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
            this.navBarItemServiceMail.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemServiceMail_LinkClicked);
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
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMain.Location = new System.Drawing.Point(212, 140);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMain.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(656, 314);
            this.dgvMain.TabIndex = 9;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            // 
            // MainWindow
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 533);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.tbLogInfo);
            this.Controls.Add(this.navBarControlMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainWindow";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvMain;
    }
}
