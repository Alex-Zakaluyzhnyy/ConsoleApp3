using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static int DescendingOrder(int num)
        {
            int[] numbers = new int[5];
            int devide = 0;
            int decide = 10;
            int i = 0;
            int swap;
            string chislo = "";
            if (num > 0)
            {
                while (devide > 0)
                {
                    devide = num % decide;
                    num = num / decide;
                    numbers[i] = devide;
                    i++;
                }
                for (int k = 0; k < (numbers.Length - 1); k++)
                {
                    for (int j = 1; j < numbers.Length; j++)
                    {
                        if (numbers[k] < numbers[j])
                        {
                            swap = numbers[j];
                            numbers[j] = numbers[k];
                            numbers[k] = swap;
                        }
                    }

                }
                for (int n = 0; n < numbers.Length; n++)
                {
                    chislo = (string)(chislo + numbers[n]);
                }
                return(Convert.ToInt32(chislo));
            }
            else return 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int chito = Program.DescendingOrder(a);
            Console.WriteLine(chito);
            Console.ReadLine();
        }
    }
}
