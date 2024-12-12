using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masiv_B_obratnom_poradke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер масива: ");
            int alle = int.Parse(Console.ReadLine());

            int[] marAyer = new int[alle];

            for (int i = 0; i < marAyer.Length; i++)
            {
                Console.Write("Введите элемент: ");
                marAyer[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Выводим заполеный массив на экран: ");

            for (int i = marAyer.Length - 1, number = 1; i >= 0; i--, number++)
            {
                Console.WriteLine("Масив под №" + number + " = " + marAyer[i]);
            }
        }
    }
}
