using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_10
{
   public class Mother : Grandmother
    {
        
        public Mother(int number, string name)
        {
            Name = name;
            Age = number;
            Gender = "Женщина";
        }

        public override void GrowingUp()
        {

            if (Age >= 100)
            {
                Age += 1;
            }

            else if (Age < 100)
            {
                Console.WriteLine(Name + " умер(ла) ");
            }

        }
        
    }
}
