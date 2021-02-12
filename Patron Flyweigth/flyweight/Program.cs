using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos 3 contadores
            int pinos, caobas, limones;
            //Creamos una Lista para almacenar los arboles que generemos
            List<Arbol> bosque = new List<Arbol>();
            //Generamos arboles de tipo pino
            for (pinos = 0; pinos < 3000000; pinos++)
            {
                Arbol pino = new Arbol("Grande", "Pino");
                bosque.Add(pino);
            }
            //generamos arboles de tipo caoba
            for (caobas = 0; caobas < 7000000; caobas++)
            {
                Arbol caoba = new Arbol("Grande", "Caoba");
                bosque.Add(caoba);
            }
            //generamos arboles de tipo limon
            for (limones = 0; limones < 5000000; limones++)
            {
                Arbol limon = new Arbol("Pequeña", "Limon");
                bosque.Add(limon);
            }
            //Mostramos por pantalla informacion de lo que generamos
            Console.WriteLine("Hay {0} arboles en este bosque, de los cuales {1} son pinos, {2} son caobas y {3} son limones", bosque.Count, pinos, caobas, limones);

            
            Console.ReadLine();
        }
    }
}
