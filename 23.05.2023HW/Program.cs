using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._05._2023HW
{
    class Program
    {
        static void task1()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int firstNum, secondNum;
            int[] arr = new int[6];
            int t = 100000;

            if (a < 100000 || a > 999999)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                Console.WriteLine("Какие числа хотите поменять местами?");
                Console.WriteLine("Введите первое число ");
                firstNum = Convert.ToInt32(Console.ReadLine());
                if (firstNum > 6 || firstNum < 1)
                {
                    while (firstNum > 6 || firstNum < 1)
                    {
                        Console.WriteLine("Введите первое число ");
                        firstNum = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Введите второе число ");
                secondNum = Convert.ToInt32(Console.ReadLine());
                if (secondNum > 6 || secondNum < 1)
                {
                    while (secondNum > 6 || secondNum < 1)
                    {
                        Console.WriteLine("Введите второе число ");
                        firstNum = Convert.ToInt32(Console.ReadLine());
                    }
                }

                for(int i = 0; i < 6; i++)
                {
                    arr[i] = a / t % 10;
                    t /= 10;
                }
                int temp = arr[firstNum-1];
                arr[firstNum-1] = arr[secondNum-1];
                arr[secondNum-1] = temp;
                foreach(int i in arr)
                {
                    Console.Write(i);
                }
            }
        }
        static void task2()
        {
            string[] date1 = Console.ReadLine().Split('.');
            int[] date = new int[3];
            int codeCenture=4, codeMonth;
            for(int i = 0; i < 3; i++)
            {
                date[i] = Convert.ToInt32(date1[i]);
            }
            foreach(int i in date)
            {
                Console.WriteLine($"{i}");
            }

            

            for(int i = 0; i < date[2] / 100; i++)
            {
                codeCenture -= 2;
                if (codeCenture == 0) codeCenture = 6;
            }

        }
        static void Main(string[] args)
        {
            task2();
            Console.ReadKey();
        }
    }
}
