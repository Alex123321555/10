using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_10
{
   public class Son : Person
    {
        
        public Son(string name, Mother woman, Father man)
        {
            Name = name;
            Father = man;
            Mother = woman;
            Age = 0;
            Console.WriteLine("У " + man.Name + " и " + woman.Name + " родился сын " + Name + " ему " + Age.ToString() + " лет ");
            
        }

        public override void GrowingUp()
        {

            if (Age >= 96)
            {
                Age += 1;
            }

            else if (Age < 96)
            {
                Console.WriteLine(Name + " умер(ла) ");
            }

        }
        public override int Height { get; set; }
        public override int Weight { get; set; }

    }
}
