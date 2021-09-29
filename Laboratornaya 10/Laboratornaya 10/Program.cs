using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Mother Masha = new Mother(28, "Маша");
            Father Ivan = new Father( 36, "Иван");
            Son Aleksey = new Son("Алексей", Masha, Ivan);
            Ivan.Sleep(5);
            Masha.Eating("борщ");
            Console.ReadKey();

            
        }
    }
}
