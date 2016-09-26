using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Counting_alligators
{
    class Sheep : ICountable, ICloneable
    {
        private int count;
      string name = "Blackie";

         int ICountable.getCount()
        {
            return count;
        }

        string ICountable.getCountString()
        {
            return count.ToString();
        }

         void ICountable.incrementCount()
        {
            count++;
        }

        
        void ICountable.resetCount()
        {
            count = 0;
        }



      

        string ICloneable.getName()
        {
            return name;
        }

        ICloneable ICloneable.cloneAnimal(ICloneable animal)
        {
            animal = new Sheep();
            animal.setCloneName("Dolly");
            return animal;
        }

        void ICloneable.setCloneName(string name)
        {
            this.name = name;
        }
    }
}
