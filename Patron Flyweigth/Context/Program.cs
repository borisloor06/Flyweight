using System;
using System.Collections.Generic;

namespace Context
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos unos contadores
            int pinos, caobas, limones;
            //creamos una Lista
            List<Arbol> bosque = new List<Arbol>();
            //Generamos arboles de tipo pino
            for (pinos = 0; pinos < 3000000; pinos++)
            {
                Arbol pino = new Arbol("Grande","Pino");
                bosque.Add(pino);
            }
            //Generamos arboles de tipo caoba
            for (caobas = 0; caobas < 7000000; caobas++)
            {
                Arbol caoba = new Arbol("Grande", "Caoba");
                bosque.Add(caoba);
            }
            //Generamos arboles de tipo limones
            for (limones = 0; limones < 5000000; limones++)
            {
                Arbol limon = new Arbol("Pequeña", "Limon");
                bosque.Add(limon);
            }

            //Mostramos por pantalla cuantos arboles se generaron
            Console.WriteLine("Hay {0} arboles en este bosque, de los cuales {1} son pinos, {2} son caobas y {3} son limones",bosque.Count, pinos, caobas, limones);
            
            Console.ReadLine();
        }
    }
}
