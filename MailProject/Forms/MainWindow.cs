using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MailProject
{
    public partial class MainWindow : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private Person currentUser;
        ConnectionToServer serverConnection;
        public void InitSettings()
        {
            serverConnection = new ConnectionToServer();
            serverConnection.ServerName = @"WSCH-666\zalupakita";
            serverConnection.BaseName = "TestMailBase";
            serverConnection.Connect();

            currentUser = serverConnection.getPersonInfo(Environment.UserName);

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



    }
}
