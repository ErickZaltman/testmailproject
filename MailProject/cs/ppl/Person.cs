using System.Data;

namespace MailProject
{
    public class Person
    {


        private string loginName;
        private string firstName;
        private string patronimycName;
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

        public string PatronimycName
        {
            get
            {
                return patronimycName;
            }

            set
            {
                patronimycName = value;
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
        /// <param name="patronimyc">Отчество пользователя</param>
        /// <param name="surname">Фамилия пользователя</param>
        /// <param name="mobile">Номер мобильного телефона</param>
        /// <param name="phone">Номер стационарного телефона</param>
        /// <param name="email">Электронная почта</param>
        /// <param name="id">Идентификатор пользователя в БД</param>
        /// <returns></returns>
        public Person(string login, string firstname, string patronimyc, string surname, string mobile, string phone, string email, bool sex, int deptid, int id)

        {

            loginName = login;
            firstName = firstname;
            patronimycName = patronimyc;
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
            PatronimycName = (string)dataRow["Patronymic"];
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


            return loginName + "; " + firstName + "; " + patronimycName + "; " + surname + "; " + mobileNumber + "; " +
                phoneNumber + "; " + email + "; " + id + "; " + email + "; " + sex + "; " + deptID;
        }


    }
}
