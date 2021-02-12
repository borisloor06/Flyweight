using System;
using System.Collections.Generic;
using System.Text;

namespace Context
{
    //Separamos el estado intrinseco en una clase hija de la interfaz 
    class EstadoIntrinseco : Flyweight
    {
        string raiz;
        string tronco;
        string ramas;
        string hojas;
        //Creamos el constructor de esta clase
        public EstadoIntrinseco(string raiz)
        {
            this.raiz = raiz;
            this.tronco = raiz + "tronco";
            this.ramas = tronco  + "ramas";
            this.hojas = tronco + ramas;
        }
    }
}
