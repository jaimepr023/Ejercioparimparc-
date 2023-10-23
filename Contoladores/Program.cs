using ejercicioparaeimpar.Servicios;

namespace ejercicioparaeimpar
{
    /// <summary>
    /// Clase de nuestro programa.
    /// <author> jpr-23-10-2023</author>
    /// </summary>
    class program
    {/// <summary>
     /// Metodo principal donde estan los demas metodos.
     /// <author> jpr-23-10-2023</author>
     /// </summary>
     /// <param name="args"></param>
        public static void Main(String[] args)
        {
            leaNumeroInterfaz nu = new numeroImplementacion();
            operacionInterfaz op = new operacionImplementacion();
            int numero = nu.numeroDado();
            op.operacionNumero(numero);
        }
        


    }
}
