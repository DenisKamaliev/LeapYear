using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFirstTask
{
    public class LeapYearCheck
    {
        public static bool LeapYearCheckFunc(int Year)
        {
            if (Year % 4 == 0 && Year % 100 != 0)
                return true;
            else if (Year % 400 == 0)
                return true;
            return false;
        }
    }
}
