using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigation_game
{
    public class Agent
    {
        public string Rank { get; set; }
        public int SensorSlots { get; set; }
        public sensor[] arreyOfSensors { get; set; }
        public sensor[] SensorHeNeed { get; set; }

        void CounterattackBehavior() { }
    }

}
