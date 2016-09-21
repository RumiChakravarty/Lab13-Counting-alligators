using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Counting_alligators
{
    class Sheep : Countable, Cloneable
    {
        private int count;
      string name = "Blackie";

         int Countable.getCount()
        {
            return count;
        }

        string Countable.getCountString()
        {
            return count.ToString();
        }

         void Countable.incrementCount()
        {
            count++;
        }

        
        void Countable.resetCount()
        {
            count = 0;
        }



        //public string toUpdateName(string Name)
        //{
        //    name = Name;
            
        //    return name;
        //}

        string Cloneable.getName()
        {
            return name;
        }

        Cloneable Cloneable.cloneAnimal(Cloneable animal)
        {
            animal = new Sheep();
            animal.setCloneName("Dolly");
            return animal;
        }

        void Cloneable.setCloneName(string name)
        {
            this.name = name;
        }
    }
}
