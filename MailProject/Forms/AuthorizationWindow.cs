using System;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace MailProject.Forms
{
    public partial class AuthorizationWindow : Form
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AuthenticationCheck(tbLogin.Text,tbPassword.Text)) {
                MainWindow newWindow = new MainWindow();
                newWindow.Show();
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
                MessageBox.Show(":");
                return true;
            }
            return false;
        }
    }
}
