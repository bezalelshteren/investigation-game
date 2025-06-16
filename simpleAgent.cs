

using investigation_game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigation_game
{
    public class SimpleAgent : Agent
    {
    
        public SimpleAgent()
        {
           
            Rank = "footSoldier";
            SensorSlots = 2;
            arreyOfSensors = new sensor[SensorSlots] ;
            SensorHeNeed = new sensor[SensorSlots] ;
        }
    }
}

//public class SimpleAgent : Agent
//{
//    public string Rank { get; set; }
//    public int SensorSlots { get; set; }
//    public sensor[] arreyOfSensors { get; set; }
//    public sensor[] SensorHeNeed { get; set; }

//    public SimpleAgent()
//    {
//        Random rand = new Random();

//        Rank = "footSoldier";
//        SensorSlots = 2;
//        arreyOfSensors = new sensor[SensorSlots];
//        SensorHeNeed = new sensor[SensorSlots];
//    }

//    public void CounterattackBehavior()
//    {

//    }
//}

