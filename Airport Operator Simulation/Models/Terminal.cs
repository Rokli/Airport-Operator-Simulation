using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Airport_Operator_Simulation.Models
{
    public class Terminal
    {
        public double time { get; set; } = 0;
        public Randoms rand {  get; set; }
        public int _stopweigth { get; set; }
        public int number { get; set; } = 0;
        public Terminal(int number, int stopweigth) 
        {
            _stopweigth = stopweigth;
            rand = new Randoms(number);
        }

        public void Handler(Human human)
        {
            if(human._weigth > _stopweigth)
                number++;
            else
            {
                time += human._weigth * 0.1f;
                time += rand.Random(1, 6);
            }
        }
    }
}
