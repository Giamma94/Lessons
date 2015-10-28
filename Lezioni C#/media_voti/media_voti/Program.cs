using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_voti
{
    class Program
    {
        static void Main(string[] args)
        {
            studenti Studente = new studenti();

            
            Studente.setmat(Convert.ToInt32(Console.ReadLine()));
            
            Studente.setinf(Convert.ToInt32(Console.ReadLine()));
            
            Studente.setita(Convert.ToInt32(Console.ReadLine()));

            Studente.PromossoBocciato();
        }
    }

    public class studenti
    {

      private string nome = "pippo";
      private string cognome = "rino";
      private int mat,ita,inf;


        public void setmat(int voto)
        {
            if (voto < 1 || voto > 10)
            {
                Console.WriteLine("Il voto " + voto + " è Errato");
            }
            else
            {
                mat = voto;
            }
        }


        public void setita(int voto)
        {
            if (voto < 1 || voto > 10)
            {
                Console.WriteLine("Il voto " + voto + " è Errato");
            }
            else
            {
                ita = voto;
            }
        }

        public void setinf(int voto)
        {
            if (voto < 1 || voto > 10)
            {
                Console.WriteLine("Il voto " + voto + " è Errato");
            }
            else
            {
                inf = voto;
            }
        }

        private int media ()
        {
            int media1;
            return media1 = (mat + ita + inf) / 3;
        }

        public void PromossoBocciato ()
        {
            int med = media();

            if (med < 6)
            {
                Console.WriteLine("Bocciato!");
            }
            else
            {
                Console.WriteLine("Promosso!");
            }

            Console.ReadLine();
        }
    }
}
