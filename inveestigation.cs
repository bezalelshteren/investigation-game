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
        public Dictionary<string, int> sensorheNeed;
        public Dictionary<string, int> ListOfSensorHEhaed;
        public Dictionary<sensor, int> theSensorsHeNeed;
        public inveestigation(Agent agent1)
        {
            kindOfsensors = new List<sensor>();
            sensorheNeed = new Dictionary<string, int>();
            ListOfSensorHEhaed = new Dictionary<string, int>();
            while (kindOfsensors.Count > 0)
            {
                if (kindOfsensors.Count > 0)
                {
                    createRandom(kindOfsensors, agent1);
                }
            }
            foreach(sensor s in kindOfsensors)
            {
                Console.WriteLine(s);
            }
           
            //foreach(sensor s in ListOfSensorHEhaed)
            //{
            //    Console.WriteLine(s);
            //}
            
        }
        public  Dictionary<string,int> changfromArreyToList(sensor[] sensors)
        {
            foreach (sensor s in sensors)
            {
                if (s != null)
                {
                    if (ListOfSensorHEhaed.ContainsKey(s.type))
                    {
                        ListOfSensorHEhaed[s.type]++;
                    }
                    else { ListOfSensorHEhaed[s.type] = 1; }
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

        public bool[] startAscing(Agent agent1) 
        {
            ListOfSensorHEhaed = changfromArreyToList(agent1.arreyOfSensors);
            sensorheNeed = changfromArreyToList(agent1.SensorHeNeed);
            bool[] isCorect = new bool[ListOfSensorHEhaed.Count];
            int i = 0;
            foreach(string s in ListOfSensorHEhaed.Keys)
            {
                if (sensorheNeed.ContainsKey(s) && ListOfSensorHEhaed[s] == sensorheNeed[s])
                {
                    isCorect[i] = true;
                }
                i++;
            }
            foreach(bool r in isCorect)
            {
                Console.WriteLine(r);
            }
            return isCorect;
        } 

    }
}
