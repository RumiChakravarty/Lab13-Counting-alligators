using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Counting_alligators
{
    interface ICountable
    {
        void incrementCount();
        void resetCount();
        int getCount();
        String getCountString();

    }
}
