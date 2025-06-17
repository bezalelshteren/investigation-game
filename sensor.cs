using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigation_game
{
    public abstract class sensor
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }

        private bool isActivate = false;

        public sensor(inveestigation inveestigation)
        {
            ListOfSensors(inveestigation);
        }

        public virtual bool activate()
        {
            this.isActivate = !isActivate;
            return isActivate;
        }
        public void ListOfSensors(inveestigation inveestigation)
        {
            Type type = this.GetType();
            bool isContains = false;
            foreach (sensor s in inveestigation.kindOfsensors)
            {
                if (s.GetType() == type)
                {
                    isContains = true;
                    break;
                }
            }
            if (!isContains)
            {
                inveestigation.kindOfsensors.Add(this);
            }
        }
    }
    
}
