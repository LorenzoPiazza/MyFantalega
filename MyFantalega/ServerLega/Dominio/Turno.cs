using System;
using System.Text;
using ServerLega.Dominio;

namespace ServerLega.Dominio
{
    public class Turno
    {
        //true uguale a chiamata
        private Boolean _tipo;
        //nel ruolo ci sara finito se il mercato risulta concluso
        String _ruolo;
        public Turno (Boolean tipo,String ruolo)
        {
            this._tipo = tipo;
            this.Ruolo = ruolo;
        }

        public Turno()
        {

        }

        public bool Tipo { get => _tipo; set => _tipo = value; }
        public string Ruolo { get => _ruolo; set => _ruolo = value; }
    }
}