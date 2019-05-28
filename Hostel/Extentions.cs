using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel
{
    static class Extentions
    {
        public static bool isnotEmpty(string[]values,string checkinput)
        {
            foreach(string val in values)
            {
                if (val == checkinput)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
