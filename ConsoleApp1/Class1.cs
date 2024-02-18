using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Class1
    {
        /// <summary>
        /// Обнуляет разряд десятков в трехзначном числе
        /// </summary>
        /// <param name="number">трехзначное число</param>
        /// <returns>Заданное число с обнуленным разрядом десятков</returns>
        static int ResetTenPlace(int number)
        {
            int LastDigit = number % 10;
            int FirstdDigit = number / 100;
            int multiplier = 100;
            return ((FirstdDigit * multiplier) + LastDigit);
        }


        /// <summary>
        /// Определяет цвет поля шахматной доски
        /// </summary>
        /// <param name="x">координата x</param>
        /// <param name="y">координата y</param>
        /// <returns>Цвет поля</returns>
        /// <exception cref="ArgumentException">x and y must be in the range 1-8</exception>
        static string CheckerBoardColor(int x, int y)
        {
            if (x <= 0 || x >= 9 || y <= 0 || y >= 9)
                throw new ArgumentException("x and y must be in the range 1-8");
            return (x + y) % 2 == 0 ? "Черный" : "Белый";
        }


        /// <summary>
        /// Возвращает количество корней квадратного уравнения
        /// </summary>
        /// <param name="A">Коэффициент A</param>
        /// <param name="B">Коэффициент B</param>
        /// <param name="C">Коэффициент C</param>
        /// <returns>Количество корней</returns>
        /// <exception cref="ArgumentException"></exception>
        static int CountOfRoots(double A, double B, double C)
        {
            if (A == 0)
                throw new ArgumentException("A mustn't be 0");
            var discriminant = Math.Pow(B, 2) - (4 * A * C);
            if (discriminant < 0)
                return 0;
            return discriminant > 0 ? 2 : 1;
        }


        /// <summary>
        /// Возвращает минимум из двух вещественных чисел
        /// </summary>
        /// <param name="A">Число 1(double)</param>
        /// <param name="B">Число 2(double)</param>
        /// <returns>Минимум</returns>
        static double MinOfTwo(double A, double B)
        {
            return A <= B ? A : B;
        }


        /// <summary>
        /// Возвращает произведение всех четных чисел на [А, B]
        /// </summary>
        /// <param name="A">Число A(целое)</param>
        /// <param name="B">Число B(целое)</param>
        /// <returns>Произведение</returns>
        static double ProductNumbersFromAToB(int A, int B)
        {
            double prod = 1.0;
            for (int i = A; i <= B; i++)
            {
                if (i % 2 == 0)
                    prod *= i;
            }
            return prod;
        }


        /// <summary>
        /// Вычисляет количество чисел в наборе(ввод с консоли) меньших K, делящихся нацело на K
        /// </summary>
        /// <param name="K">Число K(целое)</param>
        /// <returns></returns>
        static (int, int) CountLessHunkyK(int K)
        {
            int cnt_lessK = 0;
            int cnt_hunkyK = 0;
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if (number == 0)
                    break;
                if (number < K)
                    cnt_lessK += 1;
                if (number % K == 0)
                    cnt_hunkyK += 1;
            }
            return (cnt_lessK, cnt_hunkyK);
        }


        // Описал перечислимый тип Seasons, но не смог найти ему практического применения в методе
        enum Seasons { Winter, Spring, Summer, Autumn };
        /*
        string Name(Seasons c)
        {
            switch (c)
            {
                case Seasons.Winter: return "Зима";
                case Seasons.Spring: return "Весна";
                case Seasons.Summer: return "Лето";
                case Seasons.Autumn: return "Осень";
                default: return "Нет такого времени года";
            }
        }
        */


        /// <summary>
        /// Возвращает время года по номеру месяца(1..12)
        /// </summary>
        /// <param name="number_month">Номер месяца(1..12)</param>
        /// <returns>Время года</returns>
        static string MonthNumberSeason(int number_month)
        {
            switch(number_month)
            {
                case 1:
                    return "Winter";
                case 2:
                    return "Winter";
                case 3:
                    return "Spring";
                case 4:
                    return "Spring";
                case 5:
                    return "Spring";
                case 6:
                    return "Summer";
                case 7:
                    return "Summer";
                case 8:
                    return "Summer";
                case 9:
                    return "Autumn";
                case 10:
                    return "Autumn";
                case 11:
                    return "Autumn";
                case 12:
                    return "Winter";
                default:
                    return "Нет такого времени года";
            }
        }


        /// <summary>
        /// Выводит на консоль N строк вида: "Месяц №<номер месяца>, его сезон: <сезон для этого месяца>"
        /// </summary>
        /// <param name="N">Количество выводимых строк</param>
        static void ConclusionSeason(int N)
        {
            Random rnd = new Random();
            while (N != 0)
            {
                int number_month = rnd.Next(1, 12);
                Console.WriteLine($"Месяц № <{number_month}>, его сезон: <{MonthNumberSeason(number_month)}>");
                N--;
            }
        }


        static void Main()
        {
            Console.WriteLine("Проверка работы методов");

            Console.WriteLine("Задание 1");
            int a = -458;
            Console.WriteLine(ResetTenPlace(a));

            Console.WriteLine("Задание 2");
            int x = 2;
            int y = 3;
            Console.WriteLine(CheckerBoardColor(3,8));
            Console.WriteLine(CheckerBoardColor(2,4));

            Console.WriteLine("Задание 4");
            Console.WriteLine(MinOfTwo(2.5, 2.6));

            Console.WriteLine("Задание 5");
            Console.WriteLine(ProductNumbersFromAToB(2, 10));

            Console.WriteLine("Задание 6");
            Console.WriteLine(CountLessHunkyK(3));

            Console.WriteLine("Задание 7");
            Console.WriteLine(MonthNumberSeason(8));
            Console.WriteLine(MonthNumberSeason(2));

            Console.WriteLine("Задание 8");
            ConclusionSeason(5);

        }
        
    }
}
