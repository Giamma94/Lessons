using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class triangolo 
    {
       private double perimetro;
       private double area;
       private double lato;
       private int altezza;



        public double Lato
        {
            set
            {
               lato = value;
            }

            get
            {
                return lato;
            }
        }



        public int Altezza
        {
            set
            {
                altezza = value;
            }

            get
            {
                return altezza;
            }
        }



        public double calcolo_Area ()
        {
            return (lato * altezza) / 2;
            
        }

        public double calcolo_perimetro()
        {
            return lato * 3;

        }
    }


}
