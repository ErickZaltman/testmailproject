using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MailProject
{
    public class OutgoingMail : Document
    {
        private int type;
        private string regNumber;
        private int destination;
        private int subscriber;
        private int incomingMail;
        private DateTime executionTime;
        private int state;
        private int performer;
        private string etc;

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
        public int Subscriber
        {
            get
            {
                return subscriber;
            }

            set
            {
                subscriber = value;
            }
        }
        public int IncomingMail
        {
            get
            {
                return incomingMail;
            }

            set
            {
                incomingMail = value;
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
        public int Performer
        {
            get
            {
                return performer;
            }

            set
            {
                performer = value;
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

        public OutgoingMail()
        {

        }
        public OutgoingMail(int id, int author,DateTime date, string theme, int type, string regNumber, int destination, int subscriber, 
            int incomingMail, DateTime executionTime, int state, int performer, string etc)
        {
            this.ID = id;
            this.AuthorID = author;
            this.Date = date;
            this.Theme = theme;
            this.type = type;
            this.regNumber = regNumber;
            this.destination = destination;
            this.subscriber = subscriber;
            this.incomingMail = incomingMail;
            this.executionTime = executionTime;
            this.state = state;
            this.performer = performer;
            this.etc = etc;

        }
        public OutgoingMail(DataRow dataRow)
        {
            this.ID = (int)dataRow["ID"];
            this.AuthorID = (int)dataRow["AuthorID"];
            this.Date = (DateTime)dataRow["Date"];
            this.Theme = (string)dataRow["Theme"];
            this.type = (int)dataRow["ID"];
            this.regNumber = (string)dataRow["|RegNumber"];
            this.destination = (int)dataRow["Destination"];
            this.subscriber = (int)dataRow["Subscriber"];
            this.incomingMail = (int)dataRow["IncomingMailID"];
            this.executionTime = (DateTime)dataRow["ExecutionTime"];
            this.state = (int)dataRow["State"];
            this.performer = (int)dataRow["Perfomer"];
            this.etc = (string)dataRow["etc"];
        }


    }

}
