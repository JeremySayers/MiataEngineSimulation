using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiataEngineSimulation
{
    /*
    *   The Cylinder objects are going to store information realtime pertaining
    *   to the amount of fuel and air inside of it before detonation occurs.
    *   Fake temperature from lean fuel conditions?
    */
    public class Cylinder
    {
        public int ID { get; set; }
        public float Fuel { get; set; }
        public float Air { get; set; }
        public float AirFuelRatio { get; set; }
        public Stroke CurrentStroke { get; set; }

        public Cylinder(int ID)
        {
            CurrentStroke = Stroke.Compression;
        }

    }
}
