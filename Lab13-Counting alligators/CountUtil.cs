using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Counting_alligators
{
    class CountUtil
    {
        public static void count(Countable c, int maxCount)
        {
            for (int i = 0; i < maxCount; i++)
            {
                c.incrementCount();
                Console.WriteLine(c.getCountString() + " " + c.GetType().ToString().Split('.')[1]);

            }
        }


        public static void count(Cloneable c,int maxCount)
        {
            for (int i = 0; i < maxCount; i++)
            {
                c.incrementCount();
                Console.WriteLine(c.getCountString() + " " + c.getName());

            }
        }
    }
}
