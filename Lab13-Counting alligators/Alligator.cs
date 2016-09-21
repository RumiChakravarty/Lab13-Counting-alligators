using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Counting_alligators
{
    class Alligator:Countable
    {
        int count;

        

         void Countable.incrementCount()
        {
            count++;
        }

         void Countable.resetCount()
        {
            count = 0;
        }

        int Countable.getCount()
        {
            return count;
        }

        

        string Countable.getCountString()
        {
            return count.ToString();
        }
    }
}
