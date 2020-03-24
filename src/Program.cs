using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OrdenamientoBurbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = CrearVector();

            array = LlenarVector(array);

            Console.WriteLine("Cargando...");

            Thread.Sleep(2000);
            
            MetodoBurbuja(array);

            Console.ReadKey();
        }

        #region Creamos el vector con el tamaño que se nos indica por consola
        public static int[] CrearVector()
        {
            Console.WriteLine("Ingrese el digito del tamaño del array");
            var valueSize = Console.ReadLine();
            int sizeArray = 0;
            bool result;
            result = int.TryParse(valueSize, out sizeArray);
            while (result == false)
            {
                Console.WriteLine("Vuelva a ingresar un numero valido para el tamaño del array por favor");
                var val = Console.ReadLine();
                result = int.TryParse(val, out sizeArray);
            }
            int[] array = new int[sizeArray];

            return array;
        }
        #endregion

        #region Llenamos el vector con los valores que se ingresan por consola
        public static int[] LlenarVector(int[] array)
        {
            Console.WriteLine("Ingrese los numeros que estaran dentro del array");
            int number = 0;
            bool resultFor;
            for (int i = 0; i < array.Length; i++)
            {
                var value = Console.ReadLine();
                resultFor = int.TryParse(value, out number);
                while (resultFor == false)
                {
                    Console.WriteLine("Vuelva a ingresar un numero valido para ingresar en el array por favor");
                    var newValue = Console.ReadLine();
                    resultFor = int.TryParse(newValue, out number);
                }
                array[i] = number;
            }
            return array;
        }
        #endregion

        #region Metodo Burbuja
        public static void MetodoBurbuja(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < (array.Length - i - 1); j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int aux = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = aux;
                    }
                }
            }
            array.ToList().ForEach(i => Console.WriteLine("{0}\t", i));
        }
        #endregion
    }
}
