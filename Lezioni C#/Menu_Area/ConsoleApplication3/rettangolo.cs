using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class rettangolo
    {
        private double perimetro;
        private double area;
        private double basen;
        private int altezza;



        public double Basen
        {
            set
            {
                basen = value;
            }

            get
            {
                return basen;
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



        public double calcolo_Area()
        {
            return (basen + altezza) * 2;

        }

        public double calcolo_perimetro()
        {
            return (basen * 2) + (altezza * 2);

        }
    }


}
