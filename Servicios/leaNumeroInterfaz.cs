using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioparaeimpar.Servicios
{
    /// <summary>
    /// Interfaz que pide el numero que el cliente escriba por consola.
    /// <author> jpr-23-10-2023</author>
    /// </summary>
    internal interface leaNumeroInterfaz
    {
        /// <summary>
        /// Metodo que realiza la operacion de pedir el numero lo guarda.
        /// </summary>
        /// <returns></returns>
        public int numeroDado();
    }
}
