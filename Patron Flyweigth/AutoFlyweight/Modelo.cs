using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFlyweight
{
    abstract class Modelo
    {
        protected string color;
        protected double motor;
        protected string modelo;
        protected double precio;
        public abstract string MostrarCaract();
    }
}
