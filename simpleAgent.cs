

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigation_game
{
    public class SimpleAgent : IAgent
    {
        public string Rank { get; set; }
        public int SensorSlots { get; set; }
        public sensor[] arreyOfSensors { get; set; }
        public sensor[] SensorHeNeed { get; set; }

        public SimpleAgent()
        {
            Random rand = new Random();
            
            Rank = "footSoldier";
            SensorSlots = 2;
            arreyOfSensors = new string[2] ;
            SensorHeNeed = new string[2] ;
        }

        public void CounterattackBehavior()
        {
            
        }
    }
}

