using System;
using System.Collections.Generic;
using System.Text;

namespace Context
{
    //Implementamos un patron Factory en conjunto con el Flyweight
    class ArbolFactory
    {
        //declaramos un diccionario
        private static Dictionary<string, Flyweight> _flyweight = new Dictionary<string, Flyweight>();
        //creamos un metodo que nos devuelve el estado intrinseco
        public static Flyweight GetFlyweight(string raiz)
        {
            //revisamos si la raiz se encuentra en el diccionario y la devolvemos
            if (_flyweight.ContainsKey(raiz)){
                return _flyweight[raiz];
            }
            //si no se encuentra en el diccionario creamos la entrada y luego devolvemos el valor
            else
            {
                _flyweight.Add(raiz, new EstadoIntrinseco(raiz));
                return _flyweight[raiz];
            }
        }

    }
}
