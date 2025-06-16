using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigation_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            SimpleAgent simpleAgent1 = new SimpleAgent();
            inveestigation inveestigation1 = new inveestigation(simpleAgent1);
            hearing_sensor hearing_Sensor1 = new hearing_sensor(inveestigation1);
            audioSensor audioSensor1 = new audioSensor(inveestigation1);

        }
    }
}
