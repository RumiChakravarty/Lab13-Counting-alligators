using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Counting_alligators
{
    interface ICloneable:ICountable
    {
        string getName();
        ICloneable cloneAnimal(ICloneable animal);
        void setCloneName(string name);

    }
}
