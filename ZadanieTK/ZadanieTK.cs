using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieTK
{
    public class Zadanie
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Напишите баллы за модуль Разработка, администрирование и защита баз данных: ");
            int modul1 = Max(22);

            Console.WriteLine("Напишите баллы за модуль Разработка модулей программного обеспечения для компьютерных систем: ");
            int modul2 = Max(38);

            Console.WriteLine("Напишите баллы за модуль Сопровождение и обслуживание программного обеспечения компьютерных систем: ");
            int modul3 = Max(20);


            int sum = modul1 + modul2 + modul3;

            if (sum >= 56)
            {
                Console.WriteLine(5);
                Console.ReadLine();
            }
            else if (sum >= 32)
            {
                Console.WriteLine(4);
                Console.ReadLine();
            }
            else if (sum >= 16)
            {
                Console.WriteLine(3);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(2);
                Console.ReadLine();
            }          
        }

        

        public static int Max(int max)
        {
            int result;
            while (true)
            {                
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    if (result <= max && result >= 0)
                    {
                        break;
                    }
                }
                Console.WriteLine(-1);
                
            }
            return result;
        }
    }
}
