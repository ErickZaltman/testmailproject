using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MailProject
{
    public partial class UserControl1 : UserControl
    {
        private int id;
        private string theme;
        private string author;
        private DateTime date;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
                
            }
        }

        public string Theme
        {
            get
            {
                return theme;
                
            }

            set
            {
                theme = value;
                lblTheme.Text = theme;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
                lblAuthor.Text = author;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
                lblDate.Text = date.ToString();
            }
        }

        public UserControl1()
        {
            InitializeComponent();
        }
        public UserControl1(int id, string theme, string author, DateTime date)
        {
            this.id = id;
            this.theme = theme;
            this.author = author;
            this.date = date;
        }

    }
}
