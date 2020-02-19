using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Constructor
{
    public class Araba
    {
        public Araba()
        {

        }
        public Araba(string marka, string model, double motorGucu)
        {
            Marka = marka;
            Model = model;
            MotorGucu = motorGucu;
        }
        public string Marka { get; set; }
        public string Model { get; set; }
        public double MotorGucu { get; set; }

       
    }
}
