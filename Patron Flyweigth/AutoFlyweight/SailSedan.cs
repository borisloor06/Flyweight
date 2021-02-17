namespace AutoFlyweight
{
    //implemento una clase para almacenar los datos intrisecos en base a un modelo especifico de auto
    internal class SailSedan : Modelo
    {
        public SailSedan()
        {
            this.color = "rojo";
            this.motor = 1.2;
            this.modelo = "Sail Sedan";
            this.precio = 120000;
        }
        public override string MostrarCaract()
        {
            return("Camioneta "+modelo+" con precio "+ precio.ToString()+" de color "+color +" y un motor de "+motor.ToString());
        }
    }
}