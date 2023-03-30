//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {   
            for (int i = 0; i <= 100000; i ++)
            {
                Train train = new Train($"{i}");
                Console.WriteLine(Train.Count);
            }
            //El contador se corta antes de terminar el for, esto sudcede cada vez que se crea una instancia de Train
            //esta ocupando parte de la memoria, que al ser limitada, eventualmente llega a su limite donde ya no puede
            //crear más instancias y por lo tanto se corta.
            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");
            t1 = t2;
            t2 = t3; 
            Console.WriteLine(t1.id + "\n" + t2.id + "\n" + t3.id);
            //Al hacer t1 = t2 el valor de los atributos(id) de t1 se igualan a los de t2(que al ser iguales no
            //cambia nada) mientras que al hacer t2 = t3 dado que sus atributos(id) son diferentes el id de t2
            //se iguala al de t3.
        }
    }
}