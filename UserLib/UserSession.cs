using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLib
{
    public class UserSession
    {
        private static UserSession inst;

        private int _id;
        private string _noms;
        private string _sexe;
        private string _userName;
        private DateTime _dob;
        private string _phone;
        private string _email;
        private string _pass;
        private string _lieu;

        public string NomComplet
        {
            get
            {
                return _noms;
            }

            set
            {
                _noms = value;
            }
        }
        public string Sexe
        {
            get
            {
                return _sexe;
            }

            set
            {
                _sexe = value;
            }
        }
        public string UserName
        {
            get
            {
                return _userName;
            }

            set
            {
                _userName = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
        public string Lieu
        {
            get
            {
                return _lieu;
            }

            set
            {
                _lieu = value;
            }
        }
        public string Pass
        {
            get
            {
                return _pass;
            }

            set
            {
                _pass = value;
            }
        }
        public DateTime Dob
        {
            get
            {
                return _dob;
            }

            set
            {
                _dob = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }
        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }
        public static UserSession GetInstance()
        {
            if (inst == null)
            {
                inst = new UserSession();
            }

            return inst;
        }
    }
}
