using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigation_game
{
    public interface IAgent
    {
        string Rank { get; set; }
        int SensorSlots { get; set; }
        sensor[] arreyOfSensors { get; set; }
        sensor[] SensorHeNeed { get; set; }

        void CounterattackBehavior();
    }

}
