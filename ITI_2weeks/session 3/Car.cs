namespace session_3
{
    public  class Car : Vehicle
    {
        public Car() { }

        public Car(string mdl, string clr, float len, float wdt, float hgt) : base(mdl, clr, len, wdt, hgt)
        {
        }
        public override string TellAbout()
        {
            return "This is a car object";
        }
    }
}
