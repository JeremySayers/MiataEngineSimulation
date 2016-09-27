using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MiataEngineSimulation
{
    class Controller
    {
        public CrankShaft crankShaft = new CrankShaft();
        public List<Cylinder> cylinders = new List<Cylinder>();
        public List<Piston> pistons = new List<Piston>();
        public int RPM;
        public float RPS;
        public int UpdateMS;

        Form1 form5;

        public Controller()
        {
            RPM = 900;
            RPS = (float)RPM / 60;
            UpdateMS = (int)(1000 / (RPS * 2));


            //Create the cylinders and setup their initial stroke
            cylinders.Add(new Cylinder(1));
            cylinders.Add(new Cylinder(2));
            cylinders.Add(new Cylinder(3));
            cylinders.Add(new Cylinder(4));

            cylinders[0].CurrentStroke = Stroke.Compression;

            cylinders[0].CurrentStroke = Stroke.Compression;
            cylinders[1].CurrentStroke = Stroke.Power;
            cylinders[2].CurrentStroke = Stroke.Intake;
            cylinders[3].CurrentStroke = Stroke.Exhuast;

            //Create the Pistons and what stroke they are in
            pistons.Add(new Piston(1));
            pistons.Add(new Piston(2));
            pistons.Add(new Piston(3));
            pistons.Add(new Piston(4));

            pistons[0].CurrentStroke = Stroke.Compression;
            pistons[1].CurrentStroke = Stroke.Power;
            pistons[2].CurrentStroke = Stroke.Intake;
            pistons[3].CurrentStroke = Stroke.Exhuast;

            form5 = new Form1();
            form5.Show();

            EngineLoop();
        }

        public void EngineLoop()
        {
            Timer timer;
            timer = new Timer(UpdateMS);
            timer.Elapsed += new ElapsedEventHandler(Timer_Elapsed);
            timer.Enabled = true;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            foreach (Cylinder c in cylinders)
            {
                if (c.CurrentStroke != Stroke.Intake) c.CurrentStroke += 1;
                else c.CurrentStroke = Stroke.Compression;
            }

            foreach (Piston p in pistons)
            {
                if (p.CurrentStroke != Stroke.Intake) p.CurrentStroke += 1;
                else p.CurrentStroke = Stroke.Compression;

                form5.UpdatePiston(p.ID, p.CurrentStroke);
                //Console.WriteLine("Piston " + p.ID + ": " + p.CurrentStroke);
            }
        }
    }
}
