using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MailProject
{
    public partial class MainWindow : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
            getMail();

        }
        private void getMail()
        {
            DataTable dt = serverConnection.getInnerIncomingMailHead(currentUser);
            tbLogInfo.Text += "\r\n" + dt.Rows.Count;
            tbLogInfo.Text += ";" + dt.Rows[0]["Theme"].ToString() + ";" + dt.Rows[0]["Author"].ToString();

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

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbLogInfo.Text = currentUser.ToString();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
    }
}
