using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_10
{
    public class Father : Grandfather
    {

        public Father(int chislo, string name)
            
        {
            Name = name;
            Age = chislo;
            Gender = "Мужчина";
        }

        public override void GrowingUp()
        {

            if (Age >= 90 )
            {
                Age += 1;
            }

            else if (Age < 90)
            {
                Console.WriteLine(Name + " умер(ла) ");
            }

        }

    }

}

