using System;

namespace MailProject
{
    public class ServiceMail : Document
    {
        private string regNumber;
        private DateTime executionDate;
        private string resolution;
        private int state;
        private string etc;
        private int destination;
        private int departmentID;

        public string RegNumber
        {
            get
            {
                return regNumber;
            }

            set
            {
                regNumber = value;
            }
        }

        public DateTime ExecutionDate
        {
            get
            {
                return executionDate;
            }

            set
            {
                executionDate = value;
            }
        }

        public string Resolution
        {
            get
            {
                return resolution;
            }

            set
            {
                resolution = value;
            }
        }

        public int State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public string Etc
        {
            get
            {
                return etc;
            }

            set
            {
                etc = value;
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

        public int DepartmentID
        {
            get
            {
                return departmentID;
            }

            set
            {
                departmentID = value;
            }
        }

        public ServiceMail(System.Data.DataRow dataRow)
        {
            this.ID = (int)dataRow["ID"];
            this.AuthorID = (int)dataRow["AuthorID"];
            this.Date = (DateTime)dataRow["Date"];
            this.ExecutionDate = (DateTime)dataRow["ExecutionDate"];
            this.Theme = (string)dataRow["Theme"];
            this.RegNumber = (string)dataRow["RegNumber"];
            this.Destination = (int)dataRow["Destination"];
            this.Resolution = (string)dataRow["Resolution"];
            this.State = (int)dataRow["State"];
            this.DepartmentID = (int)dataRow["DepartmentID"];
        }

       
    }

}
