using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Dominio
{
    public class Utente
    {
        private String _email;
        private Boolean _isAdmin;

        public Utente(string _email)
        {
            this._email = _email;
            _isAdmin = false;
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

        public bool IsAdmin
        {
            get
            {
                return _isAdmin;
            }

            set
            {
                _isAdmin = value;
            }
        }
    }
}
