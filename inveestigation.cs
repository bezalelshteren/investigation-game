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
        public Dictionary<sensor, int> ListOfSensorHEhaed;
        public Dictionary<sensor, int> theSensorsHeNeed;
        public inveestigation(Agent agent1)
        {
            kindOfsensors = new List<sensor>();
            sensorheNeed = new Dictionary<sensor, int>();
            ListOfSensorHEhaed = new Dictionary<sensor, int>();
            if (kindOfsensors.Count > 0)
            {
                createRandom(kindOfsensors, agent1);
            }
           
            //foreach(sensor s in ListOfSensorHEhaed)
            //{
            //    Console.WriteLine(s);
            //}
            
        }
        public  Dictionary<sensor,int> changfromArreyToList(sensor[] sensors)
        {
            foreach (sensor s in sensors)
            {
                if (s != null)
                {
                    if (ListOfSensorHEhaed.ContainsKey(s))
                    {
                        ListOfSensorHEhaed[s]++;
                    }
                    else { ListOfSensorHEhaed[s] = 1; }
                }
            }
            return ListOfSensorHEhaed;
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

        public Dictionary<sensor,bool> startAscing(Agent agent1) 
        {
            ListOfSensorHEhaed = changfromArreyToList(agent1.arreyOfSensors);
            sensorheNeed = changfromArreyToList(agent1.SensorHeNeed);
            Dictionary<sensor, bool> isCorect = new Dictionary<sensor, bool> ();
            foreach(sensor s in ListOfSensorHEhaed.Keys)
            {
                if (sensorheNeed.ContainsKey(s) && ListOfSensorHEhaed[s] == sensorheNeed[s])
                {
                    isCorect[s] = true;
                }
            }
            foreach(bool r in isCorect.Values)
            {
                Console.WriteLine(r);
            }
            return isCorect;
        } 

    }
}
