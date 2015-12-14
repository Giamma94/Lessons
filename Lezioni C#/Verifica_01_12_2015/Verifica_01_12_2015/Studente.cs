using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_01_12_2015
{
    class Studente
    {
        private string nome;
        private string cognome;
        private DateTime annoDiNascita;

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public string Cognome
        {
            set { cognome = value; }
            get { return cognome; }
        }

        public DateTime AnnoDiNascita
        {
            set { annoDiNascita = value; }
            get { return annoDiNascita; }
        }
    }
}
