using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            triangolo triangoloequilatero = new triangolo();
            rettangolo Rettangolo = new rettangolo();
            
            int scelta;
            Console.WriteLine("Scegli un opzione");
            Console.Clear();
            scelta = Convert.ToInt32(Console.ReadLine());
            

            switch(scelta)
            {
                case 0: 
                        Console.WriteLine("Iserisci l'altezza del triangolo :" );
                        triangoloequilatero.Altezza = Convert.ToInt32(Console.ReadLine ());
                        Console.WriteLine("Iserisci il lato del triangolo :");
                        triangoloequilatero.Lato = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("L'area del triangolo è: " + triangoloequilatero.calcolo_Area() + " mentre il perimetro è: " + triangoloequilatero.calcolo_perimetro());
                        Console.ReadLine();
                    break;

                case 1:
                    Console.WriteLine("Iserisci l'altezza del triangolo :");
                    Rettangolo.Altezza = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Iserisci il lato del triangolo :");
                    Rettangolo.Basen = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("L'area del triangolo è: " + Rettangolo.calcolo_Area() + " mentre il perimetro è: " + Rettangolo.calcolo_perimetro());
                    Console.ReadLine();
                    break;

                case 2:
                        Console.WriteLine( "Arrivederci!!");
                    Thread.Sleep(3000);
                    break;

            }


        }
    }
}
