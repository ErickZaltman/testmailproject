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

       
        public override string ToString()
        {
            return id + ";" + authorID + ";" + theme + ";" + date;
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

        

        public InnerMail getInnerMailInfo(int mailID)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT dbo.InnerMail.* FROM dbo.InnerMail WHERE(dbo.InnerMail.ID = " + mailID + ")";

            connection.Open();
            SqlDataAdapter sqladd = new SqlDataAdapter(cmd);
            sqladd.Fill(dt);
            connection.Close();


            return (new InnerMail(dt.Rows[0]));
        }


        public DataTable getInnerOutgoingMailHead(Person user)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT InnerMail.ID, InnerMail.Theme, InnerMail.Date, InnerMail.IsRead, " +
                 "UserInfo.Surname + ' ' + Left(UserInfo.FirstName, 1) +'.' + Left(UserInfo.Patronymic,1) +'.' as Destination " +
                 "FROM InnerMail INNER JOIN UserInfo ON InnerMail.Destination = UserInfo.ID " +
                 "WHERE InnerMail.Author = " + user.Id;

            connection.Open();
            SqlDataAdapter sqladd = new SqlDataAdapter(cmd);
            sqladd.Fill(dt);
            connection.Close();
            List<InnerMail> tmpList = new List<InnerMail>();
           
            return dt;
        }
        public DataTable getInnerIncomingMailHead(Person user)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT InnerMail.ID, InnerMail.Theme, InnerMail.Date, InnerMail.IsRead, " +
                "UserInfo.Surname + ' ' + Left(UserInfo.FirstName, 1) +'.' + Left(UserInfo.Patronymic,1) +'.' as Author " +
                "FROM InnerMail INNER JOIN UserInfo ON InnerMail.Author = UserInfo.ID " +
                "WHERE InnerMail.Destination = " + user.Id;

            connection.Open();
            SqlDataAdapter sqladd = new SqlDataAdapter(cmd);
            sqladd.Fill(dt);
            connection.Close();

            List<InnerMail> tmpList = new List<InnerMail>();
            

            return dt;
        }
        public DataTable getOutgoingMailHead()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT OutgoingMail.ID, OutgoingMail.Date, OutgoingMail.Theme, OutgoingMail.RegNumber, UserInfo.Surname + ' ' + left(UserInfo.FirstName,1) + '.' + left(UserInfo.Patronymic,1) as Author " + 
                "FROM OutgoingMail INNER JOIN " +
                "UserInfo ON OutgoingMail.AuthorID = UserInfo.ID";

            connection.Open();
            SqlDataAdapter sqladd = new SqlDataAdapter(cmd);
            sqladd.Fill(dt);
            connection.Close();

            List<InnerMail> tmpList = new List<InnerMail>();
            

            return dt;
        }
        public DataTable getServiceMailHead()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT ServiceMail.ID, ServiceMail.Date, ServiceMail.Theme, ServiceMail.RegNumber, UserInfo.Surname + ' ' + left(UserInfo.FirstName,1) + '.' + left(UserInfo.Patronymic,1) as Author " +
                "FROM ServiceMail INNER JOIN " +
                "UserInfo ON ServiceMail.AuthorID = UserInfo.ID";

            connection.Open();
            SqlDataAdapter sqladd = new SqlDataAdapter(cmd);
            sqladd.Fill(dt);
            connection.Close();

            List<InnerMail> tmpList = new List<InnerMail>();


            return dt;
        }
        public DataTable getIncomingMailHead()
        {

            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT IncomingMail.ID, IncomingMail.Theme, IncomingMail.RegNumber, IncomingMail.Date, IncomingMail.Sender, " +
                "UserInfo.Surname + ' ' + LEFT(UserInfo.FirstName, 1) + '.' + LEFT(UserInfo.Patronymic, 1) as Author " +
                "FROM IncomingMail INNER JOIN " +
                "UserInfo ON IncomingMail.DocumentAuthor = UserInfo.ID ";

            connection.Open();
            SqlDataAdapter sqladd = new SqlDataAdapter(cmd);
            sqladd.Fill(dt);
            connection.Close();

            
            return dt;
        }
        public DataTable getTreatmentMailHead()
        {

            DataTable dt = new DataTable();

            


            return dt;
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
