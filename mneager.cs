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
            SimpleAgent simpleAgent1 = new SimpleAgent();
            inveestigation inveestigation1 = new inveestigation(simpleAgent1);
            hearing_sensor hearing_Sensor1 = new hearing_sensor(inveestigation1);
            audioSensor audioSensor1 = new audioSensor(inveestigation1);
            
        }
        public sensor[] yourChoice(inveestigation inveestigation1)
        {
            Console.WriteLine("enter how many do you wont to insert !!");
            int langth =Convert.ToInt32( Console.ReadLine());
            sensor[] sensorHeSend = new sensor[langth];
            for (int i = 0; i < langth; i++)
                {
                Console.WriteLine("enter the kind of sensor do you wont to get heym" +
                    "1 ,hearing_sensor : 2 , audioSensor");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice < 6)
                {
                    switch (choice)
                    {
                        case 1:
                            sensorHeSend[i] = new hearing_sensor(inveestigation1);
                            break;
                        case 2:
                            sensorHeSend[i] = new audioSensor(inveestigation1);
                            break;
                        case 3:
                            //sensorHeSend[i] = 
                            break;
                    }
                }
                else Console.WriteLine("is wrong");
            }
            return sensorHeSend;
        }
    }
}
