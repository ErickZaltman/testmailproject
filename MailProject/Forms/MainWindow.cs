using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MailProject
{
    public partial class MainWindow : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Type currentType;
        List<Person> usersCollection;
        private Person currentUser;
        ConnectionToServer serverConnection;
        public void InitSettings()
        {
            serverConnection = new ConnectionToServer();
            serverConnection.ServerName = @"WSCH-666\zalupakita";
            serverConnection.BaseName = "TestMailBase";
            serverConnection.Connect();

            currentUser = serverConnection.getPerson(Environment.UserName);

            tbLogInfo.Text = currentUser.ToString();

        }
       






        public MainWindow()
        {
            InitializeComponent();
            currentUser = new Person();
            InitSettings();

        }






        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            MessageBox.Show(e.NewValue.ToString());
        }

        private void barButtonLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Authorization();
        }

        void dataFunc(string data)
        {
            
            currentUser.LoginName = data;
        }
        private void Authorization()
        {
            
            Forms.AuthorizationWindow newAuthForm = new Forms.AuthorizationWindow(dataFunc);

            newAuthForm.ShowDialog();
            if (newAuthForm.DialogResult == DialogResult.OK)
            {
                navBarControlMain.Visible = true;
                //barButtonLogin.Visibility = /*DevExpress.XtraBars.BarItemVisibility*/;
                //MessageBox.Show(Environment.UserDomainName);
                //MessageBox.Show(Environment.UserName);

            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            clearLog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            usersCollection = serverConnection.getUsersList();
            clearLog();
            foreach (Person tmpPerson in usersCollection)
            {
                tbLogInfo.Text += tmpPerson.Id + ";" + tmpPerson.LoginName + ";" + "\r\n";
            }
            

        }
        private void clearLog()
        {
            tbLogInfo.Text = "";
        }

        



        private void fillDGVInnerIncomingMail()
        {
            dgvMain.DataSource = serverConnection.getInnerIncomingMailHead(currentUser);
            dgvMain.Columns["ID"].Visible = false;
            dgvMain.Columns["IsRead"].Visible = false;
            foreach(DataGridViewRow dgvRow in dgvMain.Rows)
            {
                if ((bool)dgvRow.Cells["IsRead"].Value == false)
                {
                    dgvRow.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
                }
            }
        }
        private void fillDGVInnerOutgoingMail()
        {
            dgvMain.DataSource = serverConnection.getInnerOutgoingMailHead(currentUser);
            dgvMain.Columns["ID"].Visible = false;
            dgvMain.Columns["IsRead"].Visible = false;
        }
        private void fillDGVIncomingMail()
        {
            dgvMain.DataSource = serverConnection.getIncomingMailHead();
            dgvMain.Columns["ID"].Visible = false;

        }
        private void fillDGVOutgoingMail()
        {
            dgvMain.DataSource = serverConnection.getOutgoingMailHead();
            dgvMain.Columns["ID"].Visible = false;
        }
        private void fillDGVServiceMail()
        {
            dgvMain.DataSource = serverConnection.getServiceMailHead();
            dgvMain.Columns["ID"].Visible = false;
        }




        private void navBarItemInnerIncoming_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            currentType = typeof(InnerMail);
            fillDGVInnerIncomingMail();
            

        }
        private void navBarItemInnerOutgoing_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            currentType = typeof(InnerMail);
            fillDGVInnerOutgoingMail();
        }
        private void navBarItemOuterIncomingMail_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            currentType = typeof(IncomingMail);
            fillDGVIncomingMail();
        }

        private void navBarItemOuterOutgoingMail_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fillDGVOutgoingMail();
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(currentType.ToString());
        }

        private void navBarItemServiceMail_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fillDGVServiceMail();
        }
    }
}
