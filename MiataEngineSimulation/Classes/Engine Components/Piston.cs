using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiataEngineSimulation
{

    class Piston
    {
        public int ID { get; set; }
        public Stroke CurrentStroke;

        public Piston(int ID)
        {
            this.ID = ID;
        }
    }
}
