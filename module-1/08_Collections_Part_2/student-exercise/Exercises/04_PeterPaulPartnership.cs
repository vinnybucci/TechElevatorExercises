using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Modify and return the given Dictionary as follows: if "Peter" has $50 or more, AND "Paul" has $100 or more,
         * then create a new "PeterPaulPartnership" worth a combined contribution of a quarter of each partner's
         * current worth.
         *
         * PeterPaulPartnership({"Peter": 50000, "Paul": 100000}) → {"Peter": 37500, "Paul": 75000, "PeterPaulPartnership": 37500}
         * PeterPaulPartnership({"Peter": 3333, "Paul": 1234567890}) → {"Peter": 3333, "Paul": 1234567890}
         *
         */
        public Dictionary<string, int> PeterPaulPartnership(Dictionary<string, int> peterPaul)
        {
            //peter 50 or more and paul 100 or more divide by .25 so it would be a double at some point, new peterpaulpartnership combining each 
            double peter;
            double paul;
            double peterPaulPartnership;
            if (peterPaul["Peter"] > 5000 && peterPaul["Paul"] > 10000)
            {
                peter = peterPaul["Peter"] * .25;
                paul = peterPaul["Paul"] * .25;
                peterPaul["Peter"] -= (int)peter;
                peterPaul["Paul"] -= (int)paul;
                peterPaulPartnership = peter + paul;
                peterPaul["PeterPaulPartnership"] = (int)peterPaulPartnership;
            }
                    
            return peterPaul;
        }
    }
}
