using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioparaeimpar.Servicios
{
    internal class numeroImplementacion : leaNumeroInterfaz
    {
        public int numeroDado()
        {
            int numero1;
            Console.WriteLine("Dame el numero para identificar:");
            numero1 = Int32.Parse(Console.ReadLine());
            return numero1;
        }
    }
}
