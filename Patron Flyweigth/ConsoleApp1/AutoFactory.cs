namespace Auto
{
    class AutoFactory
    {


        public static Modelo GetAuto(string modelo)
        {

            Modelo auto = null;
            if (modelo.Equals("Spark GT"))
            {
                auto = new SparkGT();
            }
            else if (modelo.Equals("Sail Sedan"))
            {
                auto = new SailSedan();
            }
            else if (modelo.Equals("D-Max"))
            {
                auto = new DMax();
            }

            return auto;
        }

    }
}
