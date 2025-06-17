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
        public inveestigation(Agent agent1)
        {
            kindOfsensors = new List<sensor>();
            sensorheNeed = new Dictionary<sensor, int>();
            ListOfSensor = new Dictionary<sensor, int>();
            if (kindOfsensors.Count > 0)
            {
                createRandom(kindOfsensors, agent1);
            }
            ListOfSensor = changfromArreyToList(agent1.arreyOfSensors);
            sensorheNeed = changfromArreyToList(agent1.SensorHeNeed);
        }
        public  Dictionary<sensor,int> changfromArreyToList(sensor[] sensors)
        {
            foreach (sensor s in sensors)
            {
                if (s != null)
                {
                    if (ListOfSensor.ContainsKey(s))
                    {
                        ListOfSensor[s]++;
                    }
                    else { ListOfSensor[s] = 1; }
                }
            }
            return ListOfSensor;
        }

       

        public sensor[] createRandom( List<sensor> kindOfsensors, Agent SimpleAgent)
        {
            Random random = new Random();

            for(int i = 0;i < SimpleAgent.SensorSlots; i++)
            {
                int num = random.Next(0,kindOfsensors.Count);
                SimpleAgent.arreyOfSensors[i] = kindOfsensors[num];
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
