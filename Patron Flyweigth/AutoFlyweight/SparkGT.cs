namespace AutoFlyweight
{
    internal class SparkGT : Modelo
    {
        public SparkGT()
        {
            this.color = "blanco";
            this.modelo = "Spark GT";
            this.precio = 4000.50;
            this.motor = 2.0;
        }
        public override string MostrarCaract()
        {
            return ("Camioneta " + modelo + " con precio " + precio.ToString() + " de color " + color + " y un motor de " + motor.ToString());
        }
    }
}