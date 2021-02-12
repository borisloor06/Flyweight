namespace AutoFlyweight
{
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