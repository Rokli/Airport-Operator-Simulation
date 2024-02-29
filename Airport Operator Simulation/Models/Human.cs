using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Operator_Simulation.Models
{
    public class Human
    {
        public int _id {  get; set; }
        public double _weigth {  get; set; }

        public Human(int id, double weigth)
        {
            _id = id;
            _weigth = weigth;
        }
    }
}
