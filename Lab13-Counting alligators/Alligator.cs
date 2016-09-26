using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Counting_alligators
{
    class Alligator:ICountable
    {
        int count;

        

         void ICountable.incrementCount()
        {
            count++;
        }

         void ICountable.resetCount()
        {
            count = 0;
        }

        int ICountable.getCount()
        {
            return count;
        }

        

        string ICountable.getCountString()
        {
            return count.ToString();
        }
    }
}
