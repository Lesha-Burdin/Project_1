using System;
namespace args_cmd
{
    class Program1
    {
        static void Main()
        {
            int a, b; // Определяем переменные

                Console.WriteLine("Input 2 numbers. The programm will calculate a factorial of maximum number");
                string[] num = Console.ReadLine().Split(' ');  //Считываем 2 числа
                a = int.Parse(num[0]);
                b = int.Parse(num[1]);




            int n;
            int Fact = 1;
            if (a > b)    //Определяем наибольшее число. От наибольшего числа будем брать факториал
                n = a;
            else
                n = b;

            for (int i = 1; i <= n; i++) // Цикл подсчета факториала
                Fact *= i;
            Console.WriteLine($"Factorial of the maximum number: {Fact}"); //Вывод в консоль
        }
    }

}