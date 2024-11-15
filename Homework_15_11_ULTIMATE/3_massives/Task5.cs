using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_massives
{
    internal class Task5Class
    {
        public static void Task5(int[] array, int number)
        {
            int tempIEnd = array.Length - 1;
            int tempIStart = 0;
            int tempIMid = array.Length / 2;

            while (tempIStart <= tempIEnd)
            {
                tempIMid = (tempIEnd + tempIStart) / 2;
                Console.WriteLine();
                if (array[tempIMid] == number)
                {
                    Console.WriteLine($"Ваше число под индексом: {tempIMid}");
                    return;
                }
                else if (number > array[tempIMid])
                    tempIStart = tempIMid + 1;
                else
                    tempIEnd = tempIMid - 1;
            }

            Console.WriteLine("Вашего числа нет(");
        }
    }
}
