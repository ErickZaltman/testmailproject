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
    public class Person
    {

        
        private string loginName;
        private string firstName;
        private string patronycName;
        private string surname;
        private string mobileNumber;
        private string phoneNumber;
        private string email;
        private int deptID;
        private bool sex;
        private int id;

        public string LoginName
        {
            get
            {
                return loginName;
            }

            set
            {
                loginName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string PatronycName
        {
            get
            {
                return patronycName;
            }

            set
            {
                patronycName = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string MobileNumber
        {
            get
            {
                return mobileNumber;
            }

            set
            {
                mobileNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

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

        public bool Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        public int DeptID
        {
            get
            {
                return deptID;
            }

            set
            {
                deptID = value;
            }
        }


        /// <summary>
        /// Инициализация нового экземпляра класса
        /// </summary>
        /// <param name="login">Имя входа пользователя</param>
        /// <param name="firstname">Имя пользователя</param>
        /// <param name="patronyc">Отчество пользователя</param>
        /// <param name="surname">Фамилия пользователя</param>
        /// <param name="mobile">Номер мобильного телефона</param>
        /// <param name="phone">Номер стационарного телефона</param>
        /// <param name="email">Электронная почта</param>
        /// <param name="id">Идентификатор пользователя в БД</param>
        /// <returns></returns>
        public Person(string login, string firstname, string patronyc, string surname, string mobile, string phone, string email, bool sex, int deptid, int id)

        {

            loginName = login;
            firstName = firstname;
            patronycName = patronyc;
            this.surname = surname;
            mobileNumber = mobile;
            phoneNumber = phone;
            this.email = email;
            this.id = id;
            this.sex = sex;
            deptID = deptid;
        }

        public Person(DataRow dataRow)
        {

            Id = (int)dataRow["ID"];
            LoginName = (string)dataRow["Login"];
            FirstName = (string)dataRow["FirstName"];
            PatronycName = (string)dataRow["Patronymic"];
            Surname = (string)dataRow["Surname"];
            Sex = (bool)dataRow["Sex"];
            DeptID = (int)dataRow["DepartmentID"]; ;
            Email = (string)dataRow["Email"];
            MobileNumber = (string)dataRow["MobileNumber"];
            PhoneNumber = (string)dataRow["PhoneNumber"];

        }

        /// <summary>
        /// Инициализация пустого экземпляра клаcса 
        /// </summary>
        /// <returns></returns>
        public Person()
        {

        }

        public override string ToString()
        {

            
            return loginName + "; " + firstName + "; " + patronycName + "; " + surname + "; " + mobileNumber + "; " +
                phoneNumber + "; " + email + "; " + id + "; " + email + "; " + sex + "; " + deptID;
        }


    }


    public class Document
    {
        private int id;
        private int authorID;
        private DateTime date;

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
    }

    public class InnerMail : Document
    {
        private string theme;
        private int destination;
        private string files;
        private string text;
        private bool isRead;

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
            this.Theme = theme;
            this.Destination = Destination;
            this.Files = Files;
            this.IsRead = IsRead;
        }
        public InnerMail()
        {

        }
        public InnerMail(DataRow dataRow)
        {
            ID = (int)dataRow["ID"];
            AuthorID= (int)dataRow["Author"];
            Text = (string)dataRow["Text"];
            Theme = (string)dataRow["Theme"];
            Destination = (int)dataRow["Destination"];
            Files = (string)dataRow["Files"];
            IsRead = (bool)dataRow["IsRead"];

        }

        public override string ToString()
        {
            return ID + ";" + AuthorID + ";" + Text + ";" + Theme + ";" + Destination + ";" + IsRead;
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

        //private Person getPersonInfo(DataRow row)
        //{
        //    Person tmpPerson = new Person();
        //    int tmpInt = 0;
        //    bool tmpBool = false;

        //    int.TryParse(row["ID"].ToString(), out tmpInt);
        //    tmpPerson.Id = tmpInt;
        //    tmpPerson.LoginName = row["Login"] as string;
        //    tmpPerson.FirstName = row["FirstName"] as string;
        //    tmpPerson.PatronycName = row["Patronymic"] as string;
        //    tmpPerson.Surname = row["Surname"] as string;
        //    bool.TryParse(row["Sex"].ToString(), out tmpBool);
        //    tmpPerson.Sex = tmpBool;
        //    int.TryParse(row["DepartmentID"] as string, out tmpInt);
        //    tmpPerson.DeptID = tmpInt;
        //    tmpPerson.Email = row["Email"] as string;
        //    tmpPerson.MobileNumber = row["MobileNumber"] as string;
        //    tmpPerson.PhoneNumber = row["PhoneNumber"] as string;

        //    return tmpPerson;
        //}


        public DataTable getInnerIncomingMailHead(Person user)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT dbo.InnerMail.Author, dbo.InnerMail.Theme, dbo.InnerMail.Date, dbo.InnerMail.IsRead FROM dbo.InnerMail INNER JOIN dbo.Users ON dbo.InnerMail.ID = dbo.Users.ID WHERE(dbo.InnerMail.Destination = " + user.Id + ")";

            connection.Open();
            SqlDataAdapter sqladd = new SqlDataAdapter(cmd);
            sqladd.Fill(dt);
            connection.Close();

            return dt;
        }
        public DataTable getInnerOutgoingMailHead(Person user)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT dbo.InnerMail.Destination, dbo.InnerMail.Theme, dbo.InnerMail. FROM dbo.InnerMail INNER JOIN dbo.Users ON dbo.InnerMail.ID = dbo.Users.ID WHERE(dbo.InnerMail.Author = " + user.Id + ")";

            connection.Open();
            SqlDataAdapter sqladd = new SqlDataAdapter(cmd);
            sqladd.Fill(dt);
            connection.Close();

            return dt;
        }

        public DataRow getDocumentInfo(int mailID, string tableName)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT dbo."+tableName+".* FROM dbo." + tableName+" INNER JOIN dbo.Users ON dbo."+ tableName + ".ID = dbo.Users.ID WHERE(dbo.InnerMail.ID = " + mailID + ")";

            connection.Open();
            SqlDataAdapter sqladd = new SqlDataAdapter(cmd);
            sqladd.Fill(dt);
            connection.Close();

            return dt.Rows[0];
        }







    }

}
