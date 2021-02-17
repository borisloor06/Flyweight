using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFlyweight
{
    //clase abstracta para implementar la parte intrinseca
    abstract class Modelo
    {
        protected string color;
        protected double motor;
        protected string modelo;
        protected double precio;
        public abstract string MostrarCaract();
    }
}
