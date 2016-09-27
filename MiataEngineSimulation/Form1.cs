using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiataEngineSimulation
{
    public partial class Form1 : Form
    {
        Button piston;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();          
        }

        public void UpdatePiston(int ID, Stroke stroke)
        {
            

            switch (ID)
            {
                case 1:
                    piston = Piston1;
                    break;
                case 2:
                    piston = Piston2;
                    break;
                case 3:
                    piston = Piston3;
                    break;
                case 4:
                    piston = Piston4;
                    break;
            }

            switch (stroke)
            {
                case Stroke.Compression:
                    piston.BackColor = Color.Green;
                    //piston.Text = "Comp";
                    break;
                case Stroke.Power:
                    piston.BackColor = Color.Red;
                    //piston.Text = "Power";
                    break;
                case Stroke.Exhuast:
                    piston.BackColor = Color.Black;
                    //piston.Text = "Exh";
                    break;
                case Stroke.Intake:
                    piston.BackColor = Color.Blue;
                    //piston.Text = "Intake";
                    break;
            }
        }
    }
}
