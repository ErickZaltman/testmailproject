using System.Windows.Forms;

namespace MailProject
{
    public partial class MainWindow : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private Person currentUser;
        public string userName;

        //public Person CurrentUser
        //{
        //    get
        //    {
        //        return currentUser;
        //    }

        //    set
        //    {
        //        currentUser = value;
        //    }
        //}

        public MainWindow()
        {
            InitializeComponent();
            

            navBarControlMain.Visible = false;

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void barButtonLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Authorize();
        }

       
        private void Authorize()
        {
           
            Forms.AuthorizationWindow newAuthForm = new Forms.AuthorizationWindow();
            newAuthForm.Owner = this;
            newAuthForm.ShowDialog();
            if (newAuthForm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("sdfsd");
            }
        }

        

    }
}
