using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigation_game
{
    public abstract class Agent
    {
        public int id { get; set; }
        public string Rank { get; set; }
        public int SensorSlots { get; set; }
        public sensor[] arreyOfSensors { get; set; }
        public sensor[] SensorHeNeed { get; set; }

        public void insertASensor(sensor samSensor, int location)
        {
            arreyOfSensors[location] = samSensor;
        }
        public void CounterattackBehavior() { }
    }

}
