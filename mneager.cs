using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigation_game
{
    public class mneager
    {
        public  mneager()
        {
          
        }
        public sensor[] yourChoice(inveestigation inveestigation1,Agent theCorrectAgent)
        {
            Console.WriteLine("enter how many do you wont to insert !!");
            string y;
            int langth;
            do
            {
                y = Console.ReadLine();
            }
            while (!int.TryParse(y, out  langth) && langth >= theCorrectAgent.arreyOfSensors.Length);
            sensor[] sensorHeSend = new sensor[langth];
            
            for (int i = 0; i < langth; i++)
                {
                Console.WriteLine("enter the kind of sensor do you wont to get heym" +
                    "1 ,hearing_sensor : 2 , audioSensor");
                if(int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice < 6)
                {
                    switch (choice)
                    {
                        case 1:
                            theCorrectAgent.arreyOfSensors[i] = new hearing_sensor(inveestigation1);
                            break;
                        case 2:
                            theCorrectAgent.arreyOfSensors[i] = new audioSensor(inveestigation1);
                            break;
                        case 3:
                            //theCorrectAgent.arreyOfSensors.Length[i] = 
                            break;
                    }
                }
                else Console.WriteLine("is wrong");
            }
            foreach (sensor f in theCorrectAgent.arreyOfSensors)
            {
                Console.WriteLine(f);
            }
            //inveestigation1.startAscing();
            return sensorHeSend;
        }
    }
}
