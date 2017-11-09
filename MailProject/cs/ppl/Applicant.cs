using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MailProject
{
    class Applicant
    {
        private string name;
        private string number;
        private string email;
        private string account;
        private string adress;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
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

        public string Account
        {
            get
            {
                return account;
            }

            set
            {
                account = value;
            }
        }

        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }

        public Applicant()
        {

        }

        public Applicant(DataRow dataRow)
        {
            this.name = (string)dataRow["ApplicantName"];
            this.number = (string)dataRow["ApplicantNumber"];
            this.email = (string)dataRow["ApplicantEmail"];
            this.account = (string)dataRow["ApplicantAccount"];
            this.adress = (string)dataRow["ApplicantAdress"];

        }

        public Applicant(string name, string number, string email, string account, string adress)
        {
            this.name = name;
            this.number = number;
            this.email = email;
            this.account = account;
            this.adress = adress;
        }
    }
}
