using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigation_game
{
    public class inveestigation
    {
        public List<sensor> kindOfsensors;
        public Dictionary<sensor, int> sensorheNeed;
        public Dictionary<sensor, int> ListOfSensor;
        public Dictionary<sensor, int> theSensorsHeNeed;
        public inveestigation(SimpleAgent simpleAgent)
        {
            kindOfsensors = new List<sensor>();
            sensorheNeed = new Dictionary<sensor, int>();
            ListOfSensor = new Dictionary<sensor, int>();
            createRandom(kindOfsensors, simpleAgent);
            ListOfSensor = changfromArreyToList(simpleAgent.arreyOfSensors);
            sensorheNeed = changfromArreyToList(simpleAgent.SensorHeNeed);
        }
        public  Dictionary<sensor,int> changfromArreyToList(sensor[] sensors)
        {
            foreach(sensor s in sensors)
            {
                if (ListOfSensor.ContainsKey(s))
                {
                    ListOfSensor[s] ++ ;
                }
                else { ListOfSensor[s] = 1; }
            }
            return ListOfSensor;
        }

       

        public sensor[] createRandom( List<sensor> kindOfsensors, Agent SimpleAgent)
        {
            Random random = new Random();

            for(int i = 0;i < SimpleAgent.SensorSlots; i++)
            {
                int num = random.Next(kindOfsensors.Count);
                SimpleAgent.arreyOfSensors.Append(kindOfsensors[num]);
            }
            return SimpleAgent.arreyOfSensors;
        }

        public Dictionary<sensor,bool> startAscing() 
        {
            Dictionary<sensor, bool> isCorect = new Dictionary<sensor, bool> ();
            foreach(sensor s in sensorheNeed.Keys)
            {
                if (ListOfSensor.ContainsKey(s) && sensorheNeed[s] == ListOfSensor[s])
                {
                    isCorect[s] = true;
                }
            }
            return isCorect;
        } 
    }
}
