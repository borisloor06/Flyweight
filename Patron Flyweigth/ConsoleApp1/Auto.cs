using System;

namespace Auto
{
    class Auto
    {

        Modelo modelo;
        string matricula { get; set; }
        string IDTitular { get; set; }


        public Auto( string modelo,  string matricula, string nifTitular)
        {
            this.modelo = AutoFactory.GetAuto(modelo);
            this.matricula = matricula;
            this.IDTitular = nifTitular;
        }

        public string Mostrar()
        {
            return modelo.MostrarCaract();
        }

    }
}
