using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_01_12_2015
{
    class Sezione
    {
        private Studente[] Sez = new Studente[3];
        private DateTime controllo;

        public string SetStudent(Studente Stud, bool F )
        {
            if (Sez.Length == 3)
            {
                return "no";
            }
            else
            {
                if ((Stud.AnnoDiNascita.Year == controllo.Year) || (F == true))
                {

                    Sez[Sez.Length] = Stud;
                    return "ok";
                }
                else
                {
                    return "no data";
                }

            }
            
        }

        public DateTime Controllo 
        {
            set { controllo = value; }
        }
    }
}
