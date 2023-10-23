using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioparaeimpar.Servicios
{
    /// <summary>
    /// Interfaz de la operaciones para diferenciar entre impar o par.
    /// <author> jpr-23-10-2023</author>
    /// </summary>
    internal interface operacionInterfaz
    {
        /// <summary>
        /// Metodo que escribe por pantalla si el numero recibido por el cliente es par o impar.
        /// <author> jpr-23-10-2023</author>
        /// </summary>
        /// <param name="num1"></param>
        public void operacionNumero(int num1);
    }
}
