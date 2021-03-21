using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace G9E3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[15];
            int index = 0, val;
            bool error = true, indexErr = false;
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                arreglo[i] = random.Next(0, 1000);
            }
            while (error == true)
            {
                try
                {
                    Console.WriteLine("Inserte el indice (entre 1 a 15) a buscar dentro del arreglo...");
                    index = int.Parse(Console.ReadLine());
                    index--;
                    error = false;
                }
                catch (FormatException err)
                {
                    Console.WriteLine(err.Message);
                    Console.Write("Vuelvalo a intentar .");
                    for (int i = 0; i < 4; i++)
                    {
                        Thread.Sleep(1000);
                        Console.Write(".");
                    }
                    Console.Clear();
                    error = true;
                }
            }
            try
            {
                val = arreglo[index];
            }
            catch (IndexOutOfRangeException err)
            {
                Console.WriteLine(err.Message);
                indexErr = true;
            }
            finally
            {
                if (indexErr == false)
                {
                    Console.WriteLine("El valor solicitado es " + arreglo[index]);
                }
            }
            Console.ReadKey();
        }
    }
}
