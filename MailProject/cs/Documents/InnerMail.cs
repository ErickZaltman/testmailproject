using System;


namespace MailProject
{
    public class InnerMail : Document
    {
        private int destination;
        private string files;
        private string text;
        private bool isRead;


        public int Destination
        {
            get
            {
                return destination;
            }

            set
            {
                destination = value;
            }
        }

        public string Files
        {
            get
            {
                return files;
            }

            set
            {
                files = value;
            }
        }

        public bool IsRead
        {
            get
            {
                return isRead;
            }

            set
            {
                isRead = value;
            }
        }
        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }
        public InnerMail(int ID, int AuthorID, string Text, string Theme, int Destination, string Files, bool IsRead)
        {
            this.ID = ID;
            this.AuthorID = AuthorID;
            this.Text = Text;
            this.Theme = Theme;
            this.Destination = Destination;
            this.Files = Files;
            this.IsRead = IsRead;
        }
        public InnerMail()
        {

        }
        public InnerMail(System.Data.DataRow dataRow)
        {
            ID = (int)dataRow["ID"];
            AuthorID = (int)dataRow["Author"];
            Text = (string)dataRow["Text"];
            Theme = (string)dataRow["Theme"];
            Destination = (int)dataRow["Destination"];
            Files = (string)dataRow["Files"];
            IsRead = (bool)dataRow["IsRead"];
            Date = (DateTime)dataRow["Date"];

        }
        

        
    }

}
