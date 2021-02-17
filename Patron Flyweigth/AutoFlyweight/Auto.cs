using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFlyweight
{
    class Auto
    {
        //Parte Extrinseca
        string matricula;
        string IDTitular;
        Modelo modelo;

        //Constructor del Auto
        public Auto(string mod, string matricula, string IDtitular)
        {
            this.modelo = AutoFactory.GetAuto(mod);
            this.matricula = matricula;
            this.IDTitular = IDtitular;
        }
        public string Mostrar()
        {
           return modelo.MostrarCaract();
        }
    }
}
