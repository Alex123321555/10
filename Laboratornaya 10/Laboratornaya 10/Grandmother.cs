using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_10
{
    public class Grandmother : Person
    {
        public Grandmother()

        {

        }

        public Grandmother(int number, string name)
        {
            Name = name;
            Age = number;
            Gender = "Женщина";
        }

        public override void GrowingUp()
        {

            if (Age >= 102)
            {
                Age += 1;
            }

            else if (Age < 102)
            {
                Console.WriteLine(Name + " умер(ла) ");
            }

        }
        public override int Height { get; set; }
        public override int Weight { get; set; }
    }
}
