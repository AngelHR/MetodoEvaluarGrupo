using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {


            int alumnos,p, res = 0;

            string grupo;
            Console.WriteLine("Inserte el numero de alumnos: ");
            alumnos = int.Parse(Console.ReadLine());          
            int[] calificaciones = RegistrarCalificaciones(alumnos);
            Console.WriteLine("---------------------------------------------------------------------\n");

            for (int i=0;i<calificaciones.Length;i++)
            {
                Console.Write("El Alumno {0} tiene una califiacion de {0} por lo tanto ",i+1, calificaciones[i]);
                Evaluar(calificaciones[i]);
                res += calificaciones[i];
            }
            Console.WriteLine("---------------------------------------------------------------------\n");
            Console.Write("El Grupo cuenta con un promedio total de: {0} por lo que", (float)res/calificaciones.Length);
            Evaluar(res / calificaciones.Length);
            Console.ReadKey();
        } 
         static int[] RegistrarCalificaciones(int numeroCalificaciones)
        { 
             int[] cAlum = new int[numeroCalificaciones]; 
             int nCal = 0; 
              do 
              { 
                 Console.WriteLine("Inserte Calificaion del Alumno {0}", (nCal + 1)); 
                 cAlum[nCal] = int.Parse(Console.ReadLine()); 
                    nCal++; 
               } while (nCal<numeroCalificaciones); 
             return cAlum; 
        }
        static void Evaluar(int p)
        {

            if (p >= 9) 
                    Console.Write($"se considera excelente\n"); 
                else if (p >= 7) 
                    Console.Write($"se considera bueno\n"); 
                else 
                    Console.Write($"se considera malo\n"); 
            
        } 
    }
}
