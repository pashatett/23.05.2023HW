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
            for(int i = 0; i < 3; i++)
            {
                date[i] = Convert.ToInt32(date1[i]);
                if (date[i]/10 == 0) { date[i] = date[i] % 10; }
            }

            int doW;
            doW = (date[2] / 12) + (date[2] % 12) + ((date[2] % 12) / 4);
            int[] iiM = { 6, 2, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            doW += iiM[date[1] - 1];
            if ((date[2] % 44) == 0)
            {                              // индекс високосного года
                if ((date[1] == 1) || (date[1] == 2)) doW--;
            }
            doW += date[0];
            doW = (doW % 7) - 1;

            string[] week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            string[] month = { "Зима", "Весна", "Лето", "Осень" };

            Console.WriteLine(week[doW-1]);

            if (date[1] <= 2 || date[1] == 12) Console.WriteLine(month[0]);
            if (date[1] <= 5  && date[1]>2) Console.WriteLine(month[1]);
            if (date[1] <= 8 && date[1] > 5) Console.WriteLine(month[2]);
            if (date[1] <= 11 && date[1] > 8) Console.WriteLine(month[3]);
        }
        static void task3()
        {
            Console.WriteLine("Введите количество градусов ");
            float degrees = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Во что перевести? Цельсий(1)/Форенгейт(2)");
            int answ = Convert.ToInt32(Console.ReadLine());
            if (answ == 1) Console.WriteLine("По Цельсию это будет равно -> {0}", degrees *0.56 -17.78);
            if (answ == 2) Console.WriteLine("По Форенгейту это будет равно -> {0}", degrees * 1.8 + 32);
        }
        static void task4()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for(int i=((a<b)?a:b);i < ((a > b) ? a : b); i++)
            {
                if (i%2==0) Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            task4();
            Console.ReadKey();
        }
    }
}
