using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigation_game
{
    public class sensor
    {
        public string name { get; set; }
        public string type { get; set; }

        private bool isActivate = false;

        public virtual bool activate()
        {
            this.isActivate = !isActivate;
            return isActivate;
        }
    }
    
}
