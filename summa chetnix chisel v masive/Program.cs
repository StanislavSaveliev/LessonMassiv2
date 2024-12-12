using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summa_chetnix_chisel_v_masive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер масива: ");
            int alle = int.Parse(Console.ReadLine());

            int[] marAyer = new int[alle];
            int sum = 0;

            for (int i = 0; i < marAyer.Length; i++)
            {
                Console.Write("Введите элемент: ");
                marAyer[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Выводим заполеный массив на экран: ");

            for (int i = 0, number = 1; i < marAyer.Length; i++, number++)
            {
                Console.WriteLine("Масив под №" + number + " = " + marAyer[i]);

                if (marAyer[i] % 2 == 0)
                {
                    sum += marAyer[i];                    
                }
            }
            Console.WriteLine("Сумма четных чисел = " + sum);

        }

        
    }
}
