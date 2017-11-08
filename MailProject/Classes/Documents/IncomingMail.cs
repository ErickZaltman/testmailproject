using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MailProject
{
    public class IncomingMail : Document
    {
        private int type;
        private int departmentID;
        private string sender;
        private int destination;
        private DateTime executionTime;
        private string etc;
        private string anwser;
        private string note;
        private string regNumber;


        public int Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
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
        public string Sender
        {
            get
            {
                return sender;
            }

            set
            {
                sender = value;
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
        public DateTime ExecutionTime
        {
            get
            {
                return executionTime;
            }

            set
            {
                executionTime = value;
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
        public string Anwser
        {
            get
            {
                return anwser;
            }

            set
            {
                anwser = value;
            }
        }
        public string Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }
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

        public IncomingMail(int ID, int AuthorID, string Theme, int Destination, int Type, int departmentID, string sender,
            DateTime ExecutionTime, string etc, string note, string anwser, string regNumber)
        {
            this.ID = ID;
            this.AuthorID = AuthorID;
            this.Theme = Theme;
            this.Destination = Destination;
            this.type = Type;
            this.departmentID = departmentID;
            this.sender = sender;
            this.executionTime = executionTime;
            this.etc = etc;
            this.note = note;
            this.anwser = anwser;
            this.regNumber = regNumber;


        }
        public IncomingMail()
        {

        }
        public IncomingMail(DataRow dataRow)
        {
            ID = (int)dataRow["ID"];
            Type = (int)dataRow["Type"];
            AuthorID = (int)dataRow["DocumentAuthor"];
            Theme = (string)dataRow["Theme"];
            Destination = (int)dataRow["Destination"];
            Date = (DateTime)dataRow["Date"];
            DepartmentID = (int)dataRow["DepartmentID"];
            Sender = (string)dataRow["Sender"];
            Note = (string)dataRow["Note"];
            Etc = (string)dataRow["Etc"];
            RegNumber = (string)dataRow["RegNumber"];
            ExecutionTime = (DateTime)dataRow["ExecutionTime"];


        }

        public IncomingMail(DataRow dataRow, bool head)
        {
            ID = (int)dataRow["ID"];
            AuthorID = (int)dataRow["DocumentAuthor"];
            Theme = (string)dataRow["Theme"];
            Date = (DateTime)dataRow["Date"];
            Sender = (string)dataRow["Sender"];


        }

        public override string ToString()
        {
            return ID + ";" + AuthorID + ";" + Theme + ";" + Date + ";" + DepartmentID;
        }
    }

}
