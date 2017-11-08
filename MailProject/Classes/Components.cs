using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MailProject
{
    public class TableName
    {
        private TableName(string value) { Value = value; }

        public string Value { get; set; }

        public static TableName InnerMail { get { return new TableName("InnerMail"); } }
        public static TableName Departments { get { return new TableName("Departments"); } }
        public static TableName Contractors { get { return new TableName("Contractors"); } }
        public static TableName IncomingMail { get { return new TableName("IncomingMail"); } }
        public static TableName OutgoingMail { get { return new TableName("OutgoingMail"); } }
        public static TableName ServiceMail { get { return new TableName("ServiceMail"); } }
        public static TableName TreatmentMail { get { return new TableName("TreatmentMail"); } }
        public static TableName UserInfo { get { return new TableName("UserInfo"); } }
        public static TableName User { get { return new TableName("User"); } }
    }
  

    public class Document
    {
        private int id;
        private int authorID;
        private DateTime date;
        private string theme;

        public int ID
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

        public int AuthorID
        {
            get
            {
                return authorID;
            }

            set
            {
                authorID = value;
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
            }
        }
    }   
    

    public class ConnectionToServer
    {

        private string host;
        private string serverName;
        private string baseName;
        private string connectionString;
        private SqlConnection connection;

        public string Host
        {
            get
            {
                return host;
            }

            set
            {
                host = value;
            }
        }
        public string ServerName
        {
            get
            {
                return serverName;
            }

            set
            {
                serverName = value;
            }
        }
        public string BaseName
        {
            get
            {
                return baseName;
            }

            set
            {
                baseName = value;
            }
        }
        public SqlConnection Connection
        {
            get
            {
                return connection;
            }

            set
            {
                connection = value;
            }
        }

        public void Connect()
        {

            connectionString = "Data Source = " + serverName + "; Initial Catalog = " + baseName + "; Integrated Security = True";
            Connection = new SqlConnection(connectionString);
            try
            {
                Connection.Open();
                Connection.Close();
            }
            catch
            {

            }

        }


        public Person getPerson(string login)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT dbo.UserInfo.* , dbo.Users.Login FROM dbo.UserInfo INNER JOIN dbo.Users ON dbo.UserInfo.ID = dbo.Users.ID WHERE dbo.Users.Login = '" + login + "'";
                connection.Open();
            SqlDataAdapter sqladd = new SqlDataAdapter(cmd);

            sqladd.Fill(dt);
            connection.Close();
            //Person tmpPerson = new Person(dt.Rows[0]);

            return new Person(dt.Rows[0]);
        }
        public List<Person> getUsersList()
        {
            List<Person> tmpList = new List<Person>();

            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT dbo.UserInfo.* , dbo.Users.Login FROM dbo.UserInfo INNER JOIN dbo.Users ON dbo.UserInfo.ID = dbo.Users.ID";
            connection.Open();
            SqlDataAdapter sqladd = new SqlDataAdapter(cmd);

            sqladd.Fill(dt);
            connection.Close();

            foreach (DataRow row in dt.Rows)
            {
                tmpList.Add(new Person(row));
            }

            return tmpList;
        }

        

        public DataRow getDocumentInfo(int mailID, string tableName)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT dbo." + tableName + ".* FROM dbo." + tableName + " INNER JOIN dbo.Users ON dbo." + tableName + ".ID = dbo.Users.ID WHERE(dbo.InnerMail.ID = " + mailID + ")";

            connection.Open();
            SqlDataAdapter sqladd = new SqlDataAdapter(cmd);
            sqladd.Fill(dt);
            connection.Close();


            return (dt.Rows[0]);
        }


        public List<InnerMail> getInnerIncomingMailHead(Person user)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT dbo.InnerMail.ID, dbo.InnerMail.Author, dbo.InnerMail.Theme, dbo.InnerMail.Date, dbo.InnerMail.IsRead FROM dbo.InnerMail  WHERE(dbo.InnerMail.Destination = " + user.Id + ")";

            connection.Open();
            SqlDataAdapter sqladd = new SqlDataAdapter(cmd);
            sqladd.Fill(dt);
            connection.Close();
            List<InnerMail> tmpList = new List<InnerMail>();
            foreach (DataRow row in dt.Rows)
            {
                tmpList.Add(new InnerMail(row, false));
            }
            return tmpList;
        }
        public List<InnerMail> getInnerOutgoingMailHead(Person user)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT dbo.InnerMail.ID, dbo.InnerMail.Destination, dbo.InnerMail.Theme, dbo.InnerMail.Date, dbo.InnerMail.IsRead FROM dbo.InnerMail WHERE(dbo.InnerMail.Author = " + user.Id + ")";

            connection.Open();
            SqlDataAdapter sqladd = new SqlDataAdapter(cmd);
            sqladd.Fill(dt);
            connection.Close();

            List<InnerMail> tmpList = new List<InnerMail>();
            foreach (DataRow row in dt.Rows)
            {
                tmpList.Add(new InnerMail(user.Id, row));
            }

            return tmpList;
        }

        public List<IncomingMail> getIncomingMailHead()
        {

            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT dbo.IncomingMail.ID, dbo.IncomingMail.DocumentAuthor, dbo.IncomingMail.Theme, dbo.IncomingMail.Date, dbo.IncomingMail.Sender FROM dbo.IncomingMail";

            connection.Open();
            SqlDataAdapter sqladd = new SqlDataAdapter(cmd);
            sqladd.Fill(dt);
            connection.Close();

            List<IncomingMail> tmpList = new List<IncomingMail>();
            foreach (DataRow row in dt.Rows)
            {
                tmpList.Add(new IncomingMail(row, false));
            }


            return tmpList;
        }


        public string getPersonNameByID(int id)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT dbo.UserInfo.Surname, dbo.UserInfo.FirstName, dbo.UserInfo.Patronymic FROM dbo.UserInfo Where dbo.UserInfo.ID = " + id;

            connection.Open();
            SqlDataAdapter sqladd = new SqlDataAdapter(cmd);
            sqladd.Fill(dt);
            connection.Close();

            
            return (string)dt.Rows[0]["Surname"] + " " + ((string)dt.Rows[0]["FirstName"])[0] + "." + ((string)dt.Rows[0]["Patronymic"])[0];
        }






    }

}
