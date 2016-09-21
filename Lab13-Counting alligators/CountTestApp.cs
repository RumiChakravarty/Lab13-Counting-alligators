using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Counting_alligators
{
    class CountTestApp
    {
        static void Main(string[] args)
        {
            Countable objAlligator = new Alligator();
            Console.WriteLine("Counting Alligator...");
            CountUtil.count(objAlligator, 4);
            Console.WriteLine("\n");
            Cloneable objSheep = new Sheep();
            Console.WriteLine("Counting Sheep...");
                                   

            CountUtil.count(objSheep, 3);
            Console.WriteLine("\n");
            Cloneable sheepDuplicate = objSheep.cloneAnimal(objSheep);
            CountUtil.count(sheepDuplicate, 3);
            Console.WriteLine("\n");
            objSheep.resetCount();
            
            CountUtil.count(objSheep, 1);

        }
    }
}
