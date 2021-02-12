namespace AutoFlyweight
{
    internal class DMax : Modelo
    {
        public DMax()
        {
            this.color = "negro";
            this.modelo = "D-Max";
            this.motor = 3.2;
            this.precio = 30000.7;
        }
        public override string MostrarCaract()
        {
            return ("Camioneta " + modelo + " con precio " + precio.ToString() + " de color " + color + " y un motor de " + motor.ToString());
        }

    }
}