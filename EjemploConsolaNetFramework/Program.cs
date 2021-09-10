using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConsolaNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Datos Entrada
            //Datos Nombre
            Console.WriteLine("Introduce tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola, " + nombre);
            Console.ReadKey();

            //Datos Nombre Ciudad
            Console.WriteLine("Introduce tu nombre:");
            string nombre2 = Console.ReadLine();
            Console.WriteLine("Introduce tu ciudad:");
            string nombreCiudad = Console.ReadLine();
            Console.WriteLine("Hola, " + nombre2 + " Bienvenido a " + nombreCiudad);
            Console.ReadKey();
            #endregion

            #region Tipos Valores
            // 0 a 255
            byte v1 = 200;
            Console.WriteLine("Valor almacenado en la variable de tipo byte: " + v1);

            //-128 a 127
            sbyte v2 = 100;
            Console.WriteLine("Valor almacenado en la variable de typo sbyte: " + v2);

            //-32768 a 32767
            short v3 = 30000;
            Console.WriteLine("Valor almacenado en la variable de tipo short: " + v3);

            //0 a 65535
            ushort v4 = 60000;
            Console.WriteLine("Valor almacenado en la varianle de tipo ushort: " + v4);

            //-2147483648 a 214759647
            int v5 = -2000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo int: " + v5);

            //0 a 4294967295
            uint v6 = 200000000;
            Console.WriteLine("Valor almacenado en la variable de tipo unit: " + v6);

            //-9223372036854775808 a 9223372036854775807
            long v7 = -10000000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo long: " + v7);

            //0 a 18446744073709551615
            ulong v8 = 100000000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo ulong: " + v8);
            Console.ReadKey();

            #endregion

            #region Variables

            #endregion
        }
    }
}
