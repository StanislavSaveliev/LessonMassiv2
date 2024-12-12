using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_obratnom_poradke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marAyer = {10, 7, 30, 4};

            int min = marAyer[0];

            for (int i = 1; i < marAyer.Length; i++)
            {
                if (marAyer[i] < min)
                {
                    min = marAyer[i];
                    
                }
                
            }
            Console.WriteLine("Наименьшее число в масиве: " + min);
        }
    }
}
