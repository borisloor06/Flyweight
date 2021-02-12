using System;
using System.Collections.Generic;
using System.Text;

namespace Auto
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
