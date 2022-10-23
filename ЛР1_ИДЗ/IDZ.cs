using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1_IDZ
{
    internal class IDZ
    {
        public static void DoTask()
        {
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());
            float [] numb = new float[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите "+(i+1)+" число ");
                numb[i] = float.Parse(Console.ReadLine());
            }
            Console.Write("Сумма квадратов максимального, минимального элементов и среднего арифметического всех элеметов равна равна: ");
            float min=numb.Min();
            float max=numb.Max();
            float sred=0;
            foreach (int i in numb)
            {
                sred += i;
            }
            sred=sred/numb.Length;
            Console.WriteLine(min*min + max*max+ sred*sred);
        }
    }
}
