using System;

namespace ConsoleApp2
{
    /* 
     ВСЕМ ПРИВЕТ СЕГОДНЯ 19/07/2021 И Я РЕШИЛ СТАТЬ ПРОГРАММИСТОМ
    */
    class Program // СЕГОДНЯ Я УЗНАЛ КАК ДЕЛАЮТСЯ КОМЕНТАРИИ
    {
        static void Main(string[] args)
        {
            /*
            // UNDONE: доработать следующуюся функциональность 
            Console.Write("Hello World!");
            // TODO: добавить новую функцию
            // HACK: this code is temp. it should be fixed or deleted
            // Hello gys this is my new code


            //AlifAcademy.ClassWork.03.08.2021

            //string h = Console.ReadLine();
            //int h1 = int.Parse(h);
            //double h2 = double.Parse(h);
            //x = 5; error
            int x = 0;
            int y = 5;
            Console.WriteLine($"y = {y + y + y}");
            Console.WriteLine("y = " + y + x);
            Console.WriteLine("y = {0}", 5 + 5);
            //int 24d; error
            //int x = 5; error
            //int z = 4.5; error
            y = 10;
            Console.WriteLine($"y = {y}"); //10
            double x1 = 5.5;
            double x2 = 5.5;
            double result = x1 + x2;
            Console.WriteLine($"Result = {result}");
            // + +
            // - -
            // / деление
            // * умножение
            // 20 % 2 = остаток деление на 2
            // Math.Pow() возводит в степень
            // Math.Sqrt()
            result = x1 % x2;
            int y1 = 5;
            double resultY1 = Math.Pow(y1, 2);
            double resultY2 = Math.Sqrt(y1);
            Console.WriteLine($"Result = {result}");
            Console.ReadKey(); */
            
            
            
            
            //AlifAcademy.HomeWork.03.08.2021
            // ex:1
            double a = 16.80;
            double b= 12.40 ;
            double result = Math.Sqrt(a*b) ;
            Console.WriteLine($"Result of 1 EX={result}");

            // ex:2
            decimal A= 1.40m;
            decimal B= -5.50m;
            decimal C= 0.60m;
            
            decimal AC = A - C;
            decimal BC = C - B;
            decimal summa = AC + BC;

            Console.WriteLine("AC=" + AC);
            Console.WriteLine("BC=" + BC);
            Console.WriteLine("Result of 2 EX:" + summa);

            // ex:3
            double x1 = -6.20;
            double y1 = 5.20;
            double x2 = 2.10;
            double y2 = 9.80;

            double Distant = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Result of 3 EX:" + Distant);

            // ex:4
            int z = 41;
            int x = z / 10;
            int v = (z%10)*10;
            int o = v + x;

            Console.WriteLine("Result of 4 EX: " + o);

            // ex:5
            int N = 10985;
            int R = N / 60;

            Console.WriteLine("Result of 5 EX: " + R);

            // ex:6
            int K = 202;
            int n = K % 7;

            Console.WriteLine("Result of 6 EX: " + n);
            Console.ReadKey();

            // There is also another way to write this code

            /* if (n == 0)
            {
                System.Console.WriteLine("Номер дня недели: 0 - Воскресенье");
            }
            else if (n == 1)
            {
                System.Console.WriteLine("Номер дня недели: 1 - Понедельник");
            }
            else if (n == 2)
            {
                System.Console.WriteLine("Номер дня недели: 2 - Вторник");
            }
            else if (n == 3)
            {
                System.Console.WriteLine("Номер дня недели: 3 - Среда");
            }
            else if (n == 4)
            {
                System.Console.WriteLine("Номер дня недели: 4 - Четверг");
            }
            else if (n == 5)
            {
                System.Console.WriteLine("Номер дня недели: 5 - Пятница");
            }
            else if (n == 6)
            {
                System.Console.WriteLine("Номер дня недели: 6 - Суббота");
            }*/

        }
       
    }
}
