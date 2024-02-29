using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Operator_Simulation.Models
{
    public class Distibutor
    {
        public Queue<Human> queue { get; set; }
        public void InputQueue(Human human) => queue.Enqueue(human);
        
        public Human OutputQueue(Human human)
        {
            return queue.Dequeue();
        }

    }
}
