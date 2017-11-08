using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailProject
{
    class TreatmentMail
    {
        private int incomingMail;
        private int type;
        private Applicant applicant;
        private int deliveryType;
        private string adress;
        private string text;
        private int type2;
        private string state;
        private int answerMailID;

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

        internal Applicant Applicant
        {
            get
            {
                return applicant;
            }

            set
            {
                applicant = value;
            }
        }

        public int DeliveryType
        {
            get
            {
                return deliveryType;
            }

            set
            {
                deliveryType = value;
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

        public int Type2
        {
            get
            {
                return type2;
            }

            set
            {
                type2 = value;
            }
        }

        public string State
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

        public int AnswerMailID
        {
            get
            {
                return answerMailID;
            }

            set
            {
                answerMailID = value;
            }
        }

    }
}
