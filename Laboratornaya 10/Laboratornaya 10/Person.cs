using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_10
{
    public class Person
    {
        // Конструктор по умолчанию
        public Person()

        {

        }


        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public virtual int Height { get; set; }
        public virtual int Weight { get; set; }

        public Person Mother;
        public Person Father;


        // Функция "Старение"
        public virtual void GrowingUp()
        {

            if (Age >= 115)
            {
                Age += 1;
            }

            else if (Age < 115)
            {
                Console.WriteLine(Name + " умер(ла) ");
            }

        }


        // Функция "Прием пищи"
        public void Eating(string food)
        {

            Console.WriteLine(Name + " съел(а) вкусный " + food);

        }

        // Функция "Coн"
        public void Sleep(int hours)
        {
            if (hours > 8)
            {
                Console.WriteLine(Name + " хорошо поспал(а) ");

            }
            else Console.WriteLine(Name + " не выспался ");


        }

    }
}
