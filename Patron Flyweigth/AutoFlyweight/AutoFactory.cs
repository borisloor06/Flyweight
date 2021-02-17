using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFlyweight
{
    class AutoFactory
    {
        //declaro un diccionario
        private static Dictionary<string, Modelo> _autos = new Dictionary<string, Modelo>();
        
        public static Modelo GetAuto(string modelo)
        {
                       
            Modelo auto = null;
            //compruebo que exista el modelo buscado    
            if (_autos.ContainsKey(modelo))
            {
                auto = _autos[modelo];
            }
            // si no existe la agrego al diccionario
            else
            {
                if(modelo.Equals("Spark GT"))
                {
                    auto = new SparkGT();
                }else if (modelo.Equals("Sail Sedan"))
                {
                    auto = new SailSedan();
                }else if (modelo.Equals("D-Max"))
                {
                    auto = new DMax();
                }
                _autos.Add(modelo, auto);
            }
            
            //finalmente la retorno
            return auto;
        }
        
    }
}
