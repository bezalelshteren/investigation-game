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
            mneager mneager = new mneager();
            mneager.yourChoice(inveestigation1,simpleAgent1);
            inveestigation1.startAscing(simpleAgent1);
        }
    }
}
