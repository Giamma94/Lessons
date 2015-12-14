using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_01_12_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            Sezione Terza = new Sezione();
            Terza.Controllo = new DateTime(1999,01,01);
            Sezione Seconda = new Sezione();
            Seconda.Controllo = new DateTime(2000,01,01);
            Sezione Prima = new Sezione();
            Prima.Controllo = new DateTime(2001,01,01);
        }
    }
}
