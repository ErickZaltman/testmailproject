using System;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace MailProject.Forms
{
    public partial class AuthorizationWindow : Form
    {
        MainWindow mainForm;
        public AuthorizationWindow()
        {
            InitializeComponent();
            mainForm = Owner as MainWindow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AuthenticationCheck(tbLogin.Text,tbPassword.Text)) {
                mainForm.userName = tbLogin.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль");
            }

        }

        private bool AuthenticationCheck(string login, string password)
        {
            PrincipalContext pcon = new PrincipalContext(ContextType.Domain);
            if (pcon.ValidateCredentials(login, password, ContextOptions.Negotiate))
            {
                return true;
            }
            return false;
        }
    }
}
