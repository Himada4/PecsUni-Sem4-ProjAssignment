using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM91U5
{
    internal class Common
    {
        public int getServiceFee(int time)
        {
            double ratio = (double)time / 60;
            int serviceFee = (int)(ratio * 15000);
            return serviceFee;
        }

        public int RoundUpToMultipleOf30(int value)
        {
            return (int)(Math.Ceiling((double)value / 30) * 30);
        }
    }
}
