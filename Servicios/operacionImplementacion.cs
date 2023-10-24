using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioparaeimpar.Servicios
{
    internal class operacionImplementacion : operacionInterfaz
    {
        public void operacionNumero(int num1)
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine("El numero:"+num1+". "+"Es un numero par.");
            }
            else
            {
                Console.WriteLine("El numero:"+ num1+ ". "+ "Es un numero impar.");
            }
           
           
        }
    }
}
