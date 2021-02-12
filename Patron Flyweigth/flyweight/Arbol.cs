using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class Arbol
    {
        //Datos Extrinsecos
        string tipo;
        //Datos Intrinsecos
        string raiz;
        string tronco;
        string ramas;
        string hojas;
        //Constructor del Arbol
        public Arbol(string raiz, string tipo)
        {
            this.raiz = raiz;
            this.tronco = raiz + "tronco";
            this.ramas = tronco + "ramas";
            this.hojas = tronco + ramas;
            this.tipo = tipo;
        }
        
    }
}
