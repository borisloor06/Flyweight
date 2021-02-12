using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFlyweight
{
    class Auto
    {
        string matricula;
        string IDTitular;
        Modelo modelo;

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
