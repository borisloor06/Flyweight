using System;
using System.Collections.Generic;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sails, dmaxs, sparks;

            List<Auto> autos = new List<Auto>();
            for (sails = 0; sails < 1000000; sails++)
            {
                Auto sail = new Auto("Sail Sedan", "MTR1234", "123456789");
                autos.Add(sail);
            }


            for (dmaxs = 0; dmaxs < 20000000; dmaxs++)
            {
                Auto dmax = new Auto("D-Max", "MBA2134", "987654321");
                autos.Add(dmax);
            }
            for (sparks = 0; sparks < 3000000; sparks++)
            {
                Auto spark = new Auto("Spark GT", "HBO4321", "918273645");
                autos.Add(spark);
            }

            Console.WriteLine("Se vendieron {0} autos, de los cuales {1} eran " + autos[sails].Mostrar() + ", {2} eran " + autos[sparks].Mostrar() + " y {3} " + autos[dmaxs].Mostrar(), autos.Count, sails, sparks, dmaxs);
            Console.ReadLine();
        }
    }
}
