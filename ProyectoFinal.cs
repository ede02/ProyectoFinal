using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Proyecto
    {
        private string[] empleados;
        private int[,] sueldos;
        private int[] totalsueldo;

        public void Cargar()
        {
            empleados = new String[5];
            sueldos = new int[5, 3];
            for (int f = 0; f < empleados.Length; f++)
            {
                Console.Write("Ingrese el nombre del empleado:");
                empleados[f] = Console.ReadLine();
                for (int c = 0; c < sueldos.GetLength(1); c++)
                {
                    Console.Write("Ingrese sueldo del mes:");
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[f, c] = int.Parse(linea);
                }
            }
        }

        public void SueldoSum()
        {
            totalsueldo = new int[5];
            for (int f = 0; f < sueldos.GetLength(0); f++)
            {
                int suma = 0;
                for (int c = 0; c < sueldos.GetLength(1); c++)
                {
                    suma = suma + sueldos[f, c];
                }
                totalsueldo[f] = suma;
            }
        }

        public void TotSueldos()
        {
            Console.WriteLine("Total de sueldos pagados por empleado.");
            for (int f = 0; f < totalsueldo.Length; f++)
            {
                Console.WriteLine(empleados[f] + " - " + totalsueldo[f]);
            }
        }

        public void SueldoMayor()
        {
            int total = totalsueldo[0];
            string empl = empleados[0];
            for (int f = 0; f < totalsueldo.Length; f++)
            {
                if (totalsueldo[f] > total)
                {
                    total = totalsueldo[f];
                    empl = empleados[f];
                }
            }
            Console.WriteLine("El empleado con mayor sueldo es: " + empl + " y tiene un sueldo de: " + total);
        }

        static void Main(string[] args)
        {
            Proyecto x = new Proyecto();
            x.Cargar();
            x.SueldoSum();
            x.TotSueldos();
            x.SueldoMayor();
            Console.ReadKey();
        }
    }
}
