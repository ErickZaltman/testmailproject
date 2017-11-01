using System;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace MailProject.Forms
{
    public partial class AuthorizationWindow : Form
    {
        private delegateFunc d;
        public AuthorizationWindow()
        {
            InitializeComponent();
        }
        public AuthorizationWindow(delegateFunc sender)
        {
            InitializeComponent();
            d = sender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorization();
        }

        private void Autorization()
        {
            if (AuthenticationCheck(tbLogin.Text, tbPassword.Text))
            {
                d(tbLogin.Text);
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

      
        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Autorization();
        }

        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Autorization();
        }
    }
}
