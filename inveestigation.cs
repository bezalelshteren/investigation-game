using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigation_game
{
    internal class inveestigation
    {
        public inveestigation()
        {
            List<sensor> kindOfsensors = new List<sensor>();
            Dictionary<sensor, int> sensorheNeed = new Dictionary<sensor, int>();
            Dictionary<sensor, int> ListOfSensors = new Dictionary<sensor, int>();
        }
        public  Dictionary<sensor,int> changfromArreyToList(sensor[] sensors,Dictionary<sensor,int> sensorheNeed)
        {
            foreach(sensor s in sensors)
            {
                if (sensorheNeed.ContainsKey(s))
                {
                    sensorheNeed[s] ++ ;
                }
                else { sensorheNeed[s] = 1; }
            }
            return sensorheNeed;
        }

        public Dictionary<sensor, int> theSensorsHeNeed = changfromArreyToList(SimpleAgent.arreyOfSensors, this.ListOfSensors);

        public s[] createRandom(string rank, sensor[] ListOfSensor, List<sensor> kindOfsensors)
        {
            
            
            Random random = new Random();

            for(int i = 0;i < 2; i++)
            {
                int num = random.Next(kindOfsensors.Count);
                ListOfSensor.Append(kindOfsensors[num]);
            }
            return ListOfSensor;
        }
    }
}
