using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_10
{
    public class Grandfather : Person
    {
        public Grandfather()

        {

        }

        public Grandfather(int number, string name)
        {
            Name = name;
            Age = number;
            Gender = "Мужчина";
        }
        public override void GrowingUp()
        {

            if (Age >= 93)
            {
                Age += 1;
            }

            else if (Age < 93)
            {
                Console.WriteLine(Name + " умер(ла) ");
            }

        }
        public override int Height { get; set; }
        public override int Weight { get; set; }
    }
}
