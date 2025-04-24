using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3
{
    public sealed class Truck : Vehicle
    {

        public float BoxVolume { get; set; }
        public Truck()
        {

        }
        public static string Manufacturer { get; set; }
        public override string TellAbout()
        {
            return "truck object";
        }
        public Truck(string mdl, string clr, float len, float wdt, float hgt, float boxvol) :
            base(mdl, clr, len, wdt, hgt)
        {
            BoxVolume = boxvol;
        }
        public override string ShowSpecification()
        {
            return base.ShowSpecification() + $"\n{nameof(BoxVolume)}\t:{BoxVolume}" +
                $"\nManufacturer\t: {Manufacturer}";
        }

        public override string ShowSpecification(string type)
        {
            return base.ShowSpecification(type) + $"\nBox Volume:\t {BoxVolume}";

        }
        public override string ToString()
        {
            return $"{Model} [{Color}] ({BoxVolume})";
        }
    }
}
