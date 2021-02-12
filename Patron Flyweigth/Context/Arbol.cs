using System;
using System.Collections.Generic;
using System.Text;

namespace Context
{
    class Arbol
    {
        //dato extrinseco
        string tipo;
        //datos intrinsecos
        Flyweight flyweight;
        //constructor del Arbol
        public Arbol(string raiz, string tipo)
        {
            this.flyweight = ArbolFactory.GetFlyweight(raiz);
            this.tipo = tipo;
        }
    }
}
